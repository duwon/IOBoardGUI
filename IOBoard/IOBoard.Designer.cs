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
            this.btnCOMOpen = new System.Windows.Forms.Button();
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
            this.btnRequestCalWattMeter = new System.Windows.Forms.Button();
            this.btnRequestWattMeterValue = new System.Windows.Forms.Button();
            this.btnRequestReset = new System.Windows.Forms.Button();
            this.panel_config = new System.Windows.Forms.Panel();
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
            this.label12 = new System.Windows.Forms.Label();
            this.tbPMMode = new System.Windows.Forms.TextBox();
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
            this.btnSetConfig = new System.Windows.Forms.Button();
            this.lbBoardTime = new System.Windows.Forms.Label();
            this.btnViewStatusValue = new System.Windows.Forms.Button();
            this.panel_status = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDO1Value = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDI3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbDI2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbDI1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbDI0 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbDO0Value = new System.Windows.Forms.TextBox();
            this.timer1s = new System.Windows.Forms.Timer(this.components);
            this.btn_DO1 = new System.Windows.Forms.Button();
            this.btn_DO2 = new System.Windows.Forms.Button();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_config.SuspendLayout();
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
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 302);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.debugText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.debugHex);
            this.splitContainer1.Size = new System.Drawing.Size(1540, 445);
            this.splitContainer1.SplitterDistance = 776;
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
            this.debugText.Size = new System.Drawing.Size(774, 440);
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
            this.debugHex.Size = new System.Drawing.Size(758, 440);
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
            this.btnFileSendSend.Location = new System.Drawing.Point(114, 192);
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
            this.btnUpdateConfig.Location = new System.Drawing.Point(114, 137);
            this.btnUpdateConfig.Name = "btnUpdateConfig";
            this.btnUpdateConfig.Size = new System.Drawing.Size(90, 44);
            this.btnUpdateConfig.TabIndex = 36;
            this.btnUpdateConfig.Text = "CONFIG 전송";
            this.btnUpdateConfig.UseVisualStyleBackColor = true;
            this.btnUpdateConfig.Click += new System.EventHandler(this.btnUpdateConfig_Click);
            // 
            // btnRequestConfig
            // 
            this.btnRequestConfig.Location = new System.Drawing.Point(220, 137);
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
            // btnRequestCalWattMeter
            // 
            this.btnRequestCalWattMeter.Location = new System.Drawing.Point(114, 82);
            this.btnRequestCalWattMeter.Name = "btnRequestCalWattMeter";
            this.btnRequestCalWattMeter.Size = new System.Drawing.Size(90, 44);
            this.btnRequestCalWattMeter.TabIndex = 39;
            this.btnRequestCalWattMeter.Text = "적산전력계 CAL";
            this.btnRequestCalWattMeter.UseVisualStyleBackColor = true;
            this.btnRequestCalWattMeter.Click += new System.EventHandler(this.btnRequestCalWattMeter_Click);
            // 
            // btnRequestWattMeterValue
            // 
            this.btnRequestWattMeterValue.Location = new System.Drawing.Point(220, 82);
            this.btnRequestWattMeterValue.Name = "btnRequestWattMeterValue";
            this.btnRequestWattMeterValue.Size = new System.Drawing.Size(90, 44);
            this.btnRequestWattMeterValue.TabIndex = 40;
            this.btnRequestWattMeterValue.Text = "적산전력계 값 요청";
            this.btnRequestWattMeterValue.UseVisualStyleBackColor = true;
            this.btnRequestWattMeterValue.Click += new System.EventHandler(this.btnRequestWattMeterValue_Click);
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
            this.panel_config.Controls.Add(this.label12);
            this.panel_config.Controls.Add(this.tbPMMode);
            this.panel_config.Controls.Add(this.label6);
            this.panel_config.Controls.Add(this.tbPSCycle);
            this.panel_config.Controls.Add(this.label5);
            this.panel_config.Controls.Add(this.tbDPSCycle);
            this.panel_config.Controls.Add(this.label3);
            this.panel_config.Controls.Add(this.tbDICycle);
            this.panel_config.Controls.Add(this.label4);
            this.panel_config.Controls.Add(this.tbAICycle);
            this.panel_config.Controls.Add(this.label2);
            this.panel_config.Controls.Add(this.tbRTDCycle);
            this.panel_config.Controls.Add(this.label1);
            this.panel_config.Controls.Add(this.tbDO0);
            this.panel_config.Location = new System.Drawing.Point(50, 359);
            this.panel_config.Name = "panel_config";
            this.panel_config.Size = new System.Drawing.Size(667, 296);
            this.panel_config.TabIndex = 26;
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
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "PM Freq";
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
            this.tbPMCycle.Text = "60";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(276, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "PM Mode";
            // 
            // tbPMMode
            // 
            this.tbPMMode.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbPMMode.Location = new System.Drawing.Point(358, 58);
            this.tbPMMode.Name = "tbPMMode";
            this.tbPMMode.Size = new System.Drawing.Size(77, 22);
            this.tbPMMode.TabIndex = 14;
            this.tbPMMode.Text = "1";
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
            this.tbRTDCycle.Text = "10";
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
            // btnSetConfig
            // 
            this.btnSetConfig.Location = new System.Drawing.Point(12, 137);
            this.btnSetConfig.Name = "btnSetConfig";
            this.btnSetConfig.Size = new System.Drawing.Size(90, 44);
            this.btnSetConfig.TabIndex = 42;
            this.btnSetConfig.Text = "CONFIG 확인";
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
            this.btnViewStatusValue.Location = new System.Drawing.Point(12, 192);
            this.btnViewStatusValue.Name = "btnViewStatusValue";
            this.btnViewStatusValue.Size = new System.Drawing.Size(90, 44);
            this.btnViewStatusValue.TabIndex = 44;
            this.btnViewStatusValue.Text = "STATUS 확인";
            this.btnViewStatusValue.UseVisualStyleBackColor = true;
            this.btnViewStatusValue.Click += new System.EventHandler(this.btnViewStatusValue_Click);
            // 
            // panel_status
            // 
            this.panel_status.Controls.Add(this.label25);
            this.panel_status.Controls.Add(this.label13);
            this.panel_status.Controls.Add(this.tbDO1Value);
            this.panel_status.Controls.Add(this.label14);
            this.panel_status.Controls.Add(this.textBox2);
            this.panel_status.Controls.Add(this.label15);
            this.panel_status.Controls.Add(this.textBox3);
            this.panel_status.Controls.Add(this.label16);
            this.panel_status.Controls.Add(this.tbDI3);
            this.panel_status.Controls.Add(this.label17);
            this.panel_status.Controls.Add(this.tbDI2);
            this.panel_status.Controls.Add(this.label18);
            this.panel_status.Controls.Add(this.tbDI1);
            this.panel_status.Controls.Add(this.label19);
            this.panel_status.Controls.Add(this.tbDI0);
            this.panel_status.Controls.Add(this.label20);
            this.panel_status.Controls.Add(this.textBox8);
            this.panel_status.Controls.Add(this.label21);
            this.panel_status.Controls.Add(this.textBox9);
            this.panel_status.Controls.Add(this.label22);
            this.panel_status.Controls.Add(this.textBox10);
            this.panel_status.Controls.Add(this.label23);
            this.panel_status.Controls.Add(this.textBox11);
            this.panel_status.Controls.Add(this.label24);
            this.panel_status.Controls.Add(this.tbDO0Value);
            this.panel_status.Location = new System.Drawing.Point(861, 359);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(667, 296);
            this.panel_status.TabIndex = 27;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(61, 223);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 15);
            this.label25.TabIndex = 26;
            this.label25.Text = "PM Freq";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(61, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Do[1]";
            // 
            // tbDO1Value
            // 
            this.tbDO1Value.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDO1Value.Location = new System.Drawing.Point(143, 58);
            this.tbDO1Value.Name = "tbDO1Value";
            this.tbDO1Value.Size = new System.Drawing.Size(77, 22);
            this.tbDO1Value.TabIndex = 24;
            this.tbDO1Value.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(276, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "PM Freq";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(358, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 22);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "60";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(276, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "PM Current";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(358, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(77, 22);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "50";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(276, 123);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Di[3]";
            // 
            // tbDI3
            // 
            this.tbDI3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDI3.Location = new System.Drawing.Point(358, 120);
            this.tbDI3.Name = "tbDI3";
            this.tbDI3.Size = new System.Drawing.Size(77, 22);
            this.tbDI3.TabIndex = 18;
            this.tbDI3.Text = "220";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(276, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 17;
            this.label17.Text = "Di[2]";
            // 
            // tbDI2
            // 
            this.tbDI2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDI2.Location = new System.Drawing.Point(358, 89);
            this.tbDI2.Name = "tbDI2";
            this.tbDI2.Size = new System.Drawing.Size(77, 22);
            this.tbDI2.TabIndex = 16;
            this.tbDI2.Text = "60";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(276, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 15;
            this.label18.Text = "Di[1]";
            // 
            // tbDI1
            // 
            this.tbDI1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDI1.Location = new System.Drawing.Point(358, 58);
            this.tbDI1.Name = "tbDI1";
            this.tbDI1.Size = new System.Drawing.Size(77, 22);
            this.tbDI1.TabIndex = 14;
            this.tbDI1.Text = "1";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(276, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 15);
            this.label19.TabIndex = 13;
            this.label19.Text = "Di[0]";
            // 
            // tbDI0
            // 
            this.tbDI0.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDI0.Location = new System.Drawing.Point(358, 23);
            this.tbDI0.Name = "tbDI0";
            this.tbDI0.Size = new System.Drawing.Size(77, 22);
            this.tbDI0.TabIndex = 12;
            this.tbDI0.Text = "1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(61, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "DPS Cycle";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox8.Location = new System.Drawing.Point(143, 182);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(77, 22);
            this.textBox8.TabIndex = 8;
            this.textBox8.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(61, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 15);
            this.label21.TabIndex = 7;
            this.label21.Text = "DI Cycle";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox9.Location = new System.Drawing.Point(143, 151);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(77, 22);
            this.textBox9.TabIndex = 6;
            this.textBox9.Text = "1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(61, 123);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 15);
            this.label22.TabIndex = 5;
            this.label22.Text = "AI Cycle";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox10.Location = new System.Drawing.Point(143, 120);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(77, 22);
            this.textBox10.TabIndex = 4;
            this.textBox10.Text = "1";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label23.Location = new System.Drawing.Point(61, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 15);
            this.label23.TabIndex = 3;
            this.label23.Text = "RTD Cycle";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox11.Location = new System.Drawing.Point(143, 89);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(77, 22);
            this.textBox11.TabIndex = 2;
            this.textBox11.Text = "10";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(61, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(42, 15);
            this.label24.TabIndex = 1;
            this.label24.Text = "Do[0]";
            // 
            // tbDO0Value
            // 
            this.tbDO0Value.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbDO0Value.Location = new System.Drawing.Point(143, 27);
            this.tbDO0Value.Name = "tbDO0Value";
            this.tbDO0Value.Size = new System.Drawing.Size(77, 22);
            this.tbDO0Value.TabIndex = 0;
            this.tbDO0Value.Text = "0";
            // 
            // timer1s
            // 
            this.timer1s.Enabled = true;
            this.timer1s.Interval = 1000;
            this.timer1s.Tick += new System.EventHandler(this.timer_1s_interrupt);
            // 
            // btn_DO1
            // 
            this.btn_DO1.Location = new System.Drawing.Point(12, 246);
            this.btn_DO1.Name = "btn_DO1";
            this.btn_DO1.Size = new System.Drawing.Size(43, 44);
            this.btn_DO1.TabIndex = 45;
            this.btn_DO1.Text = "DO 1";
            this.btn_DO1.UseVisualStyleBackColor = true;
            this.btn_DO1.Click += new System.EventHandler(this.btn_DO_Click);
            // 
            // btn_DO2
            // 
            this.btn_DO2.Location = new System.Drawing.Point(59, 246);
            this.btn_DO2.Name = "btn_DO2";
            this.btn_DO2.Size = new System.Drawing.Size(43, 44);
            this.btn_DO2.TabIndex = 46;
            this.btn_DO2.Text = "DO 1";
            this.btn_DO2.UseVisualStyleBackColor = true;
            this.btn_DO2.Click += new System.EventHandler(this.btn_DO_Click);
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(114, 246);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(90, 44);
            this.btnTest1.TabIndex = 47;
            this.btnTest1.Text = "테스트1 0xD1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.BtnTest1_Click);
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(220, 246);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(90, 44);
            this.btnTest2.TabIndex = 48;
            this.btnTest2.Text = "테스트2 0xD2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.BtnTest2_Click);
            // 
            // IOBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 747);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.btnTest1);
            this.Controls.Add(this.btn_DO2);
            this.Controls.Add(this.btn_DO1);
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.btnViewStatusValue);
            this.Controls.Add(this.lbBoardTime);
            this.Controls.Add(this.btnSetConfig);
            this.Controls.Add(this.panel_config);
            this.Controls.Add(this.btnRequestReset);
            this.Controls.Add(this.btnRequestWattMeterValue);
            this.Controls.Add(this.btnRequestCalWattMeter);
            this.Controls.Add(this.btnUpdateTime);
            this.Controls.Add(this.btnRequestConfig);
            this.Controls.Add(this.btnUpdateConfig);
            this.Controls.Add(this.btnRequestIOBoardInfo);
            this.Controls.Add(this.btnFileSendSend);
            this.Controls.Add(this.panel_sendData);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnRequestCalWattMeter;
        private System.Windows.Forms.Button btnRequestWattMeterValue;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPMMode;
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
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDO1Value;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDI3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbDI2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbDI1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbDI0;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbDO0Value;
        private System.Windows.Forms.Timer timer1s;
        private System.Windows.Forms.Button btn_DO1;
        private System.Windows.Forms.Button btn_DO2;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnTest2;
    }
}