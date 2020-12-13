using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOBoard
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Size = new Size(480, 320);
            panel_setup_nework.Location = new Point(0, 55);
            panel_view_nework.Location = new Point(0, 55);
            panel_view_io.Location = new Point(0, 55);
            panel_menu.Location = new Point(0, 55);

            panel_menu.Visible = false;
            panel_view_nework.Visible = false;
            panel_setup_nework.Visible = false;
            panel_view_io.Visible = true;


            ManagementClass MC = new ManagementClass("Win32_NetworkAdapterConfiguration"); ManagementObjectCollection MOC = MC.GetInstances(); foreach (ManagementObject MO in MOC)
            {
                if (MO["IPAddress"] != null)
                {
                    if (MO["IPAddress"] is Array)
                    { 
                        string[] addresses = (string[])MO["IPAddress"];
                        string[] subnets = (string[])MO["IPSubnet"];
                        string[] gateways = (string[])MO["DefaultIPGateway"];

                        if (addresses != null && subnets != null && gateways != null)
                        {
                            tb_IPAddress_setup.Text = addresses[0];
                            tb_subnet_setup.Text = subnets[0];
                            tb_gateway_setup.Text = gateways[0];
                        }
                    }
                }
            }



        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_1s_Tick(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (panel_menu.Visible == false)
            {
                panel_menu.Visible = true;
                panel_view_nework.Visible = false;
                panel_setup_nework.Visible = false;
            }
            else
            {
                panel_menu.Visible = false;
                panel_view_nework.Visible = false;
                panel_setup_nework.Visible = false;
            }

        }

        private void Btn_SetupNetwork_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_view_nework.Visible = false;
            panel_setup_nework.Visible = true;
        }

        private void Btn_ViewNetwork_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = false;
            panel_view_nework.Visible = true;
            panel_setup_nework.Visible = false;
        }

        private void Btn_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        TextBox btnSelectedTextBox = new TextBox();
        private void Tb_IPAddress_setup_MouseDown(object sender, MouseEventArgs e)
        {
            tb_IPAddress_setup.Text = "";
            btnSelectedTextBox = tb_IPAddress_setup;
        }

        private void Tb_subnet_setup_MouseDown(object sender, MouseEventArgs e)
        {
            tb_subnet_setup.Text = "";
            btnSelectedTextBox = tb_subnet_setup;
        }

        private void Tb_gateway_setup_MouseDown(object sender, MouseEventArgs e)
        {
            tb_gateway_setup.Text = "";
            btnSelectedTextBox = tb_gateway_setup;
        }

        private void Btn_Key_Clicked(object sender, EventArgs e)
        {
            Button[] numKey = { btn_Key0, btn_Key1, btn_Key2, btn_Key3, btn_Key4, btn_Key5, btn_Key6, btn_Key7, btn_Key8, btn_Key9, btn_KeyComma, btn_KeyEnter };

            for(int keyIndex = 0; keyIndex < (numKey.Length - 2); keyIndex++)
            {
                if (sender.Equals(numKey[keyIndex]) == true)
                {
                    btnSelectedTextBox.Text += numKey[keyIndex].Text;
                }
            }

            if (sender.Equals(numKey[10]) == true)
            {
                btnSelectedTextBox.Text += numKey[10].Text;
            }
        }
    }
}
