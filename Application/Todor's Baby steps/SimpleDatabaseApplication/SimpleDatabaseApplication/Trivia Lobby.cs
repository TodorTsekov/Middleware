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
    public partial class Trivia_Lobby : Form
    {
        private OleDbConnection connection;
        public Trivia_Lobby()
        {
            InitializeComponent();
            // This is for access to an ACCESS datadase
            String providerInfo = "Provider=Microsoft.ACE.OLEDB.12.0"; //for a accdb-database.

            String applicationPath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
            String databaseInfo = "Data Source=" + applicationPath + "/TriviaDatabase.accdb";

            String connectionInfo = providerInfo + ";" + databaseInfo;
            connection = new OleDbConnection(connectionInfo);
        }


    }
}
