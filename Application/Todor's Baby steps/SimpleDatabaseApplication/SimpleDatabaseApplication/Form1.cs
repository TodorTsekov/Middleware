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
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {
                OleDbConnection connection;

        // This is for access to an ACCESS datadase
        String providerInfo = "Provider=Microsoft.ACE.OLEDB.12.0"; //for a accdb-database.

                String applicationPath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
                String databaseInfo = "Data Source=" + applicationPath + "/TriviaDatabase.accdb";

                //And if you use "|DataDirectory|":
                // path = "Data Source=|DataDirectory|/StudentsDBS.accdb";

                String connectionInfo = providerInfo + ";" + databaseInfo;
                connection = new OleDbConnection(connectionInfo);




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
    }
}
