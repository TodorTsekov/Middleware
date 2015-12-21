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

        private void Trivia_Lobby_Load(object sender, EventArgs e)
        {
            try
            {
                if (rb_allplr.Checked)
                {

                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "select username, rank, online from user_info";

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["online"].ToString() == "False")
                        {
                            lb_users.Items.Add(reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "offline");
                        }
                        else
                        {
                            lb_users.Items.Add(reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "online");
                        }
                        //lb_users.Items.Add(reader["username"].ToString() +"  "+reader["rank"].ToString()+ "  " + reader["online"].ToString());
                    }
                }
                else
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "select username, rank, online from user_info";

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader["online"].ToString() == "True")
                        {
                            lb_users.Items.Add(reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "online");
                        }
                        
                    }
                }
                connection.Close();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }

        }
        }
    }

