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
        private OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
            // This is for access to an ACCESS datadase
            String providerInfo = "Provider=Microsoft.ACE.OLEDB.12.0"; //for a accdb-database.

            String applicationPath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
            String databaseInfo = "Data Source=" + applicationPath + "/TriviaDatabase.accdb";

            String connectionInfo = providerInfo + ";" + databaseInfo;
            connection = new OleDbConnection(connectionInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
          
//                OleDbConnection connection = new OleDbConnection();
//                connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\todor\Documents\GitHub\Middleware\Application\Todor's Baby steps\TriviaDatabase.accdb;
//Persist Security Info=False;";
                connection.Open();
                lb_checkConnection.Text = "Connection Successful";
                connection.Close();
            }
            catch(Exception dbex)
            {
                MessageBox.Show("We are sorry.You cannot connect to the database."+dbex);
            }
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from user_info where username='"+tb_username.Text+"' and password='"+tb_password.Text+"'";
            OleDbDataReader reader= command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count==1)
            {
                MessageBox.Show("Username and password are correct.");
                connection.Close();
                //connection.Dispose();
                //bool online = true;
                connection.Open();
                OleDbCommand onlinecommand = new OleDbCommand();
                onlinecommand.Connection = connection;

                // -1 = to true in Access database.
                onlinecommand.CommandText = "update user_info set online='" + -1 + "' where username='"+tb_username.Text+"'";

                onlinecommand.ExecuteNonQuery();
                connection.Close();
                
                Trivia_Lobby t_lobby = new Trivia_Lobby();
                t_lobby.ShowDialog();
                this.Close();
            }
            else if (count > 1)
            {
                MessageBox.Show("The Username and password are existing twice.");
            }
           else
            {
                MessageBox.Show("Username and password are not correct.Or there is no such user in our system.");
            }
            connection.Close();
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
