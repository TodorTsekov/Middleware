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

namespace SimpleDatabaseApplication
{
    public partial class Form1 : Form
    {
        private DataHandler dh;
       
        public Form1()
        {
            InitializeComponent();
            dh = new DataHandler();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try {
          
//                OleDbConnection connection = new OleDbConnection();
//                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\todor\Documents\GitHub\Middleware\Application\Todor's Baby steps\TriviaDatabase.accdb;
//Persist Security Info=False;";
            //    connection.Open();
            //    lb_checkConnection.Text = "Connection Successful";
            //    connection.Close();
            //}
            //catch(Exception dbex)
            //{
            //    MessageBox.Show("We are sorry.You cannot connect to the database."+dbex);
            //}
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            int temp = dh.LogIn(tb_username.Text,tb_password.Text);
            if (temp==1)
            {
                this.Close();
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
    }
}
