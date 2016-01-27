using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using SimpleDatabaseApplication.ServiceReference1;
using System.ServiceModel;
using System.Runtime.InteropServices;
using SimpleDatabaseApplication.Properties;

namespace SimpleDatabaseApplication
{
    public partial class Form1 : Form
    {
        private DataHandler dh;
        LoginClient proxy;

        public Form1()
        {
            InitializeComponent();
            dh = new DataHandler();
            proxy = new LoginClient();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but_login_Click(object sender, EventArgs e)
        {
            int temp = proxy.Login(tb_username.Text,tb_password.Text);
            if (temp==1)
            {
                MessageBox.Show("Username and password are correct.");
                //bool online = true;

                Trivia_Lobby t_lobby = new Trivia_Lobby(tb_username.Text);
                t_lobby.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username and password are not correct.Or there is no such user in our system.");
            }

        }

        private void llb_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            register = null;
            Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                proxy.PlayerOffline(tb_username.Text, 1);
        }
    }
}
