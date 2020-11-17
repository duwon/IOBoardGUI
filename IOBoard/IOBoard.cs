using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOBoard
{
    public partial class IOBoard : Form
    {
        enum Stage : byte
        {
            START = 0,
            MESSAGETYPE = 1,
            LENGTH = 10,
            DATA = 2,
            PARSING = 4,
            CHECKSUM = 3,
            SEND = 5,
            RESEND = 6,
            STOP = 7,
            WRITE = 8,
            END = 9
        };

        public struct Message
        {
            public byte nextStage;
            public byte type;
            public byte length;
            public byte datasize;
            public byte dataCount;
            public byte checksum;
            public byte startFlag;
            public byte[] data;

            public Message(byte[] data)
            {
                this.nextStage = 0;
                this.type = 0;
                this.length = 0;
                this.datasize = 0;
                this.checksum = 0;
                this.data = data;
                dataCount = 0;
                startFlag = 0;
            }
        }

        public struct IOStatus
        {
            public float Volt;
            public float Current;
            public float Cos;
            public float Active;
            public float Reactive;
            public float Apparent;
            public float Active_Energy;
            public UInt16 Rtd;
            public UInt16 Dps;
            public UInt16 Ps;
            public UInt16[] Ai;
            public byte[] Di;
            public byte[] Do;
        }

        enum Packet : byte { STX = 0x02, ETX = 0x03, CHECKSUM = 0x00, DATA = 0x00, MAX_LENGTH = 0xf0, ERROR = 0x00, SUCCESS = 0x01 };
        System.Collections.Concurrent.ConcurrentQueue<byte> rxBuffer = new System.Collections.Concurrent.ConcurrentQueue<byte>();
        Message RxMessage = new Message();
        IOStatus stIOStatus;


        CheckBox[] cbHex = new CheckBox[10];
        TextBox[] tbData = new TextBox[10];
        Button[] btnSend = new Button[10];

        [System.ComponentModel.Browsable(false)]
        public IOBoard()
        {
            InitializeComponent();
            RefreshCOMPortName();
            this.Size = new Size(1000, 630);

            RxMessage.data = new byte[256];
            stIOStatus.Ai = new UInt16[2];
            stIOStatus.Di = new byte[4];
            stIOStatus.Do = new byte[2];

            //panel_setConfig
            panel_config.Visible = false;
            panel_config.Location = new Point(317, 0);
            //panel_viewStatus
            panel_status.Visible = false;
            panel_status.Location = new Point(317, 0);
            //panel_sendData
            string[] strtbText, strcbHex = new String[10];
            strtbText = Properties.Settings.Default.tbText.Split(new char[] { '`' });
            strcbHex = Properties.Settings.Default.cbHex.Split(new char[] { ',' });
            cbPortName.Text = Properties.Settings.Default.serialPortNum;

            for (int i = 0; i < 10; i++)
            {
                //
                // cbHex
                //
                cbHex[i] = new CheckBox();
                cbHex[i].Text = "";
                cbHex[i].AutoSize = true;
                cbHex[i].Location = new System.Drawing.Point(560, 21 + (i * 28));
                cbHex[i].Name = "cbHex" + i.ToString();
                cbHex[i].Size = new System.Drawing.Size(15, 14);
                cbHex[i].Text = "HEX";
                cbHex[i].TabIndex = 101 + 3 * i;
                cbHex[i].UseVisualStyleBackColor = true;
                if (strcbHex[i] == "true")
                {
                    cbHex[i].Checked = true;
                }
                else
                {
                    cbHex[i].Checked = false;
                }
                cbHex[i].CheckedChanged += new System.EventHandler(this.cbHex_CheckedChanged);
                panel_sendData.Controls.Add(cbHex[i]);

                // 
                // btnSend
                // 
                btnSend[i] = new Button();
                btnSend[i].Location = new System.Drawing.Point(612, 18 + (i * 28));
                btnSend[i].Margin = new System.Windows.Forms.Padding(2);
                btnSend[i].Name = "btnSend" + i.ToString(); ;
                btnSend[i].Size = new System.Drawing.Size(49, 23);
                btnSend[i].TabIndex = 103 + 3 * i;
                btnSend[i].Text = "전송";
                btnSend[i].UseVisualStyleBackColor = true;
                btnSend[i].Click += new System.EventHandler(this.btnSend_Click);
                panel_sendData.Controls.Add(btnSend[i]);

                // 
                // tbData
                // 
                tbData[i] = new TextBox();
                tbData[i].Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                tbData[i].Location = new System.Drawing.Point(11, 18 + (i * 28));
                tbData[i].Name = "tbData" + i.ToString(); ;
                tbData[i].Size = new System.Drawing.Size(543, 22);
                tbData[i].TabIndex = 102 + 3 * i;
                try
                {
                    tbData[i].Text = strtbText[i];
                }
                catch { }
                panel_sendData.Controls.Add(tbData[i]);
            }
        }

        private void IOBoard_Load(object sender, EventArgs e)
        {
            
        }
        private void IOBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void cbHex_CheckedChanged(object sender, EventArgs e)
        {
            string scbHex = "";
            for (int i = 0; i < cbHex.Length; i++)
            {
                if (cbHex[i].Checked == true)
                {
                    scbHex = scbHex + "true,";
                }
                else
                {
                    scbHex = scbHex + ",";
                }
            }
            Properties.Settings.Default.cbHex = scbHex;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string saveSettingtbText = "";

            for (int i = 0; i < btnSend.Length; i++)
            {
                if (sender.Equals(btnSend[i]))
                {
                    if (cbHex[i].Checked == true)
                    {
                        tbData[i].Text = tbData[i].Text.ToUpper();         // HEX 체크박스 체크되어 있으면 대문자로 변환
                        tbData[i].Text = tbData[i].Text.Replace("0X", ""); //16진수 표시 0x 제거

                        string[] hexValuesSplit = tbData[i].Text.Split(' ');
                        byte[] txBuffer = new byte[500];
                        int dataLength = 0;
                        foreach (string hex in hexValuesSplit)
                        {
                            try
                            {
                                txBuffer[dataLength++] = (byte)Convert.ToInt32(hex, 16);
                            }
                            catch
                            {
                                dataLength--;
                            }
                        }
                        Array.Resize(ref txBuffer, dataLength);

                        tbData[i].Text = BitConverter.ToString(txBuffer).Replace("-", " ");

                        SendData(txBuffer);
                    }
                    else
                    {
                        byte[] txBuffer = new byte[500];
                        int dataLength = 0;
                        foreach (char ch in tbData[i].Text.ToCharArray())
                        {
                            txBuffer[dataLength++] = (byte)Convert.ToInt32(ch);
                        }
                        Array.Resize(ref txBuffer, dataLength);
                        SendData(txBuffer);
                    }

                }
                saveSettingtbText = saveSettingtbText + tbData[i].Text + "`";
            }
            Properties.Settings.Default.tbText = saveSettingtbText;
        }

        private void ChangebtnCOMOpen()
        {
            if (serialPort.IsOpen)
            {
                btnCOMOpen.BackgroundImage = Properties.Resources.btnROpen;
                btnCOMOpen.ForeColor = Color.Black;
                btnCOMOpen.Text = "CLOSE";
                Properties.Settings.Default.serialPortNum = cbPortName.Text;
            }
            else
            {
                btnCOMOpen.BackgroundImage = Properties.Resources.btnRClose;
                btnCOMOpen.ForeColor = Color.Black;
                btnCOMOpen.Text = "OPEN";
            }
        }

        private void OpenSerialPort()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = cbPortName.Text;
                    serialPort.BaudRate = Convert.ToInt32(tbBoudrate.Text);

                    serialPort.RtsEnable = true;
                    serialPort.Open();
                }
            }
            catch { }
            ChangebtnCOMOpen();
        }
        private void CloseSerialPort()
        {
            if (null != serialPort)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
            ChangebtnCOMOpen();
        }

        private byte CalChecksum(byte[] txPacket)
        {
            byte tmpCalChecksum = 0;
            for (int i = 0; i < (txPacket.Length - 1) ; i++)
            {
                tmpCalChecksum ^= txPacket[i];
            }

            return tmpCalChecksum;
        }

        private void SendPacket(byte msgID, byte[] txPayload)
        {
            byte[] txPacket = new byte[txPayload.Length + 5];
            Array.Copy(txPayload, 0, txPacket, 3, txPayload.Length);

            txPacket[0] = (byte)Packet.STX;
            txPacket[1] = msgID;
            txPacket[2] = (byte)txPayload.Length;
            txPacket[txPacket.Length - 2] = (byte)Packet.ETX;
            txPacket[txPacket.Length - 1] = CalChecksum(txPacket);

            SendData(txPacket);
        }

        bool flag_viewSendData = true;
        private void SendData(byte[] txData)
        {
            try
            {
                serialPort.Write(txData, 0, txData.Length);
                if (flag_viewSendData)
                {
                    debugHex.AppendText(DateTime.Now.ToString("\r\n[HH:mm:ss] [TX] ") + BitConverter.ToString(txData).Replace("-", " "));
                }
            }
            catch (System.Exception ex)
            {
                //debugText.AppendText(ex.Message + "\r\n");
            }
        }

        private string ConvertHexToString(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int iRecivedSize = serialPort.BytesToRead;

                if (iRecivedSize != 0) // 수신 데이터가 있으면
                {
                    byte[] buff = new byte[iRecivedSize];

                    try
                    {
                        serialPort.Read(buff, 0, iRecivedSize);
                        this.Invoke(new Action(delegate ()
                        {
                            if (flag_viewSendData)
                            {
                                debugHex.AppendText(DateTime.Now.ToString("\r\n[HH:mm:ss] [RX] ") + BitConverter.ToString(buff).Replace("-", " "));
                                debugText.AppendText(ConvertHexToString(BitConverter.ToString(buff).Replace("-", "")));
                            }
                        }));

                        for (int i = 0; i < iRecivedSize; i++)
                        {
                            rxBuffer.Enqueue(buff[i]);
                        }
                        ProcessMessage();
                    }
                    catch ( System.Exception ex )
                    {
                        this.Invoke(new Action(delegate ()
                        {
                            this.debugText.AppendText(ex.Message);
                            this.debugText.AppendText("\r\n");
                        }));
                    }
                }
            }
            catch (System.Exception ex)
            {
                this.Invoke(new Action(delegate ()
                {
                    this.debugText.AppendText(ex.Message);
                    this.debugText.AppendText("\r\n");
                }));
            }
        }

        public void ProcessMessage()
        {
            byte _tch;
            while ((rxBuffer.Count != 0) || (RxMessage.nextStage == (byte)Stage.PARSING))
            {
                switch (RxMessage.nextStage)
                {
                    case (byte)Stage.START:
                        for (int i = 0; i < rxBuffer.Count; i++)
                        {
                            rxBuffer.TryDequeue(out _tch);
                            if (_tch == (byte)Packet.STX)
                            {
                                RxMessage.nextStage = (byte)Stage.MESSAGETYPE;
                                break;
                            }
                        }
                        break;
                    case (byte)Stage.MESSAGETYPE:
                        rxBuffer.TryDequeue(out RxMessage.type);
                        RxMessage.nextStage = (byte)Stage.LENGTH;
                        break;
                    case (byte)Stage.LENGTH:
                        rxBuffer.TryDequeue(out RxMessage.length);
                        RxMessage.nextStage = (byte)Stage.DATA;
                        break;
                    case (byte)Stage.DATA:
                        rxBuffer.TryDequeue(out RxMessage.data[RxMessage.dataCount]);
                        RxMessage.dataCount++;

                        if (RxMessage.dataCount == RxMessage.length)
                        {
                            RxMessage.dataCount = 0;
                            RxMessage.nextStage = (byte)Stage.END;
                        }
                        break;
                    case (byte)Stage.END:
                        rxBuffer.TryDequeue(out _tch);
                        if (_tch == (byte)Packet.ETX)
                        {
                            RxMessage.nextStage = (byte)Stage.CHECKSUM;
                        }
                        else
                        {
                            RxMessage.nextStage = (byte)Stage.START;
                        }
                        break;
                    case (byte)Stage.CHECKSUM:
                        byte[] tmpRxMessageData = new byte[RxMessage.length + 5];
                        rxBuffer.TryDequeue(out _tch);

                        tmpRxMessageData[0] = (byte)Packet.STX;
                        tmpRxMessageData[1] = RxMessage.type;
                        tmpRxMessageData[2] = (byte)RxMessage.length;
                        Array.Copy(RxMessage.data, 0, tmpRxMessageData, 3, RxMessage.length);
                        tmpRxMessageData[RxMessage.length + 5 - 2] = (byte)Packet.ETX;

                        if(_tch == CalChecksum(tmpRxMessageData))
                        {
                            RxMessage.nextStage = (byte)Stage.PARSING;
                        }
                        else
                        {
                            RxMessage.nextStage = (byte)Stage.START;
                        }
                        break;
                    case (byte)Stage.PARSING:
                        ParsingMessage();
                        RxMessage.nextStage = (byte)Stage.START;
                        break;
                    default:
                        break;

                }
            }
        }

        int fwSeqNumLast = 10;
        private void ParsingMessage()
        {
            switch (RxMessage.type)
            {
                case 0x20: //MSGCMD_INFO_IOVALUE 0x20U
                    Console.WriteLine("MSGCMD_INFO_IOVALUE 0x20U");

                    stIOStatus.Volt = BitConverter.ToSingle(RxMessage.data, 0);
                    stIOStatus.Current = BitConverter.ToSingle(RxMessage.data, 4);
                    stIOStatus.Cos = BitConverter.ToSingle(RxMessage.data, 8);
                    stIOStatus.Active = BitConverter.ToSingle(RxMessage.data, 12);
                    stIOStatus.Reactive = BitConverter.ToSingle(RxMessage.data, 16);
                    stIOStatus.Apparent = BitConverter.ToSingle(RxMessage.data, 20);
                    stIOStatus.Active_Energy = BitConverter.ToSingle(RxMessage.data, 24);

                    stIOStatus.Rtd = BitConverter.ToUInt16(RxMessage.data, 28);
                    stIOStatus.Dps = BitConverter.ToUInt16(RxMessage.data, 30);
                    stIOStatus.Ps = BitConverter.ToUInt16(RxMessage.data, 32);
                    stIOStatus.Ai[0] = BitConverter.ToUInt16(RxMessage.data, 34);
                    stIOStatus.Ai[1] = BitConverter.ToUInt16(RxMessage.data, 36);

                    stIOStatus.Di[0] = RxMessage.data[38];
                    stIOStatus.Di[1] = RxMessage.data[39];
                    stIOStatus.Di[2] = RxMessage.data[40];
                    stIOStatus.Di[3] = RxMessage.data[41];
                    stIOStatus.Do[0] = RxMessage.data[42];
                    stIOStatus.Do[1] = RxMessage.data[43];

                    this.Invoke(new Action(delegate ()
                    {
                        tbDI0.Text = stIOStatus.Di[0].ToString();
                        tbDI1.Text = stIOStatus.Di[1].ToString();
                        tbDI2.Text = stIOStatus.Di[2].ToString();
                        tbDI3.Text = stIOStatus.Di[3].ToString();

                        tbDO0Value.Text = stIOStatus.Do[0].ToString();
                        tbDO1Value.Text = stIOStatus.Do[1].ToString();
                    }));
                    break;
                case 0x21: //MSGCMD_RESPONSE_TIME 0x21U
                    Console.WriteLine("MSGCMD_RESPONSE_TIME 0x21U");
                    this.Invoke(new Action(delegate ()
                    {
                        lbBoardTime.Text = (RxMessage.data[0] + 2000).ToString() + "-" + RxMessage.data[1].ToString() + "-" + RxMessage.data[2].ToString() + " " + RxMessage.data[3].ToString() + ":" + RxMessage.data[4].ToString() + ":" + RxMessage.data[5].ToString() + " V" + RxMessage.data[6].ToString() + "." + RxMessage.data[7].ToString();
                    }));
                    
                    break;
                case 0x23: //MSGCMD_RESPONSE_CONFIG
                    Console.WriteLine("MSGCMD_RESPONSE_CONFIG 0x23U");
                    this.Invoke(new Action(delegate ()
                    {
                        tbDO0.Text = RxMessage.data[0].ToString();
                        tbDO1.Text = RxMessage.data[1].ToString();
                        tbRTDCycle.Text = RxMessage.data[2].ToString();
                        tbAICycle.Text = RxMessage.data[3].ToString();
                        tbDICycle.Text = RxMessage.data[4].ToString();
                        tbDPSCycle.Text = RxMessage.data[5].ToString();
                        tbPSCycle.Text = RxMessage.data[6].ToString();
                        tbPMMode.Text = RxMessage.data[7].ToString();
                        tbPMCycle.Text = RxMessage.data[8].ToString();
                        tbPMVolt.Text = (RxMessage.data[9] + (RxMessage.data[10] << 8)).ToString();
                        tbPMCurrent.Text = RxMessage.data[11].ToString();
                        tbPMFreq.Text = RxMessage.data[12].ToString();
                    }));
                    break;
                case 0x2F: //Firmware ACK
                    flag_viewSendData = false;
                    Console.WriteLine("MSGCMD_RESPONSE_FW_ACK 0x2FU");
                    byte[] tmpPayload = new byte[192 + 2];
                    int fwSeqNum = ((RxMessage.data[0] & 0x7F) << 8) + RxMessage.data[1] + 1;
                    if (fwSeqNum == firmwarePacket.GetLength(0))
                    {
                        this.Invoke(new Action(delegate ()
                        {
                            debugText.AppendText(" 100%  END\r\n");
                            flag_viewSendData = true;
                        }));
                    }
                    else if (fwSeqNum < firmwarePacket.GetLength(0))
                    { 
                        for (int fwByteIndex = 0; fwByteIndex < 194; fwByteIndex++)
                        {
                            tmpPayload[fwByteIndex] = firmwarePacket[fwSeqNum, fwByteIndex];
                        }
                        SendPacket(0x1f, tmpPayload);

                        if((fwSeqNum % (firmwarePacket.GetLength(0) / 10)) == 0)
                        {
                            this.Invoke(new Action(delegate ()
                            {
                                debugText.AppendText((fwSeqNum * 100 / firmwarePacket.GetLength(0)).ToString() + "% ");
                            }));
                            //fwSeqNumLast += 10;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrone Num : %d", fwSeqNum);
                    }
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
        }

        private void BtnCOMOpen_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                CloseSerialPort();
            }
            else
            {
                OpenSerialPort();
            }
        }

        private void RefreshCOMPortName()
        {
            try
            {
                cbPortName.Items.Clear();
                cbPortName.Items.AddRange(SerialPort.GetPortNames());
            }
            catch { }

            if (cbPortName.Items.Count > 0)
            {
                cbPortName.SelectedIndex = 0;  // 컴포트의 0번째를 표시
            }
        }

        private void CbPortName_DropDown(object sender, EventArgs e)
        {
            RefreshCOMPortName();
        }

        /// <summary>
        /// 그림파일오픈창을 로드후 해당 파일의 FullPath를 가져온다.
        /// 출처 : https://mirwebma.tistory.com/121
        /// </summary>
        /// <returns>파일의 FullPath 파일이 없거나 선택을 안할경우 ""를 리턴</returns>
        public string ShowFileOpenDialog()
        {
            //파일오픈창 생성 및 설정
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AutoUpgradeEnabled = false;
            ofd.Title = "전송 할 파일 선택";
            ofd.Filter = "펌웨어 파일 (*.bin) | *.bin|모든 파일 (*.*) | *.*";

            //파일 오픈창 로드
            DialogResult dr = ofd.ShowDialog();

            //OK버튼 클릭시
            if (dr == DialogResult.OK)
            {
                //File명과 확장자를 가지고 온다.
                string fileName = ofd.SafeFileName;
                //File경로와 File명을 모두 가지고 온다.
                string fileFullName = ofd.FileName;
                //File경로만 가지고 온다.
                string filePath = fileFullName.Replace(fileName, "");

                //File경로 + 파일명 리턴
                return fileFullName;
            }
            //취소버튼 클릭시 또는 ESC키로 파일창을 종료 했을경우
            else if (dr == DialogResult.Cancel)
            {
                return "";
            }

            return "";
        }

        byte[,] firmwarePacket;
        private void BtnFileSendSend_Click(object sender, EventArgs e)
        {
            try
            {
                string saveImageFileName = ShowFileOpenDialog();
                FileStream fs = new FileStream(saveImageFileName, FileMode.Open, FileAccess.Read);
                UInt16 FwTotalNo = (UInt16)(fs.Length / 192 + 1);
                byte[] tmpFwData = new byte[192];
                byte[] tmpPayload = new byte[192 + 2];

                //if (serialPort.IsOpen)
                //{
                //    debugText.AppendText("전송 중 ");
                //    for (Int32 i = 0; i < FwTotalNo; i++)
                //    {
                //        fs.Read(tmpFwData, 0, 192);
                //        Array.Copy(tmpFwData, 0, tmpPayload, 2, 192);
                //        tmpPayload[0] = (byte)((i >> 8) & 0xFF);
                //        tmpPayload[1] = (byte)(i  & 0xFF);
                //        SendPacket(0x1f, tmpPayload);
                //
                //        if (i % 5 == 0)
                //        {
                //            debugText.AppendText(".");
                //        }
                //    }
                //    debugText.AppendText(" 끝\r\n");
                //}
                //else
                //{
                //    debugText.AppendText("통신포트를 먼저 연결하세요.\r\n");
                //}

                firmwarePacket = new byte[FwTotalNo, 194];
                if (serialPort.IsOpen)
                {
                    debugText.AppendText("패킷 생성");
                    for (Int32 i = 0; i < FwTotalNo; i++)
                    {
                        fs.Read(tmpFwData, 0, 192);
                        for(int fwByteIndex=0; fwByteIndex<192; fwByteIndex++)
                        {
                            firmwarePacket[i, fwByteIndex + 2] = tmpFwData[fwByteIndex];
                        }
                        firmwarePacket[i,0] = (byte)((i >> 8) & 0xFF);
                        firmwarePacket[i,1] = (byte)(i  & 0xFF);
                    }
                    firmwarePacket[FwTotalNo - 1, 0] |= 0x80; /* 마지막 패킷은 순번의 최상위 비트 SET */

                    for (int fwByteIndex = 0; fwByteIndex < 194; fwByteIndex++)
                    {
                        tmpPayload[fwByteIndex] = firmwarePacket[0, fwByteIndex];
                    }
                    SendPacket(0x1f, tmpPayload);
                }
                else
                {
                    debugText.AppendText("통신포트를 먼저 연결하세요.\r\n");
                }
                fs.Close();
            }
            catch { }
            
        }

        private void btnRequestIOBoardInfo_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[0];
            SendPacket(0x11, tmpPayload);
        }

        private void btnUpdateConfig_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[13];
            tmpPayload[0] = (byte)Convert.ToInt32(tbDO0.Text);
            tmpPayload[1] = (byte)Convert.ToInt32(tbDO1.Text);
            tmpPayload[2] = (byte)Convert.ToInt32(tbRTDCycle.Text);
            tmpPayload[3] = (byte)Convert.ToInt32(tbAICycle.Text);
            tmpPayload[4] = (byte)Convert.ToInt32(tbDICycle.Text);
            tmpPayload[5] = (byte)Convert.ToInt32(tbDPSCycle.Text);
            tmpPayload[6] = (byte)Convert.ToInt32(tbPSCycle.Text);
            tmpPayload[7] = (byte)Convert.ToInt32(tbPMMode.Text);
            tmpPayload[8] = (byte)Convert.ToInt32(tbPMCycle.Text);
            tmpPayload[9] = (byte)Convert.ToInt32(tbPMVolt.Text);
            tmpPayload[10] = (byte)(Convert.ToInt32(tbPMVolt.Text) >> 8);
            tmpPayload[11] = (byte)Convert.ToInt32(tbPMCurrent.Text);
            tmpPayload[12] = (byte)Convert.ToInt32(tbPMFreq.Text);
            SendPacket(0x12, tmpPayload);
        }

        private void btnRequestConfig_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[0];
            SendPacket(0x13, tmpPayload);
        }

        private void btnUpdateTime_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[6];
            tmpPayload[0] = (byte)(DateTime.Now.Year - 2000);
            tmpPayload[1] = (byte)(DateTime.Now.Month);
            tmpPayload[2] = (byte)(DateTime.Now.Day);
            tmpPayload[3] = (byte)(DateTime.Now.Hour);
            tmpPayload[4] = (byte)(DateTime.Now.Minute);
            tmpPayload[5] = (byte)(DateTime.Now.Second);

            SendPacket(0x14, tmpPayload);
        }

        private void btnRequestCalWattMeter_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[0];
            SendPacket(0x1a, tmpPayload);
        }

        private void btnRequestWattMeterValue_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[0];
            SendPacket(0x1b, tmpPayload);
        }

        private void btnRequestReset_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[0];
            SendPacket(0x99, tmpPayload);
        }

        private void btnSetConfig_Click(object sender, EventArgs e)
        {
            if(panel_config.Visible == true)
            {
                panel_config.Visible = false;
                btnSetConfig.BackColor = Color.Gainsboro;
            }
            else
            {
                panel_config.Visible = true;
                btnSetConfig.BackColor = Color.Green;

                panel_status.Visible = false;
                btnViewStatusValue.BackColor = Color.Gainsboro;
            }
        }

        private void btnViewStatusValue_Click(object sender, EventArgs e)
        {
            if (panel_status.Visible == true)
            {
                panel_status.Visible = false;
                btnViewStatusValue.BackColor = Color.Gainsboro;
            }
            else
            {
                panel_status.Visible = true;
                btnViewStatusValue.BackColor = Color.Green;

                panel_config.Visible = false;
                btnSetConfig.BackColor = Color.Gainsboro;
            }
        }

        private void timer_1s_interrupt(object sender, EventArgs e)
        {

        }

        private void btn_DO_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[2];
            Button [] btnDO = new Button[] { btn_DO1, btn_DO2};
            for(int i=0; i<btnDO.Length; i++)
            {
                if (sender.Equals(btnDO[i]) == true)
                {
                    if (btnDO[i].BackColor != Color.Green)
                    {
                        btnDO[i].BackColor = Color.Green;
                    }
                    else
                    {
                        btnDO[i].BackColor = Color.Gainsboro;
                    }
                }

                if(btnDO[i].BackColor == Color.Green)
                {
                    tmpPayload[i] = 1;
                }
                else
                {
                    tmpPayload[i] = 0;
                }
            }
            SendPacket(0x15, tmpPayload);
        }
    }


}
