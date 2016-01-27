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
    public partial class Register : Form
    {
        private DataHandler dh;
        LoginClient proxy;

        public Register()
        {
            InitializeComponent();
            dh = new DataHandler();
            proxy = new LoginClient();
        }

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            int temp = proxy.CreateAnAccount(tb_username.Text, tb_password.Text, tb_firstname.Text);
            if (temp == 1)
            {
                MessageBox.Show("Your account is created.");
                this.Close();
            }
            else
            {
                 MessageBox.Show("The username already exists.Pick another one.");
            }


        }
    }
}
