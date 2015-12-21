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
    public partial class Register : Form
    {
        private OleDbConnection connection;
        string beginner = "beginner";
        public Register()
        {
            InitializeComponent();
            // This is for access to an ACCESS datadase
            String providerInfo = "Provider=Microsoft.ACE.OLEDB.12.0"; //for a accdb-database.

            String applicationPath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
            String databaseInfo = "Data Source=" + applicationPath + "/TriviaDatabase.accdb";

            String connectionInfo = providerInfo + ";" + databaseInfo;
            connection = new OleDbConnection(connectionInfo);
        }

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            try {
                connection.Open();
                OleDbCommand existcommand = new OleDbCommand();
                existcommand.Connection = connection;
                existcommand.CommandText = "select * from user_info where username='" + tb_username.Text + "'";
                OleDbDataReader reader = existcommand.ExecuteReader();
                bool exist = false;
                while (reader.Read())
                {
                    exist=true;
                }
                if (exist == true)
                {
                    MessageBox.Show("The username already exists.Pick another one.");
                    connection.Close();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into user_info([username],[password],[firstname],[rank]) values('" + tb_username.Text + "','" + tb_password.Text + "','" + tb_firstname.Text + "', '" + beginner + "')";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Your account is created.");
                    connection.Close();

                    this.Close();
                }
                 
            }
            catch(Exception ex)
            {
                MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
        }
    }
}
