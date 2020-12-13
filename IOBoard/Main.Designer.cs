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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.label_date = new System.Windows.Forms.Label();
            this.timer_1s = new System.Windows.Forms.Timer(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_CLOSE = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btn_SetupNetwork = new System.Windows.Forms.Button();
            this.panel_view_nework = new System.Windows.Forms.Panel();
            this.panel_view_io = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_setup_nework = new System.Windows.Forms.Panel();
            this.tb_gateway_setup = new System.Windows.Forms.TextBox();
            this.tb_subnet_setup = new System.Windows.Forms.TextBox();
            this.tb_IPAddress_setup = new System.Windows.Forms.TextBox();
            this.button49 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button52 = new System.Windows.Forms.Button();
            this.button53 = new System.Windows.Forms.Button();
            this.button54 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btn_KeySave = new System.Windows.Forms.Button();
            this.btn_KeyDel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button19 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.panel_view_nework.SuspendLayout();
            this.panel_view_io.SuspendLayout();
            this.panel_setup_nework.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // timer_1s
            // 
            this.timer_1s.Enabled = true;
            this.timer_1s.Interval = 1000;
            this.timer_1s.Tick += new System.EventHandler(this.Timer_1s_Tick);
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.button11);
            this.panel_menu.Controls.Add(this.button13);
            this.panel_menu.Controls.Add(this.btn_CLOSE);
            this.panel_menu.Controls.Add(this.button14);
            this.panel_menu.Controls.Add(this.btn_SetupNetwork);
            this.panel_menu.Location = new System.Drawing.Point(514, 343);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(480, 263);
            this.panel_menu.TabIndex = 11;
            // 
            // btn_CLOSE
            // 
            this.btn_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CLOSE.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CLOSE.Location = new System.Drawing.Point(282, 209);
            this.btn_CLOSE.Name = "btn_CLOSE";
            this.btn_CLOSE.Size = new System.Drawing.Size(120, 40);
            this.btn_CLOSE.TabIndex = 0;
            this.btn_CLOSE.Text = "CLOSE";
            this.btn_CLOSE.UseVisualStyleBackColor = true;
            this.btn_CLOSE.Click += new System.EventHandler(this.Btn_CLOSE_Click);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.Location = new System.Drawing.Point(67, 114);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 40);
            this.button11.TabIndex = 9;
            this.button11.Text = "서버설정";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.Location = new System.Drawing.Point(282, 114);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(120, 40);
            this.button13.TabIndex = 5;
            this.button13.Text = "재시작";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.Location = new System.Drawing.Point(282, 51);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(120, 40);
            this.button14.TabIndex = 8;
            this.button14.Text = "동작상태";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btn_SetupNetwork
            // 
            this.btn_SetupNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SetupNetwork.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SetupNetwork.Location = new System.Drawing.Point(67, 51);
            this.btn_SetupNetwork.Name = "btn_SetupNetwork";
            this.btn_SetupNetwork.Size = new System.Drawing.Size(120, 40);
            this.btn_SetupNetwork.TabIndex = 4;
            this.btn_SetupNetwork.Text = "NETWORK";
            this.btn_SetupNetwork.UseVisualStyleBackColor = true;
            this.btn_SetupNetwork.Click += new System.EventHandler(this.Btn_SetupNetwork_Click);
            // 
            // panel_view_nework
            // 
            this.panel_view_nework.Controls.Add(this.tb7);
            this.panel_view_nework.Controls.Add(this.button24);
            this.panel_view_nework.Controls.Add(this.textBox6);
            this.panel_view_nework.Controls.Add(this.button23);
            this.panel_view_nework.Controls.Add(this.textBox2);
            this.panel_view_nework.Controls.Add(this.button19);
            this.panel_view_nework.Controls.Add(this.textBox3);
            this.panel_view_nework.Controls.Add(this.textBox4);
            this.panel_view_nework.Controls.Add(this.textBox5);
            this.panel_view_nework.Controls.Add(this.button20);
            this.panel_view_nework.Controls.Add(this.button21);
            this.panel_view_nework.Controls.Add(this.button22);
            this.panel_view_nework.Location = new System.Drawing.Point(0, 343);
            this.panel_view_nework.Name = "panel_view_nework";
            this.panel_view_nework.Size = new System.Drawing.Size(480, 263);
            this.panel_view_nework.TabIndex = 13;
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
            this.panel_view_io.Location = new System.Drawing.Point(0, 55);
            this.panel_view_io.Name = "panel_view_io";
            this.panel_view_io.Size = new System.Drawing.Size(480, 263);
            this.panel_view_io.TabIndex = 14;
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
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 2);
            this.label2.TabIndex = 15;
            // 
            // panel_setup_nework
            // 
            this.panel_setup_nework.Controls.Add(this.textBox1);
            this.panel_setup_nework.Controls.Add(this.button18);
            this.panel_setup_nework.Controls.Add(this.tb_gateway_setup);
            this.panel_setup_nework.Controls.Add(this.tb_subnet_setup);
            this.panel_setup_nework.Controls.Add(this.tb_IPAddress_setup);
            this.panel_setup_nework.Controls.Add(this.button49);
            this.panel_setup_nework.Controls.Add(this.button50);
            this.panel_setup_nework.Controls.Add(this.button51);
            this.panel_setup_nework.Controls.Add(this.button52);
            this.panel_setup_nework.Controls.Add(this.button53);
            this.panel_setup_nework.Controls.Add(this.button54);
            this.panel_setup_nework.Location = new System.Drawing.Point(514, 55);
            this.panel_setup_nework.Name = "panel_setup_nework";
            this.panel_setup_nework.Size = new System.Drawing.Size(480, 263);
            this.panel_setup_nework.TabIndex = 25;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_KeySave);
            this.panel1.Controls.Add(this.btn_KeyDel);
            this.panel1.Controls.Add(this.btn_KeyEnter);
            this.panel1.Controls.Add(this.btn_KeyComma);
            this.panel1.Controls.Add(this.btn_Key0);
            this.panel1.Controls.Add(this.btn_Key9);
            this.panel1.Controls.Add(this.btn_Key8);
            this.panel1.Controls.Add(this.btn_Key7);
            this.panel1.Controls.Add(this.btn_Key6);
            this.panel1.Controls.Add(this.btn_Key5);
            this.panel1.Controls.Add(this.btn_Key4);
            this.panel1.Controls.Add(this.btn_Key3);
            this.panel1.Controls.Add(this.btn_Key2);
            this.panel1.Controls.Add(this.btn_Key1);
            this.panel1.Location = new System.Drawing.Point(379, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 263);
            this.panel1.TabIndex = 26;
            // 
            // btn_KeyEnter
            // 
            this.btn_KeyEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KeyEnter.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_KeyEnter.Location = new System.Drawing.Point(54, 190);
            this.btn_KeyEnter.Name = "btn_KeyEnter";
            this.btn_KeyEnter.Size = new System.Drawing.Size(40, 30);
            this.btn_KeyEnter.TabIndex = 24;
            this.btn_KeyEnter.Text = "확인";
            this.btn_KeyEnter.UseVisualStyleBackColor = true;
            // 
            // btn_KeyComma
            // 
            this.btn_KeyComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KeyComma.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_KeyComma.Location = new System.Drawing.Point(8, 190);
            this.btn_KeyComma.Name = "btn_KeyComma";
            this.btn_KeyComma.Size = new System.Drawing.Size(40, 30);
            this.btn_KeyComma.TabIndex = 23;
            this.btn_KeyComma.Text = ".";
            this.btn_KeyComma.UseVisualStyleBackColor = true;
            // 
            // btn_Key0
            // 
            this.btn_Key0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key0.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key0.Location = new System.Drawing.Point(54, 154);
            this.btn_Key0.Name = "btn_Key0";
            this.btn_Key0.Size = new System.Drawing.Size(40, 30);
            this.btn_Key0.TabIndex = 22;
            this.btn_Key0.Text = "0";
            this.btn_Key0.UseVisualStyleBackColor = true;
            // 
            // btn_Key9
            // 
            this.btn_Key9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key9.Location = new System.Drawing.Point(8, 154);
            this.btn_Key9.Name = "btn_Key9";
            this.btn_Key9.Size = new System.Drawing.Size(40, 30);
            this.btn_Key9.TabIndex = 21;
            this.btn_Key9.Text = "9";
            this.btn_Key9.UseVisualStyleBackColor = true;
            // 
            // btn_Key8
            // 
            this.btn_Key8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key8.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key8.Location = new System.Drawing.Point(54, 118);
            this.btn_Key8.Name = "btn_Key8";
            this.btn_Key8.Size = new System.Drawing.Size(40, 30);
            this.btn_Key8.TabIndex = 20;
            this.btn_Key8.Text = "8";
            this.btn_Key8.UseVisualStyleBackColor = true;
            // 
            // btn_Key7
            // 
            this.btn_Key7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key7.Location = new System.Drawing.Point(8, 118);
            this.btn_Key7.Name = "btn_Key7";
            this.btn_Key7.Size = new System.Drawing.Size(40, 30);
            this.btn_Key7.TabIndex = 19;
            this.btn_Key7.Text = "7";
            this.btn_Key7.UseVisualStyleBackColor = true;
            // 
            // btn_Key6
            // 
            this.btn_Key6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key6.Location = new System.Drawing.Point(54, 82);
            this.btn_Key6.Name = "btn_Key6";
            this.btn_Key6.Size = new System.Drawing.Size(40, 30);
            this.btn_Key6.TabIndex = 18;
            this.btn_Key6.Text = "6";
            this.btn_Key6.UseVisualStyleBackColor = true;
            // 
            // btn_Key5
            // 
            this.btn_Key5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key5.Location = new System.Drawing.Point(8, 82);
            this.btn_Key5.Name = "btn_Key5";
            this.btn_Key5.Size = new System.Drawing.Size(40, 30);
            this.btn_Key5.TabIndex = 17;
            this.btn_Key5.Text = "5";
            this.btn_Key5.UseVisualStyleBackColor = true;
            // 
            // btn_Key4
            // 
            this.btn_Key4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key4.Location = new System.Drawing.Point(54, 46);
            this.btn_Key4.Name = "btn_Key4";
            this.btn_Key4.Size = new System.Drawing.Size(40, 30);
            this.btn_Key4.TabIndex = 16;
            this.btn_Key4.Text = "4";
            this.btn_Key4.UseVisualStyleBackColor = true;
            // 
            // btn_Key3
            // 
            this.btn_Key3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key3.Location = new System.Drawing.Point(8, 46);
            this.btn_Key3.Name = "btn_Key3";
            this.btn_Key3.Size = new System.Drawing.Size(40, 30);
            this.btn_Key3.TabIndex = 15;
            this.btn_Key3.Text = "3";
            this.btn_Key3.UseVisualStyleBackColor = true;
            // 
            // btn_Key2
            // 
            this.btn_Key2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key2.Location = new System.Drawing.Point(54, 8);
            this.btn_Key2.Name = "btn_Key2";
            this.btn_Key2.Size = new System.Drawing.Size(40, 30);
            this.btn_Key2.TabIndex = 14;
            this.btn_Key2.Text = "2";
            this.btn_Key2.UseVisualStyleBackColor = true;
            // 
            // btn_Key1
            // 
            this.btn_Key1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Key1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Key1.Location = new System.Drawing.Point(8, 8);
            this.btn_Key1.Name = "btn_Key1";
            this.btn_Key1.Size = new System.Drawing.Size(40, 30);
            this.btn_Key1.TabIndex = 13;
            this.btn_Key1.Text = "1";
            this.btn_Key1.UseVisualStyleBackColor = true;
            // 
            // btn_KeySave
            // 
            this.btn_KeySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KeySave.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_KeySave.Location = new System.Drawing.Point(54, 226);
            this.btn_KeySave.Name = "btn_KeySave";
            this.btn_KeySave.Size = new System.Drawing.Size(40, 30);
            this.btn_KeySave.TabIndex = 26;
            this.btn_KeySave.Text = "저장";
            this.btn_KeySave.UseVisualStyleBackColor = true;
            // 
            // btn_KeyDel
            // 
            this.btn_KeyDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KeyDel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_KeyDel.Location = new System.Drawing.Point(8, 226);
            this.btn_KeyDel.Name = "btn_KeyDel";
            this.btn_KeyDel.Size = new System.Drawing.Size(40, 30);
            this.btn_KeyDel.TabIndex = 25;
            this.btn_KeyDel.Text = "Del";
            this.btn_KeyDel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(195, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "192.168.1.1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button18.Location = new System.Drawing.Point(52, 156);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(120, 29);
            this.button18.TabIndex = 13;
            this.button18.Text = "DNS";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(158, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 26);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "192.168.1.1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button19.Location = new System.Drawing.Point(15, 126);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(120, 29);
            this.button19.TabIndex = 21;
            this.button19.Text = "굴뚝코드";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(158, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 26);
            this.textBox3.TabIndex = 20;
            this.textBox3.Text = "192.168.1.1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(158, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 26);
            this.textBox4.TabIndex = 19;
            this.textBox4.Text = "255.255.255.0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(158, 21);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 26);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "192.168.1.100";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button20.Location = new System.Drawing.Point(15, 90);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(120, 29);
            this.button20.TabIndex = 17;
            this.button20.Text = "사업장코드";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button21.Location = new System.Drawing.Point(15, 55);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(120, 29);
            this.button21.TabIndex = 16;
            this.button21.Text = "Port";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button22.Location = new System.Drawing.Point(15, 20);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(120, 29);
            this.button22.TabIndex = 15;
            this.button22.Text = "Server IP";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox6.Location = new System.Drawing.Point(158, 165);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(212, 26);
            this.textBox6.TabIndex = 24;
            this.textBox6.Text = "192.168.1.1";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button23.Location = new System.Drawing.Point(15, 163);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(120, 29);
            this.button23.TabIndex = 23;
            this.button23.Text = "굴뚝코드";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // tb7
            // 
            this.tb7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb7.Location = new System.Drawing.Point(158, 197);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(212, 26);
            this.tb7.TabIndex = 26;
            this.tb7.Text = "점검중";
            this.tb7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button24.Location = new System.Drawing.Point(15, 195);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(120, 29);
            this.button24.TabIndex = 25;
            this.button24.Text = "점검";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_setup_nework);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_view_nework);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_view_io);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "IO제어";
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.panel_menu.ResumeLayout(false);
            this.panel_view_nework.ResumeLayout(false);
            this.panel_view_nework.PerformLayout();
            this.panel_view_io.ResumeLayout(false);
            this.panel_view_io.PerformLayout();
            this.panel_setup_nework.ResumeLayout(false);
            this.panel_setup_nework.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Timer timer_1s;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_CLOSE;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btn_SetupNetwork;
        private System.Windows.Forms.Panel panel_view_nework;
        private System.Windows.Forms.Panel panel_view_io;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox tb_gateway_setup;
        private System.Windows.Forms.TextBox tb_subnet_setup;
        private System.Windows.Forms.TextBox tb_IPAddress_setup;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.Button button52;
        private System.Windows.Forms.Button button53;
        private System.Windows.Forms.Button button54;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_KeySave;
        private System.Windows.Forms.Button btn_KeyDel;
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
    }
}

