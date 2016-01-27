using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaClient.TriviaServer;
using System.ServiceModel;
using System.Runtime.InteropServices;
using TriviaClient.Properties;

namespace TriviaClient
{
    public partial class Login : Form
    {
        private DataHelper dh;
        
        LoginClient proxy;

        public Login()
        {
            InitializeComponent();
            dh = new DataHandler();
            proxy = new LoginClient();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            int temp = proxy.Login(tb_username.Text, tb_password.Text);
            if (temp == 1)
            {
                MessageBox.Show("Username and password are correct.");
                //bool online = true;

                TriviaLobby t_lobby = new TriviaLobby(tb_username.Text);
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
