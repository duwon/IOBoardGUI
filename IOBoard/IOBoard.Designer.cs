namespace IOBoard
{
    partial class IOBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IOBoard));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbBoudrate = new System.Windows.Forms.TextBox();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.debugText = new System.Windows.Forms.TextBox();
            this.debugHex = new System.Windows.Forms.TextBox();
            this.panel_sendData = new System.Windows.Forms.Panel();
            this.btnFileSendSend = new System.Windows.Forms.Button();
            this.btnRequestIOBoardInfo = new System.Windows.Forms.Button();
            this.btnUpdateConfig = new System.Windows.Forms.Button();
            this.btnRequestConfig = new System.Windows.Forms.Button();
            this.btnUpdateTime = new System.Windows.Forms.Button();
            this.btnRequestReset = new System.Windows.Forms.Button();
            this.panel_config = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.tbInputPF = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tbInputRatio = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tbInputVolt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDO1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPMFreq = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPMCurrent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPMVolt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPMCycle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPSCycle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDPSCycle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDICycle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAICycle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRTDCycle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDO0 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSetConfig = new System.Windows.Forms.Button();
            this.lbBoardTime = new System.Windows.Forms.Label();
            this.btnViewStatusValue = new System.Windows.Forms.Button();
            this.timer1s = new System.Windows.Forms.Timer(this.components);
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.tbSPIWriteReg0 = new System.Windows.Forms.TextBox();
            this.tbSPIWriteData0 = new System.Windows.Forms.TextBox();
            this.btnSPIWrite0 = new System.Windows.Forms.Button();
            this.btnSPIRead0 = new System.Windows.Forms.Button();
            this.tbSPIReadReg0 = new System.Windows.Forms.TextBox();
            this.panel_ICSET = new System.Windows.Forms.Panel();
            this.btnRegRead8 = new System.Windows.Forms.Button();
            this.btnRegWrite8 = new System.Windows.Forms.Button();
            this.btnRegRead7 = new System.Windows.Forms.Button();
            this.btnRegWrite7 = new System.Windows.Forms.Button();
            this.btnRegRead6 = new System.Windows.Forms.Button();
            this.btnRegWrite6 = new System.Windows.Forms.Button();
            this.btnRegRead5 = new System.Windows.Forms.Button();
            this.btnRegWrite5 = new System.Windows.Forms.Button();
            this.btnRegRead4 = new System.Windows.Forms.Button();
            this.btnRegWrite4 = new System.Windows.Forms.Button();
            this.btnRegRead3 = new System.Windows.Forms.Button();
            this.btnRegWrite3 = new System.Windows.Forms.Button();
            this.btnRegRead2 = new System.Windows.Forms.Button();
            this.btnRegWrite2 = new System.Windows.Forms.Button();
            this.btnRegRead1 = new System.Windows.Forms.Button();
            this.btnRegWrite1 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.tbWriteRegData8 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tbWriteRegData7 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tbWriteRegData6 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tbWriteRegData5 = new System.Windows.Forms.TextBox();
            this.btnRegRead0 = new System.Windows.Forms.Button();
            this.btnRegWrite0 = new System.Windows.Forms.Button();
            this.btnSPIWrite3 = new System.Windows.Forms.Button();
            this.tbSPIWriteData3 = new System.Windows.Forms.TextBox();
            this.tbSPIWriteReg3 = new System.Windows.Forms.TextBox();
            this.btnSPIRead2 = new System.Windows.Forms.Button();
            this.tbSPIReadReg2 = new System.Windows.Forms.TextBox();
            this.btnSPIWrite2 = new System.Windows.Forms.Button();
            this.tbSPIWriteData2 = new System.Windows.Forms.TextBox();
            this.tbSPIWriteReg2 = new System.Windows.Forms.TextBox();
            this.btnSPIRead1 = new System.Windows.Forms.Button();
            this.tbSPIReadReg1 = new System.Windows.Forms.TextBox();
            this.btnSPIWrite1 = new System.Windows.Forms.Button();
            this.tbSPIWriteData1 = new System.Windows.Forms.TextBox();
            this.tbSPIWriteReg1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tbWriteRegData1 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tbWriteRegData4 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbWriteRegData3 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tbWriteRegData2 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.tbWriteRegData0 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_WriteReg1 = new System.Windows.Forms.Button();
            this.tbSY7D609_WR1 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_WriteReg2 = new System.Windows.Forms.Button();
            this.tbSY7D609_WR2 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_WriteReg3 = new System.Windows.Forms.Button();
            this.tbSY7D609_WR3 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_ReadReg5 = new System.Windows.Forms.Button();
            this.tbSY7D609_R5 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_ReadReg6 = new System.Windows.Forms.Button();
            this.tbSY7D609_R6 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_ReadReg7 = new System.Windows.Forms.Button();
            this.tbSY7D609_R7 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_ReadReg8 = new System.Windows.Forms.Button();
            this.tbSY7D609_R8 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_ReadReg1 = new System.Windows.Forms.Button();
            this.tbSY7D609_R1 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_ReadReg2 = new System.Windows.Forms.Button();
            this.tbSY7D609_R2 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_ReadReg3 = new System.Windows.Forms.Button();
            this.tbSY7D609_R3 = new System.Windows.Forms.TextBox();
            this.btnSY7D609_WriteReg4 = new System.Windows.Forms.Button();
            this.btnSY7D609_ReadReg4 = new System.Windows.Forms.Button();
            this.tbSY7D609_WR4 = new System.Windows.Forms.TextBox();
            this.tbSY7D609_R4 = new System.Windows.Forms.TextBox();
            this.timer_100ms = new System.Windows.Forms.Timer(this.components);
            this.btn_DO2 = new System.Windows.Forms.Button();
            this.btn_DO1 = new System.Windows.Forms.Button();
            this.btnSettingSPI_IC = new System.Windows.Forms.Button();
            this.btnSetEMP_IC = new System.Windows.Forms.Button();
            this.panel_PowerSET = new System.Windows.Forms.Panel();
            this.btnSumPowerReset = new System.Windows.Forms.Button();
            this.btnRequestCalWattMeter = new System.Windows.Forms.Button();
            this.btnUpdateCalValue = new System.Windows.Forms.Button();
            this.btnRequestWattMeterValue = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.tbVGain = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.tbIGain = new System.Windows.Forms.TextBox();
            this.panel_status = new System.Windows.Forms.Panel();
            this.btnStatusRequestCont = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.btnSumPowerMeter = new System.Windows.Forms.Button();
            this.btnPowerMeter = new System.Windows.Forms.Button();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.btnReadPSTemp = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.tbStatusPMCos = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tbPS = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbStatusDP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbStatusPMEnergy = new System.Windows.Forms.TextBox();
            this.btnRequestStatus = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDO1Value = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbStatusPMCurrent = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbStatusPMVolts = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDI3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbDI2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbDI1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbDI0 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbStatusPMApparent = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbStatusPMReactive = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbStatusPMActive = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbRTD = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbDO0Value = new System.Windows.Forms.TextBox();
            this.btnCOMOpen = new System.Windows.Forms.Button();
            this.btnReadDPTemp = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.tbAI7 = new System.Windows.Forms.TextBox();
            this.tbAI0 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tbAI1 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tbAI2 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.tbAI3 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tbAI4 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.tbAI5 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.tbAI6 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_config.SuspendLayout();
            this.panel_ICSET.SuspendLayout();
            this.panel_PowerSET.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbBoudrate);
            this.panel1.Controls.Add(this.btnCOMOpen);
            this.panel1.Controls.Add(this.cbPortName);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 103);
            this.panel1.TabIndex = 23;
            // 
            // tbBoudrate
            // 
            this.tbBoudrate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoudrate.Location = new System.Drawing.Point(3, 37);
            this.tbBoudrate.Name = "tbBoudrate";
            this.tbBoudrate.Size = new System.Drawing.Size(67, 22);
            this.tbBoudrate.TabIndex = 21;
            this.tbBoudrate.Text = "115200";
            this.tbBoudrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbPortName
            // 
            this.cbPortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPortName.DropDownWidth = 80;
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(3, 5);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(67, 22);
            this.cbPortName.Sorted = true;
            this.cbPortName.TabIndex = 19;
            this.cbPortName.DropDown += new System.EventHandler(this.CbPortName_DropDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 640);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.debugText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.debugHex);
            this.splitContainer1.Size = new System.Drawing.Size(1812, 107);
            this.splitContainer1.SplitterDistance = 912;
            this.splitContainer1.TabIndex = 24;
            // 
            // debugText
            // 
            this.debugText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugText.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugText.Location = new System.Drawing.Point(0, 3);
            this.debugText.Multiline = true;
            this.debugText.Name = "debugText";
            this.debugText.ReadOnly = true;
            this.debugText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugText.Size = new System.Drawing.Size(910, 102);
            this.debugText.TabIndex = 0;
            this.debugText.Text = "TEXT\r\n";
            // 
            // debugHex
            // 
            this.debugHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugHex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debugHex.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugHex.Location = new System.Drawing.Point(0, 3);
            this.debugHex.Multiline = true;
            this.debugHex.Name = "debugHex";
            this.debugHex.ReadOnly = true;
            this.debugHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugHex.Size = new System.Drawing.Size(894, 102);
            this.debugHex.TabIndex = 0;
            this.debugHex.Text = "HEX \r\n";
            // 
            // panel_sendData
            // 
            this.panel_sendData.Location = new System.Drawing.Point(317, 0);
            this.panel_sendData.Name = "panel_sendData";
            this.panel_sendData.Size = new System.Drawing.Size(667, 296);
            this.panel_sendData.TabIndex = 25;
            // 
            // btnFileSendSend
            // 
            this.btnFileSendSend.Location = new System.Drawing.Point(220, 137);
            this.btnFileSendSend.Name = "btnFileSendSend";
            this.btnFileSendSend.Size = new System.Drawing.Size(90, 44);
            this.btnFileSendSend.TabIndex = 34;
            this.btnFileSendSend.Text = "펌웨어 전송";
            this.btnFileSendSend.UseVisualStyleBackColor = true;
            this.btnFileSendSend.Click += new System.EventHandler(this.BtnFileSendSend_Click);
            // 
            // btnRequestIOBoardInfo
            // 
            this.btnRequestIOBoardInfo.Location = new System.Drawing.Point(114, 14);
            this.btnRequestIOBoardInfo.Name = "btnRequestIOBoardInfo";
            this.btnRequestIOBoardInfo.Size = new System.Drawing.Size(90, 44);
            this.btnRequestIOBoardInfo.TabIndex = 35;
            this.btnRequestIOBoardInfo.Text = "보드 정보 요청";
            this.btnRequestIOBoardInfo.UseVisualStyleBackColor = true;
            this.btnRequestIOBoardInfo.Click += new System.EventHandler(this.btnRequestIOBoardInfo_Click);
            // 
            // btnUpdateConfig
            // 
            this.btnUpdateConfig.Location = new System.Drawing.Point(559, 23);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(90, 44);
            this.btnUpdateConfig.TabIndex = 36;
            this.btnUpdateConfig.Text = "CONFIG 전송";
            this.btnUpdateConfig.UseVisualStyleBackColor = true;
            this.btnUpdateConfig.Click += new System.EventHandler(this.btnUpdateConfig_Click);
            // 
            // btnRequestConfig
            // 
            this.btnRequestConfig.Location = new System.Drawing.Point(559, 80);
            this.btnRequestConfig.Name = "btnRequestConfig";
            this.btnRequestConfig.Size = new System.Drawing.Size(90, 44);
            this.btnRequestConfig.TabIndex = 37;
            this.btnRequestConfig.Text = "CONFIG 요청";
            this.btnRequestConfig.UseVisualStyleBackColor = true;
            this.btnRequestConfig.Click += new System.EventHandler(this.btnRequestConfig_Click);
            // 
            // btnUpdateTime
            // 
            this.btnUpdateTime.Location = new System.Drawing.Point(220, 14);
            this.btnUpdateTime.Name = "btnUpdateTime";
            this.btnUpdateTime.Size = new System.Drawing.Size(90, 44);
            this.btnUpdateTime.TabIndex = 38;
            this.btnUpdateTime.Text = "시간 설정";
            this.btnUpdateTime.UseVisualStyleBackColor = true;
            this.btnUpdateTime.Click += new System.EventHandler(this.btnUpdateTime_Click);
            // 
            // btnRequestReset
            // 
            this.btnRequestReset.Location = new System.Drawing.Point(220, 192);
            this.btnRequestReset.Name = "btnRequestReset";
            this.btnRequestReset.Size = new System.Drawing.Size(90, 44);
            this.btnRequestReset.TabIndex = 41;
            this.btnRequestReset.Text = "재시작";
            this.btnRequestReset.UseVisualStyleBackColor = true;
            this.btnRequestReset.Click += new System.EventHandler(this.btnRequestReset_Click);
            // 
            // panel_config
            // 
            this.panel_config.Controls.Add(this.label53);
            this.panel_config.Controls.Add(this.label52);
            this.panel_config.Controls.Add(this.tbInputPF);
            this.panel_config.Controls.Add(this.label51);
            this.panel_config.Controls.Add(this.tbInputRatio);
            this.panel_config.Controls.Add(this.label50);
            this.panel_config.Controls.Add(this.tbInputVolt);
            this.panel_config.Controls.Add(this.label7);
            this.panel_config.Controls.Add(this.tbDO1);
            this.panel_config.Controls.Add(this.label8);
            this.panel_config.Controls.Add(this.tbPMFreq);
            this.panel_config.Controls.Add(this.label9);
            this.panel_config.Controls.Add(this.tbPMCurrent);
            this.panel_config.Controls.Add(this.label10);
            this.panel_config.Controls.Add(this.tbPMVolt);
            this.panel_config.Controls.Add(this.label11);
            this.panel_config.Controls.Add(this.tbPMCycle);
            this.panel_config.Controls.Add(this.label6);
            this.panel_config.Controls.Add(this.tbPSCycle);
            this.panel_config.Controls.Add(this.btnRequestConfig);
            this.panel_config.Controls.Add(this.label5);
            this.panel_config.Controls.Add(this.btnUpdateConfig);
            this.panel_config.Controls.Add(this.tbDPSCycle);
            this.panel_config.Controls.Add(this.label3);
            this.panel_config.Controls.Add(this.tbDICycle);
            this.panel_config.Controls.Add(this.label4);
            this.panel_config.Controls.Add(this.tbAICycle);
            this.panel_config.Controls.Add(this.label2);
            this.panel_config.Controls.Add(this.tbRTDCycle);
            this.panel_config.Controls.Add(this.label1);
            this.panel_config.Controls.Add(this.tbDO0);
            this.panel_config.Location = new System.Drawing.Point(317, 313);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(667, 296);
            this.panel_config.TabIndex = 26;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label53.Location = new System.Drawing.Point(452, 213);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(104, 15);
            this.label53.TabIndex = 32;
            this.label53.Text = "0: 200V, 1: 380";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label52.Location = new System.Drawing.Point(276, 269);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(58, 15);
            this.label52.TabIndex = 31;
            this.label52.Text = "Input PF";
            // 
            // tbInputPF
            // 
            this.tbInputPF.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbInputPF.Location = new System.Drawing.Point(358, 266);
            this.tbInputPF.Name = "tbInputPF";
            this.tbInputPF.Size = new System.Drawing.Size(77, 22);
            this.tbInputPF.TabIndex = 30;
            this.tbInputPF.Text = "65";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label51.Location = new System.Drawing.Point(276, 241);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(74, 15);
            this.label51.TabIndex = 29;
            this.label51.Text = "Input Ratio";
            // 
            // tbInputRatio
            // 
            this.tbInputRatio.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbInputRatio.Location = new System.Drawing.Point(358, 238);
            this.tbInputRatio.Name = "tbInputRatio";
            this.tbInputRatio.Size = new System.Drawing.Size(77, 22);
            this.tbInputRatio.TabIndex = 28;
            this.tbInputRatio.Text = "6";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label50.Location = new System.Drawing.Point(276, 213);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(68, 15);
            this.label50.TabIndex = 27;
            this.label50.Text = "Input Volt";
            // 
            // tbInputVolt
            // 
            this.tbInputVolt.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbInputVolt.Location = new System.Drawing.Point(358, 210);
            this.tbInputVolt.Name = "tbInputVolt";
            this.tbInputVolt.Size = new System.Drawing.Size(77, 22);
            this.tbInputVolt.TabIndex = 26;
            this.tbInputVolt.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(61, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Do[1]";
            // 
            // tbDO1
            // 
            this.tbDO1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDO1.Location = new System.Drawing.Point(143, 58);
            this.tbDO1.Name = "tbDO1";
            this.tbDO1.Size = new System.Drawing.Size(77, 22);
            this.tbDO1.TabIndex = 24;
            this.tbDO1.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(276, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "PM Hz";
            // 
            // tbPMFreq
            // 
            this.tbPMFreq.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPMFreq.Location = new System.Drawing.Point(358, 182);
            this.tbPMFreq.Name = "tbPMFreq";
            this.tbPMFreq.Size = new System.Drawing.Size(77, 22);
            this.tbPMFreq.TabIndex = 22;
            this.tbPMFreq.Text = "60";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(276, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "PM Current";
            // 
            // tbPMCurrent
            // 
            this.tbPMCurrent.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPMCurrent.Location = new System.Drawing.Point(358, 151);
            this.tbPMCurrent.Name = "tbPMCurrent";
            this.tbPMCurrent.Size = new System.Drawing.Size(77, 22);
            this.tbPMCurrent.TabIndex = 20;
            this.tbPMCurrent.Text = "50";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(276, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "PM Volt";
            // 
            // tbPMVolt
            // 
            this.tbPMVolt.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPMVolt.Location = new System.Drawing.Point(358, 120);
            this.tbPMVolt.Name = "tbPMVolt";
            this.tbPMVolt.Size = new System.Drawing.Size(77, 22);
            this.tbPMVolt.TabIndex = 18;
            this.tbPMVolt.Text = "220";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(276, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "PM Cycle";
            // 
            // tbPMCycle
            // 
            this.tbPMCycle.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPMCycle.Location = new System.Drawing.Point(358, 89);
            this.tbPMCycle.Name = "tbPMCycle";
            this.tbPMCycle.Size = new System.Drawing.Size(77, 22);
            this.tbPMCycle.TabIndex = 16;
            this.tbPMCycle.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(276, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "PS Cycle";
            // 
            // tbPSCycle
            // 
            this.tbPSCycle.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPSCycle.Location = new System.Drawing.Point(358, 23);
            this.tbPSCycle.Name = "tbPSCycle";
            this.tbPSCycle.Size = new System.Drawing.Size(77, 22);
            this.tbPSCycle.TabIndex = 12;
            this.tbPSCycle.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(61, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "DPS Cycle";
            // 
            // tbDPSCycle
            // 
            this.tbDPSCycle.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDPSCycle.Location = new System.Drawing.Point(143, 182);
            this.tbDPSCycle.Name = "tbDPSCycle";
            this.tbDPSCycle.Size = new System.Drawing.Size(77, 22);
            this.tbDPSCycle.TabIndex = 8;
            this.tbDPSCycle.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(61, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "DI Cycle";
            // 
            // tbDICycle
            // 
            this.tbDICycle.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDICycle.Location = new System.Drawing.Point(143, 151);
            this.tbDICycle.Name = "tbDICycle";
            this.tbDICycle.Size = new System.Drawing.Size(77, 22);
            this.tbDICycle.TabIndex = 6;
            this.tbDICycle.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(61, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "AI Cycle";
            // 
            // tbAICycle
            // 
            this.tbAICycle.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAICycle.Location = new System.Drawing.Point(143, 120);
            this.tbAICycle.Name = "tbAICycle";
            this.tbAICycle.Size = new System.Drawing.Size(77, 22);
            this.tbAICycle.TabIndex = 4;
            this.tbAICycle.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(61, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "RTD Cycle";
            // 
            // tbRTDCycle
            // 
            this.tbRTDCycle.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRTDCycle.Location = new System.Drawing.Point(143, 89);
            this.tbRTDCycle.Name = "tbRTDCycle";
            this.tbRTDCycle.Size = new System.Drawing.Size(77, 22);
            this.tbRTDCycle.TabIndex = 2;
            this.tbRTDCycle.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Do[0]";
            // 
            // tbDO0
            // 
            this.tbDO0.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDO0.Location = new System.Drawing.Point(143, 27);
            this.tbDO0.Name = "tbDO0";
            this.tbDO0.Size = new System.Drawing.Size(77, 22);
            this.tbDO0.TabIndex = 0;
            this.tbDO0.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(575, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 22);
            this.button3.TabIndex = 53;
            this.button3.Text = "Re Conv.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(575, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 22);
            this.button5.TabIndex = 55;
            this.button5.Text = "Status 0x1E";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 52;
            this.button2.Text = "Data 0x1A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 51;
            this.button1.Text = "Done 0x18";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSetConfig
            // 
            this.btnSetConfig.Location = new System.Drawing.Point(12, 137);
            this.btnSetConfig.Name = "btnSetConfig";
            this.btnSetConfig.Size = new System.Drawing.Size(90, 44);
            this.btnSetConfig.TabIndex = 42;
            this.btnSetConfig.Text = "설정";
            this.btnSetConfig.UseVisualStyleBackColor = true;
            this.btnSetConfig.Click += new System.EventHandler(this.btnSetConfig_Click);
            // 
            // lbBoardTime
            // 
            this.lbBoardTime.AutoSize = true;
            this.lbBoardTime.Location = new System.Drawing.Point(114, 64);
            this.lbBoardTime.Name = "lbBoardTime";
            this.lbBoardTime.Size = new System.Drawing.Size(153, 14);
            this.lbBoardTime.TabIndex = 43;
            this.lbBoardTime.Text = "2020-01-01 00:00:00 V1.0";
            // 
            // btnViewStatusValue
            // 
            this.btnViewStatusValue.Location = new System.Drawing.Point(114, 137);
            this.btnViewStatusValue.Name = "btnViewStatusValue";
            this.btnViewStatusValue.Size = new System.Drawing.Size(90, 44);
            this.btnViewStatusValue.TabIndex = 44;
            this.btnViewStatusValue.Text = "상태 정보";
            this.btnViewStatusValue.UseVisualStyleBackColor = true;
            this.btnViewStatusValue.Click += new System.EventHandler(this.btnViewStatusValue_Click);
            // 
            // timer1s
            // 
            this.timer1s.Enabled = true;
            this.timer1s.Interval = 1000;
            this.timer1s.Tick += new System.EventHandler(this.timer_1s_interrupt);
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(220, 242);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(44, 44);
            this.btnTest1.TabIndex = 47;
            this.btnTest1.Text = "TEST 0xD1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.BtnTest1_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(265, 242);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(44, 44);
            this.btnTest2.TabIndex = 48;
            this.btnTest2.Text = "TEST 0xD2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.BtnTest2_Click);
            // 
            // tbSPIWriteReg0
            // 
            this.tbSPIWriteReg0.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIWriteReg0.Location = new System.Drawing.Point(302, 13);
            this.tbSPIWriteReg0.Name = "tbSPIWriteReg0";
            this.tbSPIWriteReg0.Size = new System.Drawing.Size(39, 22);
            this.tbSPIWriteReg0.TabIndex = 26;
            this.tbSPIWriteReg0.Text = "00";
            // 
            // tbSPIWriteData0
            // 
            this.tbSPIWriteData0.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIWriteData0.Location = new System.Drawing.Point(353, 13);
            this.tbSPIWriteData0.Name = "tbSPIWriteData0";
            this.tbSPIWriteData0.Size = new System.Drawing.Size(39, 22);
            this.tbSPIWriteData0.TabIndex = 27;
            this.tbSPIWriteData0.Text = "C3";
            // 
            // btnSPIWrite0
            // 
            this.btnSPIWrite0.Location = new System.Drawing.Point(408, 13);
            this.btnSPIWrite0.Name = "btnSPIWrite0";
            this.btnSPIWrite0.Size = new System.Drawing.Size(50, 22);
            this.btnSPIWrite0.TabIndex = 48;
            this.btnSPIWrite0.Text = "Write";
            this.btnSPIWrite0.UseVisualStyleBackColor = true;
            this.btnSPIWrite0.Click += new System.EventHandler(this.btnSPIWrite_Clicked);
            // 
            // btnSPIRead0
            // 
            this.btnSPIRead0.Location = new System.Drawing.Point(519, 42);
            this.btnSPIRead0.Name = "btnSPIRead0";
            this.btnSPIRead0.Size = new System.Drawing.Size(50, 22);
            this.btnSPIRead0.TabIndex = 50;
            this.btnSPIRead0.Text = "Read";
            this.btnSPIRead0.UseVisualStyleBackColor = true;
            this.btnSPIRead0.Click += new System.EventHandler(this.btnSPIRead_Clicked);
            // 
            // tbSPIReadReg0
            // 
            this.tbSPIReadReg0.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIReadReg0.Location = new System.Drawing.Point(474, 42);
            this.tbSPIReadReg0.Name = "tbSPIReadReg0";
            this.tbSPIReadReg0.Size = new System.Drawing.Size(39, 22);
            this.tbSPIReadReg0.TabIndex = 49;
            this.tbSPIReadReg0.Text = "18";
            // 
            // panel_ICSET
            // 
            this.panel_ICSET.Controls.Add(this.btnRegRead8);
            this.panel_ICSET.Controls.Add(this.btnRegWrite8);
            this.panel_ICSET.Controls.Add(this.btnRegRead7);
            this.panel_ICSET.Controls.Add(this.button3);
            this.panel_ICSET.Controls.Add(this.btnRegWrite7);
            this.panel_ICSET.Controls.Add(this.btnRegRead6);
            this.panel_ICSET.Controls.Add(this.btnRegWrite6);
            this.panel_ICSET.Controls.Add(this.btnRegRead5);
            this.panel_ICSET.Controls.Add(this.btnRegWrite5);
            this.panel_ICSET.Controls.Add(this.btnRegRead4);
            this.panel_ICSET.Controls.Add(this.btnRegWrite4);
            this.panel_ICSET.Controls.Add(this.btnRegRead3);
            this.panel_ICSET.Controls.Add(this.btnRegWrite3);
            this.panel_ICSET.Controls.Add(this.btnRegRead2);
            this.panel_ICSET.Controls.Add(this.btnRegWrite2);
            this.panel_ICSET.Controls.Add(this.btnRegRead1);
            this.panel_ICSET.Controls.Add(this.btnRegWrite1);
            this.panel_ICSET.Controls.Add(this.label29);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData8);
            this.panel_ICSET.Controls.Add(this.label30);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData7);
            this.panel_ICSET.Controls.Add(this.label27);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData6);
            this.panel_ICSET.Controls.Add(this.label28);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData5);
            this.panel_ICSET.Controls.Add(this.btnRegRead0);
            this.panel_ICSET.Controls.Add(this.btnRegWrite0);
            this.panel_ICSET.Controls.Add(this.button5);
            this.panel_ICSET.Controls.Add(this.button2);
            this.panel_ICSET.Controls.Add(this.button1);
            this.panel_ICSET.Controls.Add(this.btnSPIWrite3);
            this.panel_ICSET.Controls.Add(this.tbSPIWriteData3);
            this.panel_ICSET.Controls.Add(this.tbSPIWriteReg3);
            this.panel_ICSET.Controls.Add(this.btnSPIRead2);
            this.panel_ICSET.Controls.Add(this.tbSPIReadReg2);
            this.panel_ICSET.Controls.Add(this.btnSPIWrite2);
            this.panel_ICSET.Controls.Add(this.tbSPIWriteData2);
            this.panel_ICSET.Controls.Add(this.tbSPIWriteReg2);
            this.panel_ICSET.Controls.Add(this.btnSPIRead1);
            this.panel_ICSET.Controls.Add(this.tbSPIReadReg1);
            this.panel_ICSET.Controls.Add(this.btnSPIWrite1);
            this.panel_ICSET.Controls.Add(this.tbSPIWriteData1);
            this.panel_ICSET.Controls.Add(this.tbSPIWriteReg1);
            this.panel_ICSET.Controls.Add(this.label26);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData1);
            this.panel_ICSET.Controls.Add(this.btnSPIRead0);
            this.panel_ICSET.Controls.Add(this.tbSPIReadReg0);
            this.panel_ICSET.Controls.Add(this.btnSPIWrite0);
            this.panel_ICSET.Controls.Add(this.tbSPIWriteData0);
            this.panel_ICSET.Controls.Add(this.tbSPIWriteReg0);
            this.panel_ICSET.Controls.Add(this.label34);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData4);
            this.panel_ICSET.Controls.Add(this.label35);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData3);
            this.panel_ICSET.Controls.Add(this.label36);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData2);
            this.panel_ICSET.Controls.Add(this.label37);
            this.panel_ICSET.Controls.Add(this.tbWriteRegData0);
            this.panel_ICSET.Location = new System.Drawing.Point(317, 4);
            this.panel_ICSET.Name = "panel_ICSET";
            this.panel_ICSET.Size = new System.Drawing.Size(667, 296);
            this.panel_ICSET.TabIndex = 49;
            // 
            // btnRegRead8
            // 
            this.btnRegRead8.Location = new System.Drawing.Point(230, 237);
            this.btnRegRead8.Name = "btnRegRead8";
            this.btnRegRead8.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead8.TabIndex = 99;
            this.btnRegRead8.Text = "Read";
            this.btnRegRead8.UseVisualStyleBackColor = true;
            this.btnRegRead8.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite8
            // 
            this.btnRegWrite8.Location = new System.Drawing.Point(174, 237);
            this.btnRegWrite8.Name = "btnRegWrite8";
            this.btnRegWrite8.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite8.TabIndex = 98;
            this.btnRegWrite8.Text = "Write";
            this.btnRegWrite8.UseVisualStyleBackColor = true;
            this.btnRegWrite8.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // btnRegRead7
            // 
            this.btnRegRead7.Location = new System.Drawing.Point(230, 209);
            this.btnRegRead7.Name = "btnRegRead7";
            this.btnRegRead7.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead7.TabIndex = 97;
            this.btnRegRead7.Text = "Read";
            this.btnRegRead7.UseVisualStyleBackColor = true;
            this.btnRegRead7.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite7
            // 
            this.btnRegWrite7.Location = new System.Drawing.Point(174, 209);
            this.btnRegWrite7.Name = "btnRegWrite7";
            this.btnRegWrite7.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite7.TabIndex = 96;
            this.btnRegWrite7.Text = "Write";
            this.btnRegWrite7.UseVisualStyleBackColor = true;
            this.btnRegWrite7.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // btnRegRead6
            // 
            this.btnRegRead6.Location = new System.Drawing.Point(230, 181);
            this.btnRegRead6.Name = "btnRegRead6";
            this.btnRegRead6.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead6.TabIndex = 95;
            this.btnRegRead6.Text = "Read";
            this.btnRegRead6.UseVisualStyleBackColor = true;
            this.btnRegRead6.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite6
            // 
            this.btnRegWrite6.Location = new System.Drawing.Point(174, 181);
            this.btnRegWrite6.Name = "btnRegWrite6";
            this.btnRegWrite6.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite6.TabIndex = 94;
            this.btnRegWrite6.Text = "Write";
            this.btnRegWrite6.UseVisualStyleBackColor = true;
            this.btnRegWrite6.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // btnRegRead5
            // 
            this.btnRegRead5.Location = new System.Drawing.Point(230, 154);
            this.btnRegRead5.Name = "btnRegRead5";
            this.btnRegRead5.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead5.TabIndex = 93;
            this.btnRegRead5.Text = "Read";
            this.btnRegRead5.UseVisualStyleBackColor = true;
            this.btnRegRead5.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite5
            // 
            this.btnRegWrite5.Location = new System.Drawing.Point(174, 154);
            this.btnRegWrite5.Name = "btnRegWrite5";
            this.btnRegWrite5.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite5.TabIndex = 92;
            this.btnRegWrite5.Text = "Write";
            this.btnRegWrite5.UseVisualStyleBackColor = true;
            this.btnRegWrite5.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // btnRegRead4
            // 
            this.btnRegRead4.Location = new System.Drawing.Point(230, 126);
            this.btnRegRead4.Name = "btnRegRead4";
            this.btnRegRead4.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead4.TabIndex = 91;
            this.btnRegRead4.Text = "Read";
            this.btnRegRead4.UseVisualStyleBackColor = true;
            this.btnRegRead4.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite4
            // 
            this.btnRegWrite4.Location = new System.Drawing.Point(174, 126);
            this.btnRegWrite4.Name = "btnRegWrite4";
            this.btnRegWrite4.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite4.TabIndex = 90;
            this.btnRegWrite4.Text = "Write";
            this.btnRegWrite4.UseVisualStyleBackColor = true;
            this.btnRegWrite4.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // btnRegRead3
            // 
            this.btnRegRead3.Location = new System.Drawing.Point(230, 98);
            this.btnRegRead3.Name = "btnRegRead3";
            this.btnRegRead3.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead3.TabIndex = 89;
            this.btnRegRead3.Text = "Read";
            this.btnRegRead3.UseVisualStyleBackColor = true;
            this.btnRegRead3.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite3
            // 
            this.btnRegWrite3.Location = new System.Drawing.Point(174, 98);
            this.btnRegWrite3.Name = "btnRegWrite3";
            this.btnRegWrite3.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite3.TabIndex = 88;
            this.btnRegWrite3.Text = "Write";
            this.btnRegWrite3.UseVisualStyleBackColor = true;
            this.btnRegWrite3.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // btnRegRead2
            // 
            this.btnRegRead2.Location = new System.Drawing.Point(230, 70);
            this.btnRegRead2.Name = "btnRegRead2";
            this.btnRegRead2.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead2.TabIndex = 87;
            this.btnRegRead2.Text = "Read";
            this.btnRegRead2.UseVisualStyleBackColor = true;
            this.btnRegRead2.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite2
            // 
            this.btnRegWrite2.Location = new System.Drawing.Point(174, 70);
            this.btnRegWrite2.Name = "btnRegWrite2";
            this.btnRegWrite2.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite2.TabIndex = 86;
            this.btnRegWrite2.Text = "Write";
            this.btnRegWrite2.UseVisualStyleBackColor = true;
            this.btnRegWrite2.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // btnRegRead1
            // 
            this.btnRegRead1.Location = new System.Drawing.Point(230, 43);
            this.btnRegRead1.Name = "btnRegRead1";
            this.btnRegRead1.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead1.TabIndex = 85;
            this.btnRegRead1.Text = "Read";
            this.btnRegRead1.UseVisualStyleBackColor = true;
            this.btnRegRead1.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite1
            // 
            this.btnRegWrite1.Location = new System.Drawing.Point(174, 43);
            this.btnRegWrite1.Name = "btnRegWrite1";
            this.btnRegWrite1.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite1.TabIndex = 84;
            this.btnRegWrite1.Text = "Write";
            this.btnRegWrite1.UseVisualStyleBackColor = true;
            this.btnRegWrite1.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label29.Location = new System.Drawing.Point(7, 241);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(113, 15);
            this.label29.TabIndex = 83;
            this.label29.Text = "CH2 Config 0x25";
            // 
            // tbWriteRegData8
            // 
            this.tbWriteRegData8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData8.Location = new System.Drawing.Point(140, 238);
            this.tbWriteRegData8.Name = "tbWriteRegData8";
            this.tbWriteRegData8.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData8.TabIndex = 82;
            this.tbWriteRegData8.Text = "70";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label30.Location = new System.Drawing.Point(7, 213);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 15);
            this.label30.TabIndex = 81;
            this.label30.Text = "CH2 Input 0x24";
            // 
            // tbWriteRegData7
            // 
            this.tbWriteRegData7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData7.Location = new System.Drawing.Point(140, 210);
            this.tbWriteRegData7.Name = "tbWriteRegData7";
            this.tbWriteRegData7.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData7.TabIndex = 80;
            this.tbWriteRegData7.Text = "17";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label27.Location = new System.Drawing.Point(7, 185);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 15);
            this.label27.TabIndex = 79;
            this.label27.Text = "CH1 Config 0x23";
            // 
            // tbWriteRegData6
            // 
            this.tbWriteRegData6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData6.Location = new System.Drawing.Point(140, 182);
            this.tbWriteRegData6.Name = "tbWriteRegData6";
            this.tbWriteRegData6.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData6.TabIndex = 78;
            this.tbWriteRegData6.Text = "70";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.Location = new System.Drawing.Point(7, 157);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 15);
            this.label28.TabIndex = 77;
            this.label28.Text = "CH1 Input 0x22";
            // 
            // tbWriteRegData5
            // 
            this.tbWriteRegData5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData5.Location = new System.Drawing.Point(140, 154);
            this.tbWriteRegData5.Name = "tbWriteRegData5";
            this.tbWriteRegData5.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData5.TabIndex = 76;
            this.tbWriteRegData5.Text = "08";
            // 
            // btnRegRead0
            // 
            this.btnRegRead0.Location = new System.Drawing.Point(230, 15);
            this.btnRegRead0.Name = "btnRegRead0";
            this.btnRegRead0.Size = new System.Drawing.Size(50, 22);
            this.btnRegRead0.TabIndex = 75;
            this.btnRegRead0.Text = "Read";
            this.btnRegRead0.UseVisualStyleBackColor = true;
            this.btnRegRead0.Click += new System.EventHandler(this.btnRegRead_Clicked);
            // 
            // btnRegWrite0
            // 
            this.btnRegWrite0.Location = new System.Drawing.Point(174, 15);
            this.btnRegWrite0.Name = "btnRegWrite0";
            this.btnRegWrite0.Size = new System.Drawing.Size(50, 22);
            this.btnRegWrite0.TabIndex = 74;
            this.btnRegWrite0.Text = "Write";
            this.btnRegWrite0.UseVisualStyleBackColor = true;
            this.btnRegWrite0.Click += new System.EventHandler(this.btnRegWrite_Clicked);
            // 
            // btnSPIWrite3
            // 
            this.btnSPIWrite3.Location = new System.Drawing.Point(408, 97);
            this.btnSPIWrite3.Name = "btnSPIWrite3";
            this.btnSPIWrite3.Size = new System.Drawing.Size(50, 22);
            this.btnSPIWrite3.TabIndex = 63;
            this.btnSPIWrite3.Text = "Write";
            this.btnSPIWrite3.UseVisualStyleBackColor = true;
            this.btnSPIWrite3.Click += new System.EventHandler(this.btnSPIWrite_Clicked);
            // 
            // tbSPIWriteData3
            // 
            this.tbSPIWriteData3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIWriteData3.Location = new System.Drawing.Point(353, 97);
            this.tbSPIWriteData3.Name = "tbSPIWriteData3";
            this.tbSPIWriteData3.Size = new System.Drawing.Size(39, 22);
            this.tbSPIWriteData3.TabIndex = 62;
            this.tbSPIWriteData3.Text = "00";
            // 
            // tbSPIWriteReg3
            // 
            this.tbSPIWriteReg3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIWriteReg3.Location = new System.Drawing.Point(302, 97);
            this.tbSPIWriteReg3.Name = "tbSPIWriteReg3";
            this.tbSPIWriteReg3.Size = new System.Drawing.Size(39, 22);
            this.tbSPIWriteReg3.TabIndex = 61;
            this.tbSPIWriteReg3.Text = "01";
            // 
            // btnSPIRead2
            // 
            this.btnSPIRead2.Location = new System.Drawing.Point(519, 98);
            this.btnSPIRead2.Name = "btnSPIRead2";
            this.btnSPIRead2.Size = new System.Drawing.Size(50, 22);
            this.btnSPIRead2.TabIndex = 60;
            this.btnSPIRead2.Text = "Read";
            this.btnSPIRead2.UseVisualStyleBackColor = true;
            this.btnSPIRead2.Click += new System.EventHandler(this.btnSPIRead_Clicked);
            // 
            // tbSPIReadReg2
            // 
            this.tbSPIReadReg2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIReadReg2.Location = new System.Drawing.Point(474, 98);
            this.tbSPIReadReg2.Name = "tbSPIReadReg2";
            this.tbSPIReadReg2.Size = new System.Drawing.Size(39, 22);
            this.tbSPIReadReg2.TabIndex = 59;
            this.tbSPIReadReg2.Text = "1E";
            // 
            // btnSPIWrite2
            // 
            this.btnSPIWrite2.Location = new System.Drawing.Point(408, 69);
            this.btnSPIWrite2.Name = "btnSPIWrite2";
            this.btnSPIWrite2.Size = new System.Drawing.Size(50, 22);
            this.btnSPIWrite2.TabIndex = 58;
            this.btnSPIWrite2.Text = "Write";
            this.btnSPIWrite2.UseVisualStyleBackColor = true;
            this.btnSPIWrite2.Click += new System.EventHandler(this.btnSPIWrite_Clicked);
            // 
            // tbSPIWriteData2
            // 
            this.tbSPIWriteData2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIWriteData2.Location = new System.Drawing.Point(353, 69);
            this.tbSPIWriteData2.Name = "tbSPIWriteData2";
            this.tbSPIWriteData2.Size = new System.Drawing.Size(39, 22);
            this.tbSPIWriteData2.TabIndex = 57;
            this.tbSPIWriteData2.Text = "A3";
            // 
            // tbSPIWriteReg2
            // 
            this.tbSPIWriteReg2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIWriteReg2.Location = new System.Drawing.Point(302, 69);
            this.tbSPIWriteReg2.Name = "tbSPIWriteReg2";
            this.tbSPIWriteReg2.Size = new System.Drawing.Size(39, 22);
            this.tbSPIWriteReg2.TabIndex = 56;
            this.tbSPIWriteReg2.Text = "11";
            // 
            // btnSPIRead1
            // 
            this.btnSPIRead1.Location = new System.Drawing.Point(519, 70);
            this.btnSPIRead1.Name = "btnSPIRead1";
            this.btnSPIRead1.Size = new System.Drawing.Size(50, 22);
            this.btnSPIRead1.TabIndex = 55;
            this.btnSPIRead1.Text = "Read";
            this.btnSPIRead1.UseVisualStyleBackColor = true;
            this.btnSPIRead1.Click += new System.EventHandler(this.btnSPIRead_Clicked);
            // 
            // tbSPIReadReg1
            // 
            this.tbSPIReadReg1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIReadReg1.Location = new System.Drawing.Point(474, 70);
            this.tbSPIReadReg1.Name = "tbSPIReadReg1";
            this.tbSPIReadReg1.Size = new System.Drawing.Size(39, 22);
            this.tbSPIReadReg1.TabIndex = 54;
            this.tbSPIReadReg1.Text = "1A";
            // 
            // btnSPIWrite1
            // 
            this.btnSPIWrite1.Location = new System.Drawing.Point(408, 41);
            this.btnSPIWrite1.Name = "btnSPIWrite1";
            this.btnSPIWrite1.Size = new System.Drawing.Size(50, 22);
            this.btnSPIWrite1.TabIndex = 53;
            this.btnSPIWrite1.Text = "Write";
            this.btnSPIWrite1.UseVisualStyleBackColor = true;
            this.btnSPIWrite1.Click += new System.EventHandler(this.btnSPIWrite_Clicked);
            // 
            // tbSPIWriteData1
            // 
            this.tbSPIWriteData1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIWriteData1.Location = new System.Drawing.Point(353, 41);
            this.tbSPIWriteData1.Name = "tbSPIWriteData1";
            this.tbSPIWriteData1.Size = new System.Drawing.Size(39, 22);
            this.tbSPIWriteData1.TabIndex = 52;
            this.tbSPIWriteData1.Text = "02";
            // 
            // tbSPIWriteReg1
            // 
            this.tbSPIWriteReg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSPIWriteReg1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSPIWriteReg1.Location = new System.Drawing.Point(302, 41);
            this.tbSPIWriteReg1.Name = "tbSPIWriteReg1";
            this.tbSPIWriteReg1.Size = new System.Drawing.Size(39, 22);
            this.tbSPIWriteReg1.TabIndex = 51;
            this.tbSPIWriteReg1.Text = "10";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.Location = new System.Drawing.Point(7, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 15);
            this.label26.TabIndex = 25;
            this.label26.Text = "Cal Control 0x17";
            // 
            // tbWriteRegData1
            // 
            this.tbWriteRegData1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData1.Location = new System.Drawing.Point(140, 42);
            this.tbWriteRegData1.Name = "tbWriteRegData1";
            this.tbWriteRegData1.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData1.TabIndex = 24;
            this.tbWriteRegData1.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label34.Location = new System.Drawing.Point(7, 129);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(113, 15);
            this.label34.TabIndex = 7;
            this.label34.Text = "CH0 Config 0x21";
            // 
            // tbWriteRegData4
            // 
            this.tbWriteRegData4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData4.Location = new System.Drawing.Point(140, 126);
            this.tbWriteRegData4.Name = "tbWriteRegData4";
            this.tbWriteRegData4.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData4.TabIndex = 6;
            this.tbWriteRegData4.Text = "70";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label35.Location = new System.Drawing.Point(7, 101);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(104, 15);
            this.label35.TabIndex = 5;
            this.label35.Text = "CH0 Input 0x20";
            // 
            // tbWriteRegData3
            // 
            this.tbWriteRegData3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData3.Location = new System.Drawing.Point(140, 98);
            this.tbWriteRegData3.Name = "tbWriteRegData3";
            this.tbWriteRegData3.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData3.TabIndex = 4;
            this.tbWriteRegData3.Text = "41";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label36.Location = new System.Drawing.Point(7, 73);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(131, 15);
            this.label36.TabIndex = 3;
            this.label36.Text = "CH Scan Mode 0x1F";
            // 
            // tbWriteRegData2
            // 
            this.tbWriteRegData2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData2.Location = new System.Drawing.Point(140, 70);
            this.tbWriteRegData2.Name = "tbWriteRegData2";
            this.tbWriteRegData2.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData2.TabIndex = 2;
            this.tbWriteRegData2.Text = "10";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label37.Location = new System.Drawing.Point(7, 17);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(121, 15);
            this.label37.TabIndex = 1;
            this.label37.Text = "ADC_AUXCN 0x12";
            // 
            // tbWriteRegData0
            // 
            this.tbWriteRegData0.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWriteRegData0.Location = new System.Drawing.Point(140, 14);
            this.tbWriteRegData0.Name = "tbWriteRegData0";
            this.tbWriteRegData0.Size = new System.Drawing.Size(28, 22);
            this.tbWriteRegData0.TabIndex = 0;
            this.tbWriteRegData0.Text = "0A";
            // 
            // btnSY7D609_WriteReg1
            // 
            this.btnSY7D609_WriteReg1.Location = new System.Drawing.Point(351, 186);
            this.btnSY7D609_WriteReg1.Name = "btnSY7D609_WriteReg1";
            this.btnSY7D609_WriteReg1.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_WriteReg1.TabIndex = 128;
            this.btnSY7D609_WriteReg1.Text = "WR";
            this.btnSY7D609_WriteReg1.UseVisualStyleBackColor = true;
            this.btnSY7D609_WriteReg1.Click += new System.EventHandler(this.btnSY7D609_WriteReg_Clicked);
            // 
            // tbSY7D609_WR1
            // 
            this.tbSY7D609_WR1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_WR1.Location = new System.Drawing.Point(263, 186);
            this.tbSY7D609_WR1.Name = "tbSY7D609_WR1";
            this.tbSY7D609_WR1.Size = new System.Drawing.Size(82, 22);
            this.tbSY7D609_WR1.TabIndex = 127;
            this.tbSY7D609_WR1.Text = "47200000";
            // 
            // btnSY7D609_WriteReg2
            // 
            this.btnSY7D609_WriteReg2.Location = new System.Drawing.Point(351, 212);
            this.btnSY7D609_WriteReg2.Name = "btnSY7D609_WriteReg2";
            this.btnSY7D609_WriteReg2.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_WriteReg2.TabIndex = 126;
            this.btnSY7D609_WriteReg2.Text = "WR";
            this.btnSY7D609_WriteReg2.UseVisualStyleBackColor = true;
            this.btnSY7D609_WriteReg2.Click += new System.EventHandler(this.btnSY7D609_WriteReg_Clicked);
            // 
            // tbSY7D609_WR2
            // 
            this.tbSY7D609_WR2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_WR2.Location = new System.Drawing.Point(263, 212);
            this.tbSY7D609_WR2.Name = "tbSY7D609_WR2";
            this.tbSY7D609_WR2.Size = new System.Drawing.Size(82, 22);
            this.tbSY7D609_WR2.TabIndex = 125;
            this.tbSY7D609_WR2.Text = "48200000";
            // 
            // btnSY7D609_WriteReg3
            // 
            this.btnSY7D609_WriteReg3.Location = new System.Drawing.Point(351, 238);
            this.btnSY7D609_WriteReg3.Name = "btnSY7D609_WriteReg3";
            this.btnSY7D609_WriteReg3.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_WriteReg3.TabIndex = 124;
            this.btnSY7D609_WriteReg3.Text = "WR";
            this.btnSY7D609_WriteReg3.UseVisualStyleBackColor = true;
            this.btnSY7D609_WriteReg3.Click += new System.EventHandler(this.btnSY7D609_WriteReg_Clicked);
            // 
            // tbSY7D609_WR3
            // 
            this.tbSY7D609_WR3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_WR3.Location = new System.Drawing.Point(263, 238);
            this.tbSY7D609_WR3.Name = "tbSY7D609_WR3";
            this.tbSY7D609_WR3.Size = new System.Drawing.Size(82, 22);
            this.tbSY7D609_WR3.TabIndex = 123;
            this.tbSY7D609_WR3.Text = "01020304";
            // 
            // btnSY7D609_ReadReg5
            // 
            this.btnSY7D609_ReadReg5.Location = new System.Drawing.Point(195, 186);
            this.btnSY7D609_ReadReg5.Name = "btnSY7D609_ReadReg5";
            this.btnSY7D609_ReadReg5.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_ReadReg5.TabIndex = 122;
            this.btnSY7D609_ReadReg5.Text = "READ";
            this.btnSY7D609_ReadReg5.UseVisualStyleBackColor = true;
            this.btnSY7D609_ReadReg5.Click += new System.EventHandler(this.tbSY7D609_ReadReg_Clicked);
            // 
            // tbSY7D609_R5
            // 
            this.tbSY7D609_R5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_R5.Location = new System.Drawing.Point(150, 186);
            this.tbSY7D609_R5.Name = "tbSY7D609_R5";
            this.tbSY7D609_R5.Size = new System.Drawing.Size(39, 22);
            this.tbSY7D609_R5.TabIndex = 121;
            this.tbSY7D609_R5.Text = "47";
            // 
            // btnSY7D609_ReadReg6
            // 
            this.btnSY7D609_ReadReg6.Location = new System.Drawing.Point(195, 212);
            this.btnSY7D609_ReadReg6.Name = "btnSY7D609_ReadReg6";
            this.btnSY7D609_ReadReg6.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_ReadReg6.TabIndex = 120;
            this.btnSY7D609_ReadReg6.Text = "READ";
            this.btnSY7D609_ReadReg6.UseVisualStyleBackColor = true;
            this.btnSY7D609_ReadReg6.Click += new System.EventHandler(this.tbSY7D609_ReadReg_Clicked);
            // 
            // tbSY7D609_R6
            // 
            this.tbSY7D609_R6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_R6.Location = new System.Drawing.Point(150, 212);
            this.tbSY7D609_R6.Name = "tbSY7D609_R6";
            this.tbSY7D609_R6.Size = new System.Drawing.Size(39, 22);
            this.tbSY7D609_R6.TabIndex = 119;
            this.tbSY7D609_R6.Text = "48";
            // 
            // btnSY7D609_ReadReg7
            // 
            this.btnSY7D609_ReadReg7.Location = new System.Drawing.Point(195, 238);
            this.btnSY7D609_ReadReg7.Name = "btnSY7D609_ReadReg7";
            this.btnSY7D609_ReadReg7.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_ReadReg7.TabIndex = 118;
            this.btnSY7D609_ReadReg7.Text = "READ";
            this.btnSY7D609_ReadReg7.UseVisualStyleBackColor = true;
            this.btnSY7D609_ReadReg7.Click += new System.EventHandler(this.tbSY7D609_ReadReg_Clicked);
            // 
            // tbSY7D609_R7
            // 
            this.tbSY7D609_R7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_R7.Location = new System.Drawing.Point(150, 238);
            this.tbSY7D609_R7.Name = "tbSY7D609_R7";
            this.tbSY7D609_R7.Size = new System.Drawing.Size(39, 22);
            this.tbSY7D609_R7.TabIndex = 117;
            this.tbSY7D609_R7.Text = "4F";
            // 
            // btnSY7D609_ReadReg8
            // 
            this.btnSY7D609_ReadReg8.Location = new System.Drawing.Point(195, 264);
            this.btnSY7D609_ReadReg8.Name = "btnSY7D609_ReadReg8";
            this.btnSY7D609_ReadReg8.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_ReadReg8.TabIndex = 116;
            this.btnSY7D609_ReadReg8.Text = "READ";
            this.btnSY7D609_ReadReg8.UseVisualStyleBackColor = true;
            this.btnSY7D609_ReadReg8.Click += new System.EventHandler(this.tbSY7D609_ReadReg_Clicked);
            // 
            // tbSY7D609_R8
            // 
            this.tbSY7D609_R8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_R8.Location = new System.Drawing.Point(150, 264);
            this.tbSY7D609_R8.Name = "tbSY7D609_R8";
            this.tbSY7D609_R8.Size = new System.Drawing.Size(39, 22);
            this.tbSY7D609_R8.TabIndex = 115;
            this.tbSY7D609_R8.Text = "50";
            // 
            // btnSY7D609_ReadReg1
            // 
            this.btnSY7D609_ReadReg1.Location = new System.Drawing.Point(94, 186);
            this.btnSY7D609_ReadReg1.Name = "btnSY7D609_ReadReg1";
            this.btnSY7D609_ReadReg1.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_ReadReg1.TabIndex = 114;
            this.btnSY7D609_ReadReg1.Text = "READ";
            this.btnSY7D609_ReadReg1.UseVisualStyleBackColor = true;
            this.btnSY7D609_ReadReg1.Click += new System.EventHandler(this.tbSY7D609_ReadReg_Clicked);
            // 
            // tbSY7D609_R1
            // 
            this.tbSY7D609_R1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_R1.Location = new System.Drawing.Point(49, 186);
            this.tbSY7D609_R1.Name = "tbSY7D609_R1";
            this.tbSY7D609_R1.Size = new System.Drawing.Size(39, 22);
            this.tbSY7D609_R1.TabIndex = 113;
            this.tbSY7D609_R1.Text = "F";
            // 
            // btnSY7D609_ReadReg2
            // 
            this.btnSY7D609_ReadReg2.Location = new System.Drawing.Point(94, 212);
            this.btnSY7D609_ReadReg2.Name = "btnSY7D609_ReadReg2";
            this.btnSY7D609_ReadReg2.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_ReadReg2.TabIndex = 112;
            this.btnSY7D609_ReadReg2.Text = "READ";
            this.btnSY7D609_ReadReg2.UseVisualStyleBackColor = true;
            this.btnSY7D609_ReadReg2.Click += new System.EventHandler(this.tbSY7D609_ReadReg_Clicked);
            // 
            // tbSY7D609_R2
            // 
            this.tbSY7D609_R2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_R2.Location = new System.Drawing.Point(49, 212);
            this.tbSY7D609_R2.Name = "tbSY7D609_R2";
            this.tbSY7D609_R2.Size = new System.Drawing.Size(39, 22);
            this.tbSY7D609_R2.TabIndex = 111;
            this.tbSY7D609_R2.Text = "10";
            // 
            // btnSY7D609_ReadReg3
            // 
            this.btnSY7D609_ReadReg3.Location = new System.Drawing.Point(94, 238);
            this.btnSY7D609_ReadReg3.Name = "btnSY7D609_ReadReg3";
            this.btnSY7D609_ReadReg3.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_ReadReg3.TabIndex = 110;
            this.btnSY7D609_ReadReg3.Text = "READ";
            this.btnSY7D609_ReadReg3.UseVisualStyleBackColor = true;
            this.btnSY7D609_ReadReg3.Click += new System.EventHandler(this.tbSY7D609_ReadReg_Clicked);
            // 
            // tbSY7D609_R3
            // 
            this.tbSY7D609_R3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_R3.Location = new System.Drawing.Point(49, 238);
            this.tbSY7D609_R3.Name = "tbSY7D609_R3";
            this.tbSY7D609_R3.Size = new System.Drawing.Size(39, 22);
            this.tbSY7D609_R3.TabIndex = 109;
            this.tbSY7D609_R3.Text = "11";
            // 
            // btnSY7D609_WriteReg4
            // 
            this.btnSY7D609_WriteReg4.Location = new System.Drawing.Point(352, 264);
            this.btnSY7D609_WriteReg4.Name = "btnSY7D609_WriteReg4";
            this.btnSY7D609_WriteReg4.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_WriteReg4.TabIndex = 108;
            this.btnSY7D609_WriteReg4.Text = "WR";
            this.btnSY7D609_WriteReg4.UseVisualStyleBackColor = true;
            this.btnSY7D609_WriteReg4.Click += new System.EventHandler(this.btnSY7D609_WriteReg_Clicked);
            // 
            // btnSY7D609_ReadReg4
            // 
            this.btnSY7D609_ReadReg4.Location = new System.Drawing.Point(94, 264);
            this.btnSY7D609_ReadReg4.Name = "btnSY7D609_ReadReg4";
            this.btnSY7D609_ReadReg4.Size = new System.Drawing.Size(50, 22);
            this.btnSY7D609_ReadReg4.TabIndex = 107;
            this.btnSY7D609_ReadReg4.Text = "READ";
            this.btnSY7D609_ReadReg4.UseVisualStyleBackColor = true;
            this.btnSY7D609_ReadReg4.Click += new System.EventHandler(this.tbSY7D609_ReadReg_Clicked);
            // 
            // tbSY7D609_WR4
            // 
            this.tbSY7D609_WR4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_WR4.Location = new System.Drawing.Point(264, 264);
            this.tbSY7D609_WR4.Name = "tbSY7D609_WR4";
            this.tbSY7D609_WR4.Size = new System.Drawing.Size(82, 22);
            this.tbSY7D609_WR4.TabIndex = 106;
            this.tbSY7D609_WR4.Text = "01020304";
            // 
            // tbSY7D609_R4
            // 
            this.tbSY7D609_R4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSY7D609_R4.Location = new System.Drawing.Point(49, 264);
            this.tbSY7D609_R4.Name = "tbSY7D609_R4";
            this.tbSY7D609_R4.Size = new System.Drawing.Size(39, 22);
            this.tbSY7D609_R4.TabIndex = 105;
            this.tbSY7D609_R4.Text = "12";
            // 
            // timer_100ms
            // 
            this.timer_100ms.Enabled = true;
            this.timer_100ms.Tick += new System.EventHandler(this.timer_100ms_Tick);
            // 
            // btn_DO2
            // 
            this.btn_DO2.Location = new System.Drawing.Point(220, 87);
            this.btn_DO2.Name = "btn_DO2";
            this.btn_DO2.Size = new System.Drawing.Size(89, 44);
            this.btn_DO2.TabIndex = 134;
            this.btn_DO2.Text = "DO 2";
            this.btn_DO2.UseVisualStyleBackColor = true;
            this.btn_DO2.Click += new System.EventHandler(this.btn_DO_Click);
            // 
            // btn_DO1
            // 
            this.btn_DO1.Location = new System.Drawing.Point(114, 87);
            this.btn_DO1.Name = "btn_DO1";
            this.btn_DO1.Size = new System.Drawing.Size(90, 44);
            this.btn_DO1.TabIndex = 133;
            this.btn_DO1.Text = "DO 1";
            this.btn_DO1.UseVisualStyleBackColor = true;
            this.btn_DO1.Click += new System.EventHandler(this.btn_DO_Click);
            // 
            // btnSettingSPI_IC
            // 
            this.btnSettingSPI_IC.Location = new System.Drawing.Point(12, 192);
            this.btnSettingSPI_IC.Name = "btnSettingSPI_IC";
            this.btnSettingSPI_IC.Size = new System.Drawing.Size(90, 44);
            this.btnSettingSPI_IC.TabIndex = 136;
            this.btnSettingSPI_IC.Text = "ADC IC 설정";
            this.btnSettingSPI_IC.UseVisualStyleBackColor = true;
            this.btnSettingSPI_IC.Click += new System.EventHandler(this.BtnSettingSPI_IC_Click);
            // 
            // btnSetEMP_IC
            // 
            this.btnSetEMP_IC.Location = new System.Drawing.Point(114, 192);
            this.btnSetEMP_IC.Name = "btnSetEMP_IC";
            this.btnSetEMP_IC.Size = new System.Drawing.Size(90, 44);
            this.btnSetEMP_IC.TabIndex = 137;
            this.btnSetEMP_IC.Text = "EMP IC 설정";
            this.btnSetEMP_IC.UseVisualStyleBackColor = true;
            this.btnSetEMP_IC.Click += new System.EventHandler(this.BtnSetEMP_IC_Click);
            // 
            // panel_PowerSET
            // 
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_WriteReg1);
            this.panel_PowerSET.Controls.Add(this.btnSumPowerReset);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_WR1);
            this.panel_PowerSET.Controls.Add(this.btnRequestCalWattMeter);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_WriteReg2);
            this.panel_PowerSET.Controls.Add(this.btnUpdateCalValue);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_WR2);
            this.panel_PowerSET.Controls.Add(this.btnRequestWattMeterValue);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_WriteReg3);
            this.panel_PowerSET.Controls.Add(this.label46);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_WR3);
            this.panel_PowerSET.Controls.Add(this.tbVGain);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_ReadReg5);
            this.panel_PowerSET.Controls.Add(this.label45);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_R5);
            this.panel_PowerSET.Controls.Add(this.tbIGain);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_ReadReg6);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_ReadReg1);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_R6);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_R4);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_ReadReg7);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_WR4);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_R7);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_ReadReg4);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_ReadReg8);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_WriteReg4);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_R8);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_R3);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_ReadReg3);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_R1);
            this.panel_PowerSET.Controls.Add(this.tbSY7D609_R2);
            this.panel_PowerSET.Controls.Add(this.btnSY7D609_ReadReg2);
            this.panel_PowerSET.Location = new System.Drawing.Point(1037, 0);
            this.panel_PowerSET.Name = "panel_PowerSET";
            this.panel_PowerSET.Size = new System.Drawing.Size(667, 296);
            this.panel_PowerSET.TabIndex = 77;
            // 
            // btnSumPowerReset
            // 
            this.btnSumPowerReset.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSumPowerReset.Location = new System.Drawing.Point(49, 67);
            this.btnSumPowerReset.Name = "btnSumPowerReset";
            this.btnSumPowerReset.Size = new System.Drawing.Size(90, 44);
            this.btnSumPowerReset.TabIndex = 145;
            this.btnSumPowerReset.Text = "유효전력 누적 값 초기화";
            this.btnSumPowerReset.UseVisualStyleBackColor = true;
            this.btnSumPowerReset.Click += new System.EventHandler(this.BtnSumPowerReset_Click);
            // 
            // btnRequestCalWattMeter
            // 
            this.btnRequestCalWattMeter.Location = new System.Drawing.Point(49, 17);
            this.btnRequestCalWattMeter.Name = "btnRequestCalWattMeter";
            this.btnRequestCalWattMeter.Size = new System.Drawing.Size(90, 44);
            this.btnRequestCalWattMeter.TabIndex = 138;
            this.btnRequestCalWattMeter.Text = "PM CAL";
            this.btnRequestCalWattMeter.UseVisualStyleBackColor = true;
            this.btnRequestCalWattMeter.Click += new System.EventHandler(this.btnRequestCalWattMeter_Click);
            // 
            // btnUpdateCalValue
            // 
            this.btnUpdateCalValue.Location = new System.Drawing.Point(241, 19);
            this.btnUpdateCalValue.Name = "btnUpdateCalValue";
            this.btnUpdateCalValue.Size = new System.Drawing.Size(90, 44);
            this.btnUpdateCalValue.TabIndex = 144;
            this.btnUpdateCalValue.Text = "SET CAL VALUE";
            this.btnUpdateCalValue.UseVisualStyleBackColor = true;
            this.btnUpdateCalValue.Click += new System.EventHandler(this.BtnUpdateCalValue_Click);
            // 
            // btnRequestWattMeterValue
            // 
            this.btnRequestWattMeterValue.Location = new System.Drawing.Point(145, 18);
            this.btnRequestWattMeterValue.Name = "btnRequestWattMeterValue";
            this.btnRequestWattMeterValue.Size = new System.Drawing.Size(90, 44);
            this.btnRequestWattMeterValue.TabIndex = 139;
            this.btnRequestWattMeterValue.Text = "GET CAL VALUE";
            this.btnRequestWattMeterValue.UseVisualStyleBackColor = true;
            this.btnRequestWattMeterValue.Click += new System.EventHandler(this.btnRequestWattMeterValue_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label46.Location = new System.Drawing.Point(448, 41);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(104, 13);
            this.label46.TabIndex = 143;
            this.label46.Text = "Voltage Cal Value :";
            // 
            // tbVGain
            // 
            this.tbVGain.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbVGain.Location = new System.Drawing.Point(558, 38);
            this.tbVGain.Name = "tbVGain";
            this.tbVGain.Size = new System.Drawing.Size(67, 20);
            this.tbVGain.TabIndex = 141;
            this.tbVGain.Text = "2000000";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label45.Location = new System.Drawing.Point(449, 19);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(103, 13);
            this.label45.TabIndex = 140;
            this.label45.Text = "Current Cal Value :";
            // 
            // tbIGain
            // 
            this.tbIGain.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbIGain.Location = new System.Drawing.Point(558, 16);
            this.tbIGain.Name = "tbIGain";
            this.tbIGain.Size = new System.Drawing.Size(67, 20);
            this.tbIGain.TabIndex = 142;
            this.tbIGain.Text = "2000000";
            // 
            // panel_status
            // 
            this.panel_status.Controls.Add(this.label62);
            this.panel_status.Controls.Add(this.label63);
            this.panel_status.Controls.Add(this.label64);
            this.panel_status.Controls.Add(this.tbAI7);
            this.panel_status.Controls.Add(this.label65);
            this.panel_status.Controls.Add(this.tbAI6);
            this.panel_status.Controls.Add(this.label58);
            this.panel_status.Controls.Add(this.label59);
            this.panel_status.Controls.Add(this.label60);
            this.panel_status.Controls.Add(this.tbAI5);
            this.panel_status.Controls.Add(this.label61);
            this.panel_status.Controls.Add(this.tbAI4);
            this.panel_status.Controls.Add(this.label54);
            this.panel_status.Controls.Add(this.label55);
            this.panel_status.Controls.Add(this.label56);
            this.panel_status.Controls.Add(this.tbAI3);
            this.panel_status.Controls.Add(this.label57);
            this.panel_status.Controls.Add(this.tbAI2);
            this.panel_status.Controls.Add(this.btnReadDPTemp);
            this.panel_status.Controls.Add(this.btnStatusRequestCont);
            this.panel_status.Controls.Add(this.label49);
            this.panel_status.Controls.Add(this.label48);
            this.panel_status.Controls.Add(this.label47);
            this.panel_status.Controls.Add(this.btnSumPowerMeter);
            this.panel_status.Controls.Add(this.btnPowerMeter);
            this.panel_status.Controls.Add(this.label44);
            this.panel_status.Controls.Add(this.label43);
            this.panel_status.Controls.Add(this.label31);
            this.panel_status.Controls.Add(this.btnReadPSTemp);
            this.panel_status.Controls.Add(this.label42);
            this.panel_status.Controls.Add(this.tbStatusPMCos);
            this.panel_status.Controls.Add(this.label41);
            this.panel_status.Controls.Add(this.label40);
            this.panel_status.Controls.Add(this.label39);
            this.panel_status.Controls.Add(this.label33);
            this.panel_status.Controls.Add(this.tbAI1);
            this.panel_status.Controls.Add(this.label38);
            this.panel_status.Controls.Add(this.tbAI0);
            this.panel_status.Controls.Add(this.label32);
            this.panel_status.Controls.Add(this.tbPS);
            this.panel_status.Controls.Add(this.label25);
            this.panel_status.Controls.Add(this.tbStatusDP);
            this.panel_status.Controls.Add(this.label12);
            this.panel_status.Controls.Add(this.tbStatusPMEnergy);
            this.panel_status.Controls.Add(this.btnRequestStatus);
            this.panel_status.Controls.Add(this.label13);
            this.panel_status.Controls.Add(this.tbDO1Value);
            this.panel_status.Controls.Add(this.label14);
            this.panel_status.Controls.Add(this.tbStatusPMCurrent);
            this.panel_status.Controls.Add(this.label15);
            this.panel_status.Controls.Add(this.tbStatusPMVolts);
            this.panel_status.Controls.Add(this.label16);
            this.panel_status.Controls.Add(this.tbDI3);
            this.panel_status.Controls.Add(this.label17);
            this.panel_status.Controls.Add(this.tbDI2);
            this.panel_status.Controls.Add(this.label18);
            this.panel_status.Controls.Add(this.tbDI1);
            this.panel_status.Controls.Add(this.label19);
            this.panel_status.Controls.Add(this.tbDI0);
            this.panel_status.Controls.Add(this.label20);
            this.panel_status.Controls.Add(this.tbStatusPMApparent);
            this.panel_status.Controls.Add(this.label21);
            this.panel_status.Controls.Add(this.tbStatusPMReactive);
            this.panel_status.Controls.Add(this.label22);
            this.panel_status.Controls.Add(this.tbStatusPMActive);
            this.panel_status.Controls.Add(this.label23);
            this.panel_status.Controls.Add(this.tbRTD);
            this.panel_status.Controls.Add(this.label24);
            this.panel_status.Controls.Add(this.tbDO0Value);
            this.panel_status.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel_status.Location = new System.Drawing.Point(1037, 313);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(667, 296);
            this.panel_status.TabIndex = 138;
            // 
            // btnStatusRequestCont
            // 
            this.btnStatusRequestCont.Location = new System.Drawing.Point(257, 4);
            this.btnStatusRequestCont.Name = "btnStatusRequestCont";
            this.btnStatusRequestCont.Size = new System.Drawing.Size(62, 46);
            this.btnStatusRequestCont.TabIndex = 76;
            this.btnStatusRequestCont.Text = "1초 자동";
            this.btnStatusRequestCont.UseVisualStyleBackColor = true;
            this.btnStatusRequestCont.Click += new System.EventHandler(this.BtnStatusRequestCont_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label49.Location = new System.Drawing.Point(179, 234);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(25, 17);
            this.label49.TabIndex = 75;
            this.label49.Text = "VA";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label48.Location = new System.Drawing.Point(181, 203);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(33, 17);
            this.label48.TabIndex = 74;
            this.label48.Text = "VAR";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label47.Location = new System.Drawing.Point(179, 172);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(20, 17);
            this.label47.TabIndex = 73;
            this.label47.Text = "W";
            // 
            // btnSumPowerMeter
            // 
            this.btnSumPowerMeter.Location = new System.Drawing.Point(409, 4);
            this.btnSumPowerMeter.Name = "btnSumPowerMeter";
            this.btnSumPowerMeter.Size = new System.Drawing.Size(90, 46);
            this.btnSumPowerMeter.TabIndex = 72;
            this.btnSumPowerMeter.Text = "누적 소비량\r\n000.00W";
            this.btnSumPowerMeter.UseVisualStyleBackColor = true;
            // 
            // btnPowerMeter
            // 
            this.btnPowerMeter.Location = new System.Drawing.Point(321, 4);
            this.btnPowerMeter.Name = "btnPowerMeter";
            this.btnPowerMeter.Size = new System.Drawing.Size(80, 46);
            this.btnPowerMeter.TabIndex = 71;
            this.btnPowerMeter.Text = "현재 소비량\r\n000.00W";
            this.btnPowerMeter.UseVisualStyleBackColor = true;
            this.btnPowerMeter.Click += new System.EventHandler(this.BtnPowerMeter_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label44.Location = new System.Drawing.Point(179, 265);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(33, 17);
            this.label44.TabIndex = 70;
            this.label44.Text = "W/h";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label43.Location = new System.Drawing.Point(179, 141);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(17, 17);
            this.label43.TabIndex = 69;
            this.label43.Text = "A";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label31.Location = new System.Drawing.Point(179, 110);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(16, 17);
            this.label31.TabIndex = 68;
            this.label31.Text = "V";
            // 
            // btnReadPSTemp
            // 
            this.btnReadPSTemp.Location = new System.Drawing.Point(505, 4);
            this.btnReadPSTemp.Name = "btnReadPSTemp";
            this.btnReadPSTemp.Size = new System.Drawing.Size(70, 46);
            this.btnReadPSTemp.TabIndex = 67;
            this.btnReadPSTemp.Text = "PS Temp\r\n00.00°C";
            this.btnReadPSTemp.UseVisualStyleBackColor = true;
            this.btnReadPSTemp.Click += new System.EventHandler(this.BtnReadDPTemp_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label42.Location = new System.Drawing.Point(265, 265);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(54, 17);
            this.label42.TabIndex = 66;
            this.label42.Text = "PM Cos";
            // 
            // tbStatusPMCos
            // 
            this.tbStatusPMCos.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStatusPMCos.Location = new System.Drawing.Point(347, 262);
            this.tbStatusPMCos.Name = "tbStatusPMCos";
            this.tbStatusPMCos.Size = new System.Drawing.Size(66, 25);
            this.tbStatusPMCos.TabIndex = 65;
            this.tbStatusPMCos.Text = "1";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.Location = new System.Drawing.Point(179, 80);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(21, 17);
            this.label41.TabIndex = 64;
            this.label41.Text = "°C";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label32.Location = new System.Drawing.Point(265, 234);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(22, 17);
            this.label32.TabIndex = 57;
            this.label32.Text = "PS";
            // 
            // tbPS
            // 
            this.tbPS.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPS.Location = new System.Drawing.Point(347, 231);
            this.tbPS.Name = "tbPS";
            this.tbPS.Size = new System.Drawing.Size(66, 25);
            this.tbPS.TabIndex = 56;
            this.tbPS.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(265, 203);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(24, 17);
            this.label25.TabIndex = 55;
            this.label25.Text = "DP";
            // 
            // tbStatusDP
            // 
            this.tbStatusDP.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStatusDP.Location = new System.Drawing.Point(347, 200);
            this.tbStatusDP.Name = "tbStatusDP";
            this.tbStatusDP.Size = new System.Drawing.Size(66, 25);
            this.tbStatusDP.TabIndex = 54;
            this.tbStatusDP.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(6, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 53;
            this.label12.Text = "PM Energy";
            // 
            // tbStatusPMEnergy
            // 
            this.tbStatusPMEnergy.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStatusPMEnergy.Location = new System.Drawing.Point(96, 262);
            this.tbStatusPMEnergy.Name = "tbStatusPMEnergy";
            this.tbStatusPMEnergy.Size = new System.Drawing.Size(77, 25);
            this.tbStatusPMEnergy.TabIndex = 52;
            this.tbStatusPMEnergy.Text = "1";
            // 
            // btnRequestStatus
            // 
            this.btnRequestStatus.Location = new System.Drawing.Point(162, 4);
            this.btnRequestStatus.Name = "btnRequestStatus";
            this.btnRequestStatus.Size = new System.Drawing.Size(89, 46);
            this.btnRequestStatus.TabIndex = 51;
            this.btnRequestStatus.Text = "Read";
            this.btnRequestStatus.UseVisualStyleBackColor = true;
            this.btnRequestStatus.Click += new System.EventHandler(this.BtnRequestStatus_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Do[1]";
            // 
            // tbDO1Value
            // 
            this.tbDO1Value.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDO1Value.Location = new System.Drawing.Point(96, 45);
            this.tbDO1Value.Name = "tbDO1Value";
            this.tbDO1Value.Size = new System.Drawing.Size(28, 25);
            this.tbDO1Value.TabIndex = 24;
            this.tbDO1Value.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(6, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "PM Current";
            // 
            // tbStatusPMCurrent
            // 
            this.tbStatusPMCurrent.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStatusPMCurrent.Location = new System.Drawing.Point(96, 138);
            this.tbStatusPMCurrent.Name = "tbStatusPMCurrent";
            this.tbStatusPMCurrent.Size = new System.Drawing.Size(77, 25);
            this.tbStatusPMCurrent.TabIndex = 22;
            this.tbStatusPMCurrent.Text = "60";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(6, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "PM Volts";
            // 
            // tbStatusPMVolts
            // 
            this.tbStatusPMVolts.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStatusPMVolts.Location = new System.Drawing.Point(96, 107);
            this.tbStatusPMVolts.Name = "tbStatusPMVolts";
            this.tbStatusPMVolts.Size = new System.Drawing.Size(77, 25);
            this.tbStatusPMVolts.TabIndex = 20;
            this.tbStatusPMVolts.Text = "50";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(265, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Di[3]";
            // 
            // tbDI3
            // 
            this.tbDI3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDI3.Location = new System.Drawing.Point(347, 169);
            this.tbDI3.Name = "tbDI3";
            this.tbDI3.Size = new System.Drawing.Size(40, 25);
            this.tbDI3.TabIndex = 18;
            this.tbDI3.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(265, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Di[2]";
            // 
            // tbDI2
            // 
            this.tbDI2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDI2.Location = new System.Drawing.Point(347, 138);
            this.tbDI2.Name = "tbDI2";
            this.tbDI2.Size = new System.Drawing.Size(40, 25);
            this.tbDI2.TabIndex = 16;
            this.tbDI2.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(265, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 17);
            this.label18.TabIndex = 15;
            this.label18.Text = "Di[1]";
            // 
            // tbDI1
            // 
            this.tbDI1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDI1.Location = new System.Drawing.Point(347, 107);
            this.tbDI1.Name = "tbDI1";
            this.tbDI1.Size = new System.Drawing.Size(40, 25);
            this.tbDI1.TabIndex = 14;
            this.tbDI1.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(265, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 17);
            this.label19.TabIndex = 13;
            this.label19.Text = "Di[0]";
            // 
            // tbDI0
            // 
            this.tbDI0.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDI0.Location = new System.Drawing.Point(347, 76);
            this.tbDI0.Name = "tbDI0";
            this.tbDI0.Size = new System.Drawing.Size(40, 25);
            this.tbDI0.TabIndex = 12;
            this.tbDI0.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(6, 234);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 17);
            this.label20.TabIndex = 9;
            this.label20.Text = "PM Apparent";
            // 
            // tbStatusPMApparent
            // 
            this.tbStatusPMApparent.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStatusPMApparent.Location = new System.Drawing.Point(96, 231);
            this.tbStatusPMApparent.Name = "tbStatusPMApparent";
            this.tbStatusPMApparent.Size = new System.Drawing.Size(77, 25);
            this.tbStatusPMApparent.TabIndex = 8;
            this.tbStatusPMApparent.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(6, 203);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 7;
            this.label21.Text = "PM Reactive";
            // 
            // tbStatusPMReactive
            // 
            this.tbStatusPMReactive.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStatusPMReactive.Location = new System.Drawing.Point(96, 200);
            this.tbStatusPMReactive.Name = "tbStatusPMReactive";
            this.tbStatusPMReactive.Size = new System.Drawing.Size(77, 25);
            this.tbStatusPMReactive.TabIndex = 6;
            this.tbStatusPMReactive.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(6, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 17);
            this.label22.TabIndex = 5;
            this.label22.Text = "PM Active";
            // 
            // tbStatusPMActive
            // 
            this.tbStatusPMActive.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStatusPMActive.Location = new System.Drawing.Point(96, 169);
            this.tbStatusPMActive.Name = "tbStatusPMActive";
            this.tbStatusPMActive.Size = new System.Drawing.Size(77, 25);
            this.tbStatusPMActive.TabIndex = 4;
            this.tbStatusPMActive.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(6, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 17);
            this.label23.TabIndex = 3;
            this.label23.Text = "RTD";
            // 
            // tbRTD
            // 
            this.tbRTD.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRTD.Location = new System.Drawing.Point(96, 76);
            this.tbRTD.Name = "tbRTD";
            this.tbRTD.Size = new System.Drawing.Size(77, 25);
            this.tbRTD.TabIndex = 2;
            this.tbRTD.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(6, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 17);
            this.label24.TabIndex = 1;
            this.label24.Text = "Do[0]";
            // 
            // tbDO0Value
            // 
            this.tbDO0Value.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDO0Value.Location = new System.Drawing.Point(96, 14);
            this.tbDO0Value.Name = "tbDO0Value";
            this.tbDO0Value.Size = new System.Drawing.Size(28, 25);
            this.tbDO0Value.TabIndex = 0;
            this.tbDO0Value.Text = "0";
            // 
            // btnCOMOpen
            // 
            this.btnCOMOpen.BackgroundImage = global::IOBoard.Properties.Resources.btnRClose;
            this.btnCOMOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCOMOpen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCOMOpen.FlatAppearance.BorderSize = 0;
            this.btnCOMOpen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCOMOpen.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCOMOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCOMOpen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCOMOpen.Location = new System.Drawing.Point(3, 68);
            this.btnCOMOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnCOMOpen.Name = "btnCOMOpen";
            this.btnCOMOpen.Size = new System.Drawing.Size(67, 29);
            this.btnCOMOpen.TabIndex = 18;
            this.btnCOMOpen.Text = "OPEN";
            this.btnCOMOpen.UseVisualStyleBackColor = true;
            this.btnCOMOpen.Click += new System.EventHandler(this.BtnCOMOpen_Click);
            // 
            // btnReadDPTemp
            // 
            this.btnReadDPTemp.Location = new System.Drawing.Point(581, 4);
            this.btnReadDPTemp.Name = "btnReadDPTemp";
            this.btnReadDPTemp.Size = new System.Drawing.Size(70, 46);
            this.btnReadDPTemp.TabIndex = 77;
            this.btnReadDPTemp.Text = "DP Temp\r\n00.00°C";
            this.btnReadDPTemp.UseVisualStyleBackColor = true;
            this.btnReadDPTemp.Click += new System.EventHandler(this.BtnReadDPTemp_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label63.Location = new System.Drawing.Point(618, 268);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(28, 17);
            this.label63.TabIndex = 94;
            this.label63.Text = "mA";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label64.Location = new System.Drawing.Point(472, 267);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(36, 17);
            this.label64.TabIndex = 93;
            this.label64.Text = "AI[7]";
            // 
            // tbAI7
            // 
            this.tbAI7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAI7.Location = new System.Drawing.Point(535, 264);
            this.tbAI7.Name = "tbAI7";
            this.tbAI7.Size = new System.Drawing.Size(77, 25);
            this.tbAI7.TabIndex = 92;
            this.tbAI7.Text = "0";
            // 
            // tbAI0
            // 
            this.tbAI0.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAI0.Location = new System.Drawing.Point(535, 55);
            this.tbAI0.Name = "tbAI0";
            this.tbAI0.Size = new System.Drawing.Size(77, 25);
            this.tbAI0.TabIndex = 58;
            this.tbAI0.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label38.Location = new System.Drawing.Point(472, 58);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(36, 17);
            this.label38.TabIndex = 59;
            this.label38.Text = "AI[0]";
            // 
            // tbAI1
            // 
            this.tbAI1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAI1.Location = new System.Drawing.Point(535, 85);
            this.tbAI1.Name = "tbAI1";
            this.tbAI1.Size = new System.Drawing.Size(77, 25);
            this.tbAI1.TabIndex = 60;
            this.tbAI1.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label33.Location = new System.Drawing.Point(472, 88);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(36, 17);
            this.label33.TabIndex = 61;
            this.label33.Text = "AI[1]";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label39.Location = new System.Drawing.Point(618, 89);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(28, 17);
            this.label39.TabIndex = 62;
            this.label39.Text = "mA";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label40.Location = new System.Drawing.Point(618, 57);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(28, 17);
            this.label40.TabIndex = 63;
            this.label40.Text = "mA";
            // 
            // tbAI2
            // 
            this.tbAI2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAI2.Location = new System.Drawing.Point(535, 115);
            this.tbAI2.Name = "tbAI2";
            this.tbAI2.Size = new System.Drawing.Size(77, 25);
            this.tbAI2.TabIndex = 78;
            this.tbAI2.Text = "0";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label57.Location = new System.Drawing.Point(472, 118);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(36, 17);
            this.label57.TabIndex = 79;
            this.label57.Text = "AI[2]";
            // 
            // tbAI3
            // 
            this.tbAI3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAI3.Location = new System.Drawing.Point(535, 145);
            this.tbAI3.Name = "tbAI3";
            this.tbAI3.Size = new System.Drawing.Size(77, 25);
            this.tbAI3.TabIndex = 80;
            this.tbAI3.Text = "0";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label56.Location = new System.Drawing.Point(472, 148);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(36, 17);
            this.label56.TabIndex = 81;
            this.label56.Text = "AI[3]";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label55.Location = new System.Drawing.Point(618, 149);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(28, 17);
            this.label55.TabIndex = 82;
            this.label55.Text = "mA";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label54.Location = new System.Drawing.Point(618, 117);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(28, 17);
            this.label54.TabIndex = 83;
            this.label54.Text = "mA";
            // 
            // tbAI4
            // 
            this.tbAI4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAI4.Location = new System.Drawing.Point(535, 174);
            this.tbAI4.Name = "tbAI4";
            this.tbAI4.Size = new System.Drawing.Size(77, 25);
            this.tbAI4.TabIndex = 84;
            this.tbAI4.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label61.Location = new System.Drawing.Point(472, 177);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(36, 17);
            this.label61.TabIndex = 85;
            this.label61.Text = "AI[4]";
            // 
            // tbAI5
            // 
            this.tbAI5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAI5.Location = new System.Drawing.Point(535, 204);
            this.tbAI5.Name = "tbAI5";
            this.tbAI5.Size = new System.Drawing.Size(77, 25);
            this.tbAI5.TabIndex = 86;
            this.tbAI5.Text = "0";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label60.Location = new System.Drawing.Point(472, 207);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(36, 17);
            this.label60.TabIndex = 87;
            this.label60.Text = "AI[5]";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label59.Location = new System.Drawing.Point(618, 208);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(28, 17);
            this.label59.TabIndex = 88;
            this.label59.Text = "mA";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label58.Location = new System.Drawing.Point(618, 178);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(28, 17);
            this.label58.TabIndex = 89;
            this.label58.Text = "mA";
            // 
            // tbAI6
            // 
            this.tbAI6.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbAI6.Location = new System.Drawing.Point(535, 234);
            this.tbAI6.Name = "tbAI6";
            this.tbAI6.Size = new System.Drawing.Size(77, 25);
            this.tbAI6.TabIndex = 90;
            this.tbAI6.Text = "0";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label65.Location = new System.Drawing.Point(472, 237);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(36, 17);
            this.label65.TabIndex = 91;
            this.label65.Text = "AI[6]";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label62.Location = new System.Drawing.Point(618, 236);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(28, 17);
            this.label62.TabIndex = 95;
            this.label62.Text = "mA";
            // 
            // IOBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 747);
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.panel_PowerSET);
            this.Controls.Add(this.btnSetEMP_IC);
            this.Controls.Add(this.btnSettingSPI_IC);
            this.Controls.Add(this.btn_DO2);
            this.Controls.Add(this.btn_DO1);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.btnViewStatusValue);
            this.Controls.Add(this.lbBoardTime);
            this.Controls.Add(this.btnSetConfig);
            this.Controls.Add(this.panel_config);
            this.Controls.Add(this.btnRequestReset);
            this.Controls.Add(this.btnUpdateTime);
            this.Controls.Add(this.btnRequestIOBoardInfo);
            this.Controls.Add(this.btnFileSendSend);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_ICSET);
            this.Controls.Add(this.panel_sendData);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IOBoard";
            this.Text = "IOBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IOBoard_FormClosing);
            this.Load += new System.EventHandler(this.IOBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_config.ResumeLayout(false);
            this.panel_config.PerformLayout();
            this.panel_ICSET.ResumeLayout(false);
            this.panel_ICSET.PerformLayout();
            this.panel_PowerSET.ResumeLayout(false);
            this.panel_PowerSET.PerformLayout();
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbBoudrate;
        private System.Windows.Forms.Button btnCOMOpen;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox debugText;
        private System.Windows.Forms.TextBox debugHex;
        private System.Windows.Forms.Panel panel_sendData;
        private System.Windows.Forms.Button btnFileSendSend;
        private System.Windows.Forms.Button btnRequestIOBoardInfo;
        private System.Windows.Forms.Button btnUpdateConfig;
        private System.Windows.Forms.Button btnRequestConfig;
        private System.Windows.Forms.Button btnUpdateTime;
        private System.Windows.Forms.Button btnRequestReset;
        private System.Windows.Forms.Panel panel_config;
        private System.Windows.Forms.Button btnSetConfig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPMFreq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPMCurrent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPMVolt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPMCycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPSCycle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDPSCycle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDICycle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAICycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRTDCycle;
        private System.Windows.Forms.Label lbBoardTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDO1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDO0;
        private System.Windows.Forms.Button btnViewStatusValue;
        private System.Windows.Forms.Timer timer1s;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnSPIRead0;
        private System.Windows.Forms.TextBox tbSPIReadReg0;
        private System.Windows.Forms.Button btnSPIWrite0;
        private System.Windows.Forms.TextBox tbSPIWriteData0;
        private System.Windows.Forms.TextBox tbSPIWriteReg0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel_ICSET;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox tbWriteRegData1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox tbWriteRegData4;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tbWriteRegData3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbWriteRegData2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tbWriteRegData0;
        private System.Windows.Forms.Button btnSPIWrite3;
        private System.Windows.Forms.TextBox tbSPIWriteData3;
        private System.Windows.Forms.TextBox tbSPIWriteReg3;
        private System.Windows.Forms.Button btnSPIRead2;
        private System.Windows.Forms.TextBox tbSPIReadReg2;
        private System.Windows.Forms.Button btnSPIWrite2;
        private System.Windows.Forms.TextBox tbSPIWriteData2;
        private System.Windows.Forms.TextBox tbSPIWriteReg2;
        private System.Windows.Forms.Button btnSPIRead1;
        private System.Windows.Forms.TextBox tbSPIReadReg1;
        private System.Windows.Forms.Button btnSPIWrite1;
        private System.Windows.Forms.TextBox tbSPIWriteData1;
        private System.Windows.Forms.TextBox tbSPIWriteReg1;
        private System.Windows.Forms.Button btnRegRead0;
        private System.Windows.Forms.Button btnRegWrite0;
        private System.Windows.Forms.Button btnRegRead8;
        private System.Windows.Forms.Button btnRegWrite8;
        private System.Windows.Forms.Button btnRegRead7;
        private System.Windows.Forms.Button btnRegWrite7;
        private System.Windows.Forms.Button btnRegRead6;
        private System.Windows.Forms.Button btnRegWrite6;
        private System.Windows.Forms.Button btnRegRead5;
        private System.Windows.Forms.Button btnRegWrite5;
        private System.Windows.Forms.Button btnRegRead4;
        private System.Windows.Forms.Button btnRegWrite4;
        private System.Windows.Forms.Button btnRegRead3;
        private System.Windows.Forms.Button btnRegWrite3;
        private System.Windows.Forms.Button btnRegRead2;
        private System.Windows.Forms.Button btnRegWrite2;
        private System.Windows.Forms.Button btnRegRead1;
        private System.Windows.Forms.Button btnRegWrite1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbWriteRegData8;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbWriteRegData7;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbWriteRegData6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbWriteRegData5;
        private System.Windows.Forms.Button btnSY7D609_ReadReg4;
        private System.Windows.Forms.TextBox tbSY7D609_WR4;
        private System.Windows.Forms.TextBox tbSY7D609_R4;
        private System.Windows.Forms.Button btnSY7D609_WriteReg4;
        private System.Windows.Forms.Timer timer_100ms;
        private System.Windows.Forms.Button btnSY7D609_ReadReg1;
        private System.Windows.Forms.TextBox tbSY7D609_R1;
        private System.Windows.Forms.Button btnSY7D609_ReadReg2;
        private System.Windows.Forms.TextBox tbSY7D609_R2;
        private System.Windows.Forms.Button btnSY7D609_ReadReg3;
        private System.Windows.Forms.TextBox tbSY7D609_R3;
        private System.Windows.Forms.Button btnSY7D609_WriteReg1;
        private System.Windows.Forms.TextBox tbSY7D609_WR1;
        private System.Windows.Forms.Button btnSY7D609_WriteReg2;
        private System.Windows.Forms.TextBox tbSY7D609_WR2;
        private System.Windows.Forms.Button btnSY7D609_WriteReg3;
        private System.Windows.Forms.TextBox tbSY7D609_WR3;
        private System.Windows.Forms.Button btnSY7D609_ReadReg5;
        private System.Windows.Forms.TextBox tbSY7D609_R5;
        private System.Windows.Forms.Button btnSY7D609_ReadReg6;
        private System.Windows.Forms.TextBox tbSY7D609_R6;
        private System.Windows.Forms.Button btnSY7D609_ReadReg7;
        private System.Windows.Forms.TextBox tbSY7D609_R7;
        private System.Windows.Forms.Button btnSY7D609_ReadReg8;
        private System.Windows.Forms.TextBox tbSY7D609_R8;
        private System.Windows.Forms.Button btn_DO2;
        private System.Windows.Forms.Button btn_DO1;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox tbInputPF;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox tbInputRatio;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox tbInputVolt;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button btnSettingSPI_IC;
        private System.Windows.Forms.Button btnSetEMP_IC;
        private System.Windows.Forms.Panel panel_PowerSET;
        private System.Windows.Forms.Button btnSumPowerReset;
        private System.Windows.Forms.Button btnRequestCalWattMeter;
        private System.Windows.Forms.Button btnUpdateCalValue;
        private System.Windows.Forms.Button btnRequestWattMeterValue;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox tbVGain;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox tbIGain;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Button btnStatusRequestCont;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Button btnSumPowerMeter;
        private System.Windows.Forms.Button btnPowerMeter;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button btnReadPSTemp;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tbStatusPMCos;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox tbPS;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbStatusDP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbStatusPMEnergy;
        private System.Windows.Forms.Button btnRequestStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDO1Value;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbStatusPMCurrent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbStatusPMVolts;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDI3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbDI2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbDI1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbDI0;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbStatusPMApparent;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbStatusPMReactive;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbStatusPMActive;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbRTD;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbDO0Value;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox tbAI7;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox tbAI6;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox tbAI5;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox tbAI4;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox tbAI3;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox tbAI2;
        private System.Windows.Forms.Button btnReadDPTemp;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbAI1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tbAI0;
    }
}