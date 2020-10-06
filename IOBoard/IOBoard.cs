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

        enum Packet : byte { STX = 0x02, ETX = 0x03, CHECKSUM = 0x00, DATA = 0x00, MAX_LENGTH = 0xf0, ERROR = 0x00, SUCCESS = 0x01 };

        CheckBox[] cbHex = new CheckBox[10];
        TextBox[] tbData = new TextBox[10];
        Button[] btnSend = new Button[10];

        public IOBoard()
        {
            InitializeComponent();
            RefreshCOMPortName();
            this.Size = new Size(1000, 600);

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

        private void SendData(byte[] txData)
        {
            try
            {
                serialPort.Write(txData, 0, txData.Length);
                debugHex.AppendText(DateTime.Now.ToString("\r\n[HH:mm:ss] [TX] ") + BitConverter.ToString(txData).Replace("-", " "));
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

        System.Collections.Concurrent.ConcurrentQueue<byte> rxBuffer = new System.Collections.Concurrent.ConcurrentQueue<byte>();
        Message RxMessage = new Message();
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
                            debugHex.AppendText(DateTime.Now.ToString("\r\n[HH:mm:ss] [RX] ") + BitConverter.ToString(buff).Replace("-", " "));
                            debugText.AppendText(ConvertHexToString(BitConverter.ToString(buff).Replace("-", "")));
                        }));

                        for (int i = 0; i < iRecivedSize; i++)
                        {
                            rxBuffer.Enqueue(buff[i]);
                        }
                        //ProcessMessage();
                    }
                    catch { }
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

        private void ProcessMessage()
        {
            while ((rxBuffer.Count != 0) || (RxMessage.nextStage == (byte)Stage.PARSING) || (RxMessage.nextStage == (byte)Stage.CHECKSUM))
            {
                switch (RxMessage.nextStage)
                {
                    case (byte)Stage.START:
                        break;
                    default:
                        break;

                }
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
            ofd.Filter = "펌웨어 파일 (*.bin) | *.bin |모든 파일 (*.*) | *.*";

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

        private void BtnFileSendSend_Click(object sender, EventArgs e)
        {
            try
            {
                string saveImageFileName = ShowFileOpenDialog();
                FileStream fs = new FileStream(saveImageFileName, FileMode.Open, FileAccess.Read);
                UInt16 FwTotalNo = (UInt16)(fs.Length / 192 + 1);
                byte[] tmpFwData = new byte[192];
                byte[] tmpPayload = new byte[192 + 2];

                if (serialPort.IsOpen)
                {
                    debugText.AppendText("전송 중 ");
                    for (Int32 i = 0; i < FwTotalNo; i++)
                    {
                        fs.Read(tmpFwData, 0, 192);
                        Array.Copy(tmpFwData, 0, tmpPayload, 2, 192);
                        tmpPayload[0] = (byte)((i >> 8) & 0xFF);
                        tmpPayload[1] = (byte)(i  & 0xFF);
                        SendPacket(0x1f, tmpPayload);

                        if (i % 10 == 0)
                        {
                            debugText.AppendText(".");
                        }
                    }
                    debugText.AppendText(" 끝\r\n");
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
            byte[] tmpPayload = new byte[0];
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
            byte[] tmpPayload = new byte[6];
            SendPacket(0x1a, tmpPayload);
        }

        private void btnRequestWattMeterValue_Click(object sender, EventArgs e)
        {
            byte[] tmpPayload = new byte[6];
            SendPacket(0x1b, tmpPayload);
        }
    }


}
