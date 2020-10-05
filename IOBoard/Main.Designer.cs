namespace IOBoard
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_1s = new System.Windows.Forms.Timer(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btn_SetupNetwork = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CLOSE = new System.Windows.Forms.Button();
            this.btn_ViewIO = new System.Windows.Forms.Button();
            this.btn_ViewNetwork = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel_view_nework = new System.Windows.Forms.Panel();
            this.button23 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.panel_view_io = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.tb_IPAddress_view = new System.Windows.Forms.TextBox();
            this.tb_subnet_view = new System.Windows.Forms.TextBox();
            this.tb_gateway_view = new System.Windows.Forms.TextBox();
            this.panel_setup_nework = new System.Windows.Forms.Panel();
            this.btn_KeyEnter = new System.Windows.Forms.Button();
            this.btn_KeyComma = new System.Windows.Forms.Button();
            this.btn_Key0 = new System.Windows.Forms.Button();
            this.btn_Key9 = new System.Windows.Forms.Button();
            this.btn_Key8 = new System.Windows.Forms.Button();
            this.btn_Key7 = new System.Windows.Forms.Button();
            this.btn_Key6 = new System.Windows.Forms.Button();
            this.btn_Key5 = new System.Windows.Forms.Button();
            this.btn_Key4 = new System.Windows.Forms.Button();
            this.btn_Key3 = new System.Windows.Forms.Button();
            this.btn_Key2 = new System.Windows.Forms.Button();
            this.btn_Key1 = new System.Windows.Forms.Button();
            this.tb_gateway_setup = new System.Windows.Forms.TextBox();
            this.tb_subnet_setup = new System.Windows.Forms.TextBox();
            this.tb_IPAddress_setup = new System.Windows.Forms.TextBox();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_view_nework.SuspendLayout();
            this.panel_view_io.SuspendLayout();
            this.panel_setup_nework.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.btn_Menu);
            this.panel_top.Controls.Add(this.label_date);
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(480, 51);
            this.panel_top.TabIndex = 1;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_date.Location = new System.Drawing.Point(154, 14);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(175, 19);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "2020/01/01 00:00:00";
            // 
            // btn_Menu
            // 
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Menu.Location = new System.Drawing.Point(357, 3);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(120, 40);
            this.btn_Menu.TabIndex = 2;
            this.btn_Menu.Text = "MENU";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Version 1.0";
            // 
            // timer_1s
            // 
            this.timer_1s.Enabled = true;
            this.timer_1s.Interval = 1000;
            this.timer_1s.Tick += new System.EventHandler(this.Timer_1s_Tick);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.groupBox2);
            this.panel_menu.Controls.Add(this.groupBox3);
            this.panel_menu.Location = new System.Drawing.Point(0, 55);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(480, 263);
            this.panel_menu.TabIndex = 11;
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button17.Location = new System.Drawing.Point(6, 74);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(120, 40);
            this.button17.TabIndex = 6;
            this.button17.Text = "LORA";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button16.Location = new System.Drawing.Point(132, 74);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(120, 40);
            this.button16.TabIndex = 7;
            this.button16.Text = "IO";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // btn_SetupNetwork
            // 
            this.btn_SetupNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetupNetwork.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SetupNetwork.Location = new System.Drawing.Point(6, 28);
            this.btn_SetupNetwork.Name = "btn_SetupNetwork";
            this.btn_SetupNetwork.Size = new System.Drawing.Size(120, 40);
            this.btn_SetupNetwork.TabIndex = 4;
            this.btn_SetupNetwork.Text = "NETWORK";
            this.btn_SetupNetwork.UseVisualStyleBackColor = true;
            this.btn_SetupNetwork.Click += new System.EventHandler(this.Btn_SetupNetwork_Click);
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.Location = new System.Drawing.Point(6, 120);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 40);
            this.button14.TabIndex = 8;
            this.button14.Text = "WattMeter";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(132, 28);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 40);
            this.button13.TabIndex = 5;
            this.button13.Text = "SERIAL";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(132, 120);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 40);
            this.button11.TabIndex = 9;
            this.button11.Text = "메뉴";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button11);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.btn_SetupNetwork);
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(16, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 169);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SETUP";
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CLOSE.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CLOSE.Location = new System.Drawing.Point(6, 120);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(120, 40);
            this.btn_CLOSE.TabIndex = 0;
            this.btn_CLOSE.Text = "CLOSE";
            this.btn_CLOSE.UseVisualStyleBackColor = true;
            this.btn_CLOSE.Click += new System.EventHandler(this.Btn_CLOSE_Click);
            // 
            // btn_ViewIO
            // 
            this.btn_ViewIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewIO.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ViewIO.Location = new System.Drawing.Point(6, 74);
            this.btn_ViewIO.Name = "btn_ViewIO";
            this.btn_ViewIO.Size = new System.Drawing.Size(120, 40);
            this.btn_ViewIO.TabIndex = 6;
            this.btn_ViewIO.Text = "IO";
            this.btn_ViewIO.UseVisualStyleBackColor = true;
            this.btn_ViewIO.Click += new System.EventHandler(this.Btn_ViewIO_Click);
            // 
            // btn_ViewNetwork
            // 
            this.btn_ViewNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewNetwork.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_ViewNetwork.Location = new System.Drawing.Point(6, 28);
            this.btn_ViewNetwork.Name = "btn_ViewNetwork";
            this.btn_ViewNetwork.Size = new System.Drawing.Size(120, 40);
            this.btn_ViewNetwork.TabIndex = 4;
            this.btn_ViewNetwork.Text = "NETWORK";
            this.btn_ViewNetwork.UseVisualStyleBackColor = true;
            this.btn_ViewNetwork.Click += new System.EventHandler(this.Btn_ViewNetwork_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ViewNetwork);
            this.groupBox2.Controls.Add(this.btn_ViewIO);
            this.groupBox2.Controls.Add(this.btn_CLOSE);
            this.groupBox2.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(320, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 169);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "VIEW";
            // 
            // panel_view_nework
            // 
            this.panel_view_nework.Controls.Add(this.tb_gateway_view);
            this.panel_view_nework.Controls.Add(this.tb_subnet_view);
            this.panel_view_nework.Controls.Add(this.tb_IPAddress_view);
            this.panel_view_nework.Controls.Add(this.button22);
            this.panel_view_nework.Controls.Add(this.button21);
            this.panel_view_nework.Controls.Add(this.button20);
            this.panel_view_nework.Controls.Add(this.button19);
            this.panel_view_nework.Controls.Add(this.button23);
            this.panel_view_nework.Controls.Add(this.button25);
            this.panel_view_nework.Location = new System.Drawing.Point(0, 343);
            this.panel_view_nework.Name = "panel_view_nework";
            this.panel_view_nework.Size = new System.Drawing.Size(480, 263);
            this.panel_view_nework.TabIndex = 13;
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button23.Location = new System.Drawing.Point(52, 50);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(120, 29);
            this.button23.TabIndex = 5;
            this.button23.Text = "IP ADDRESS";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button25.Location = new System.Drawing.Point(52, 15);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(120, 29);
            this.button25.TabIndex = 4;
            this.button25.Text = "TYPE";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // panel_view_io
            // 
            this.panel_view_io.Controls.Add(this.label11);
            this.panel_view_io.Controls.Add(this.label10);
            this.panel_view_io.Controls.Add(this.label9);
            this.panel_view_io.Controls.Add(this.label8);
            this.panel_view_io.Controls.Add(this.label7);
            this.panel_view_io.Controls.Add(this.label6);
            this.panel_view_io.Controls.Add(this.label5);
            this.panel_view_io.Controls.Add(this.label4);
            this.panel_view_io.Controls.Add(this.label3);
            this.panel_view_io.Location = new System.Drawing.Point(515, 343);
            this.panel_view_io.Name = "panel_view_io";
            this.panel_view_io.Size = new System.Drawing.Size(480, 263);
            this.panel_view_io.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 2);
            this.label2.TabIndex = 15;
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button19.Location = new System.Drawing.Point(52, 85);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(120, 29);
            this.button19.TabIndex = 6;
            this.button19.Text = "SUBNET";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button20.Location = new System.Drawing.Point(52, 120);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 29);
            this.button20.TabIndex = 7;
            this.button20.Text = "GATEWAY";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button21.Location = new System.Drawing.Point(195, 15);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(120, 29);
            this.button21.TabIndex = 8;
            this.button21.Text = "STATIC";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button22.Location = new System.Drawing.Point(321, 15);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(120, 29);
            this.button22.TabIndex = 9;
            this.button22.Text = "DHCP";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // tb_IPAddress_view
            // 
            this.tb_IPAddress_view.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_IPAddress_view.Location = new System.Drawing.Point(195, 51);
            this.tb_IPAddress_view.Name = "tb_IPAddress_view";
            this.tb_IPAddress_view.Size = new System.Drawing.Size(246, 26);
            this.tb_IPAddress_view.TabIndex = 10;
            this.tb_IPAddress_view.Text = "192.168.1.100";
            this.tb_IPAddress_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_subnet_view
            // 
            this.tb_subnet_view.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_subnet_view.Location = new System.Drawing.Point(195, 87);
            this.tb_subnet_view.Name = "tb_subnet_view";
            this.tb_subnet_view.Size = new System.Drawing.Size(246, 26);
            this.tb_subnet_view.TabIndex = 11;
            this.tb_subnet_view.Text = "255.255.255.0";
            this.tb_subnet_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_gateway_view
            // 
            this.tb_gateway_view.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_gateway_view.Location = new System.Drawing.Point(195, 122);
            this.tb_gateway_view.Name = "tb_gateway_view";
            this.tb_gateway_view.Size = new System.Drawing.Size(246, 26);
            this.tb_gateway_view.TabIndex = 12;
            this.tb_gateway_view.Text = "192.168.1.1";
            this.tb_gateway_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_setup_nework
            // 
            this.panel_setup_nework.Controls.Add(this.btn_KeyEnter);
            this.panel_setup_nework.Controls.Add(this.btn_KeyComma);
            this.panel_setup_nework.Controls.Add(this.btn_Key0);
            this.panel_setup_nework.Controls.Add(this.btn_Key9);
            this.panel_setup_nework.Controls.Add(this.btn_Key8);
            this.panel_setup_nework.Controls.Add(this.btn_Key7);
            this.panel_setup_nework.Controls.Add(this.btn_Key6);
            this.panel_setup_nework.Controls.Add(this.btn_Key5);
            this.panel_setup_nework.Controls.Add(this.btn_Key4);
            this.panel_setup_nework.Controls.Add(this.btn_Key3);
            this.panel_setup_nework.Controls.Add(this.btn_Key2);
            this.panel_setup_nework.Controls.Add(this.btn_Key1);
            this.panel_setup_nework.Controls.Add(this.tb_gateway_setup);
            this.panel_setup_nework.Controls.Add(this.tb_subnet_setup);
            this.panel_setup_nework.Controls.Add(this.tb_IPAddress_setup);
            this.panel_setup_nework.Controls.Add(this.button49);
            this.panel_setup_nework.Controls.Add(this.button50);
            this.panel_setup_nework.Controls.Add(this.button51);
            this.panel_setup_nework.Controls.Add(this.button52);
            this.panel_setup_nework.Controls.Add(this.button53);
            this.panel_setup_nework.Controls.Add(this.button54);
            this.panel_setup_nework.Location = new System.Drawing.Point(514, 50);
            this.panel_setup_nework.Name = "panel_setup_nework";
            this.panel_setup_nework.Size = new System.Drawing.Size(480, 263);
            this.panel_setup_nework.TabIndex = 25;
            // 
            // btn_KeyEnter
            // 
            this.btn_KeyEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KeyEnter.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_KeyEnter.Location = new System.Drawing.Point(388, 217);
            this.btn_KeyEnter.Name = "btn_KeyEnter";
            this.btn_KeyEnter.Size = new System.Drawing.Size(64, 40);
            this.btn_KeyEnter.TabIndex = 24;
            this.btn_KeyEnter.Text = "↲";
            this.btn_KeyEnter.UseVisualStyleBackColor = true;
            this.btn_KeyEnter.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_KeyComma
            // 
            this.btn_KeyComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KeyComma.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_KeyComma.Location = new System.Drawing.Point(318, 217);
            this.btn_KeyComma.Name = "btn_KeyComma";
            this.btn_KeyComma.Size = new System.Drawing.Size(64, 40);
            this.btn_KeyComma.TabIndex = 23;
            this.btn_KeyComma.Text = ".";
            this.btn_KeyComma.UseVisualStyleBackColor = true;
            this.btn_KeyComma.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key0
            // 
            this.btn_Key0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key0.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key0.Location = new System.Drawing.Point(248, 217);
            this.btn_Key0.Name = "btn_Key0";
            this.btn_Key0.Size = new System.Drawing.Size(64, 40);
            this.btn_Key0.TabIndex = 22;
            this.btn_Key0.Text = "0";
            this.btn_Key0.UseVisualStyleBackColor = true;
            this.btn_Key0.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key9
            // 
            this.btn_Key9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key9.Location = new System.Drawing.Point(178, 217);
            this.btn_Key9.Name = "btn_Key9";
            this.btn_Key9.Size = new System.Drawing.Size(64, 40);
            this.btn_Key9.TabIndex = 21;
            this.btn_Key9.Text = "9";
            this.btn_Key9.UseVisualStyleBackColor = true;
            this.btn_Key9.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key8
            // 
            this.btn_Key8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key8.Location = new System.Drawing.Point(108, 217);
            this.btn_Key8.Name = "btn_Key8";
            this.btn_Key8.Size = new System.Drawing.Size(64, 40);
            this.btn_Key8.TabIndex = 20;
            this.btn_Key8.Text = "8";
            this.btn_Key8.UseVisualStyleBackColor = true;
            this.btn_Key8.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key7
            // 
            this.btn_Key7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key7.Location = new System.Drawing.Point(38, 217);
            this.btn_Key7.Name = "btn_Key7";
            this.btn_Key7.Size = new System.Drawing.Size(64, 40);
            this.btn_Key7.TabIndex = 19;
            this.btn_Key7.Text = "7";
            this.btn_Key7.UseVisualStyleBackColor = true;
            this.btn_Key7.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key6
            // 
            this.btn_Key6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key6.Location = new System.Drawing.Point(388, 171);
            this.btn_Key6.Name = "btn_Key6";
            this.btn_Key6.Size = new System.Drawing.Size(64, 40);
            this.btn_Key6.TabIndex = 18;
            this.btn_Key6.Text = "6";
            this.btn_Key6.UseVisualStyleBackColor = true;
            this.btn_Key6.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key5
            // 
            this.btn_Key5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key5.Location = new System.Drawing.Point(318, 171);
            this.btn_Key5.Name = "btn_Key5";
            this.btn_Key5.Size = new System.Drawing.Size(64, 40);
            this.btn_Key5.TabIndex = 17;
            this.btn_Key5.Text = "5";
            this.btn_Key5.UseVisualStyleBackColor = true;
            this.btn_Key5.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key4
            // 
            this.btn_Key4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key4.Location = new System.Drawing.Point(248, 171);
            this.btn_Key4.Name = "btn_Key4";
            this.btn_Key4.Size = new System.Drawing.Size(64, 40);
            this.btn_Key4.TabIndex = 16;
            this.btn_Key4.Text = "4";
            this.btn_Key4.UseVisualStyleBackColor = true;
            this.btn_Key4.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key3
            // 
            this.btn_Key3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key3.Location = new System.Drawing.Point(178, 171);
            this.btn_Key3.Name = "btn_Key3";
            this.btn_Key3.Size = new System.Drawing.Size(64, 40);
            this.btn_Key3.TabIndex = 15;
            this.btn_Key3.Text = "3";
            this.btn_Key3.UseVisualStyleBackColor = true;
            this.btn_Key3.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key2
            // 
            this.btn_Key2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key2.Location = new System.Drawing.Point(108, 171);
            this.btn_Key2.Name = "btn_Key2";
            this.btn_Key2.Size = new System.Drawing.Size(64, 40);
            this.btn_Key2.TabIndex = 14;
            this.btn_Key2.Text = "2";
            this.btn_Key2.UseVisualStyleBackColor = true;
            this.btn_Key2.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // btn_Key1
            // 
            this.btn_Key1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key1.Location = new System.Drawing.Point(38, 171);
            this.btn_Key1.Name = "btn_Key1";
            this.btn_Key1.Size = new System.Drawing.Size(64, 40);
            this.btn_Key1.TabIndex = 13;
            this.btn_Key1.Text = "1";
            this.btn_Key1.UseVisualStyleBackColor = true;
            this.btn_Key1.Click += new System.EventHandler(this.Btn_Key_Clicked);
            // 
            // tb_gateway_setup
            // 
            this.tb_gateway_setup.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_gateway_setup.Location = new System.Drawing.Point(195, 122);
            this.tb_gateway_setup.Name = "tb_gateway_setup";
            this.tb_gateway_setup.Size = new System.Drawing.Size(246, 26);
            this.tb_gateway_setup.TabIndex = 12;
            this.tb_gateway_setup.Text = "192.168.1.1";
            this.tb_gateway_setup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_gateway_setup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tb_gateway_setup_MouseDown);
            // 
            // tb_subnet_setup
            // 
            this.tb_subnet_setup.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_subnet_setup.Location = new System.Drawing.Point(195, 87);
            this.tb_subnet_setup.Name = "tb_subnet_setup";
            this.tb_subnet_setup.Size = new System.Drawing.Size(246, 26);
            this.tb_subnet_setup.TabIndex = 11;
            this.tb_subnet_setup.Text = "255.255.255.0";
            this.tb_subnet_setup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_subnet_setup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tb_subnet_setup_MouseDown);
            // 
            // tb_IPAddress_setup
            // 
            this.tb_IPAddress_setup.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_IPAddress_setup.Location = new System.Drawing.Point(195, 51);
            this.tb_IPAddress_setup.Name = "tb_IPAddress_setup";
            this.tb_IPAddress_setup.Size = new System.Drawing.Size(246, 26);
            this.tb_IPAddress_setup.TabIndex = 10;
            this.tb_IPAddress_setup.Text = "192.168.1.100";
            this.tb_IPAddress_setup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_IPAddress_setup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tb_IPAddress_setup_MouseDown);
            // 
            // button49
            // 
            this.button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button49.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button49.Location = new System.Drawing.Point(321, 15);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(120, 29);
            this.button49.TabIndex = 9;
            this.button49.Text = "DHCP";
            this.button49.UseVisualStyleBackColor = true;
            // 
            // button50
            // 
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button50.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button50.Location = new System.Drawing.Point(195, 15);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(120, 29);
            this.button50.TabIndex = 8;
            this.button50.Text = "STATIC";
            this.button50.UseVisualStyleBackColor = true;
            // 
            // button51
            // 
            this.button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button51.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button51.Location = new System.Drawing.Point(52, 120);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(120, 29);
            this.button51.TabIndex = 7;
            this.button51.Text = "GATEWAY";
            this.button51.UseVisualStyleBackColor = true;
            // 
            // button52
            // 
            this.button52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button52.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button52.Location = new System.Drawing.Point(52, 85);
            this.button52.Name = "button52";
            this.button52.Size = new System.Drawing.Size(120, 29);
            this.button52.TabIndex = 6;
            this.button52.Text = "SUBNET";
            this.button52.UseVisualStyleBackColor = true;
            // 
            // button53
            // 
            this.button53.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button53.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button53.Location = new System.Drawing.Point(52, 50);
            this.button53.Name = "button53";
            this.button53.Size = new System.Drawing.Size(120, 29);
            this.button53.TabIndex = 5;
            this.button53.Text = "IP ADDRESS";
            this.button53.UseVisualStyleBackColor = true;
            // 
            // button54
            // 
            this.button54.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button54.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button54.Location = new System.Drawing.Point(52, 15);
            this.button54.Name = "button54";
            this.button54.Size = new System.Drawing.Size(120, 29);
            this.button54.TabIndex = 4;
            this.button54.Text = "TYPE";
            this.button54.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(40, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "AI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(40, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "DI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(40, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "DO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(40, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "RTD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(40, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "DP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(40, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "CD 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(40, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "CT 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(103, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "1=4.23mA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(220, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "2=19.01mA";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 638);
            this.Controls.Add(this.panel_setup_nework);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_view_io);
            this.Controls.Add(this.panel_view_nework);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "IO제어";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel_view_nework.ResumeLayout(false);
            this.panel_view_nework.PerformLayout();
            this.panel_view_io.ResumeLayout(false);
            this.panel_view_io.PerformLayout();
            this.panel_setup_nework.ResumeLayout(false);
            this.panel_setup_nework.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Timer timer_1s;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ViewNetwork;
        private System.Windows.Forms.Button btn_ViewIO;
        private System.Windows.Forms.Button btn_CLOSE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn_SetupNetwork;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Panel panel_view_nework;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Panel panel_view_io;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_gateway_view;
        private System.Windows.Forms.TextBox tb_subnet_view;
        private System.Windows.Forms.TextBox tb_IPAddress_view;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_setup_nework;
        private System.Windows.Forms.Button btn_KeyEnter;
        private System.Windows.Forms.Button btn_KeyComma;
        private System.Windows.Forms.Button btn_Key0;
        private System.Windows.Forms.Button btn_Key9;
        private System.Windows.Forms.Button btn_Key8;
        private System.Windows.Forms.Button btn_Key7;
        private System.Windows.Forms.Button btn_Key6;
        private System.Windows.Forms.Button btn_Key5;
        private System.Windows.Forms.Button btn_Key4;
        private System.Windows.Forms.Button btn_Key3;
        private System.Windows.Forms.Button btn_Key2;
        private System.Windows.Forms.Button btn_Key1;
        private System.Windows.Forms.TextBox tb_gateway_setup;
        private System.Windows.Forms.TextBox tb_subnet_setup;
        private System.Windows.Forms.TextBox tb_IPAddress_setup;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button button54;
    }
}

