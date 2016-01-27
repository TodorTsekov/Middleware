using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SimpleDatabaseApplication
{

    class DataHandler
    {
        private OleDbConnection connection;
        string player;
        List<string> playerslist = new List<string>();
        public string stats;
        public DataHandler()
        {
            // This is for access to an ACCESS datadase
            String providerInfo = "Provider=Microsoft.ACE.OLEDB.12.0"; //for a accdb-database.

            String applicationPath = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
            String databaseInfo = "Data Source=" + applicationPath + "/TriviaDatabase.accdb";

            String connectionInfo = providerInfo + ";" + databaseInfo;
            connection = new OleDbConnection(connectionInfo);
        }


    public int LogIn(string username, string password)
    {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from user_info where username='" + username+ "' and password='" + password + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Username and password are correct.");
                connection.Close();
                //connection.Dispose();
                //bool online = true;
                connection.Open();
                OleDbCommand onlinecommand = new OleDbCommand();
                onlinecommand.Connection = connection;

                // we pass 1 to indicate that the player is online in Access database.
                onlinecommand.CommandText = "update user_info set online='" + 1 + "' where username='" + username + "'";

                onlinecommand.ExecuteNonQuery();
                connection.Close();
                
                Trivia_Lobby t_lobby = new Trivia_Lobby(username);
                t_lobby.ShowDialog();
                //this.Close();
                return 1;
            }
            else
            {
                MessageBox.Show("Username and password are not correct.Or there is no such user in our system.");
                connection.Close();
            }

            return count;
        }

    public List<string> ListOfOnlinePlayers ()
        {
            playerslist.Clear();
            //int check = 1;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //it says there is a data mismach and I think I have passed the variables correctly
                //command.CommandText = "select username, rank, online from user_info where online='" +check+"'";

                //for now I will do it like this, I will try to fix it later on
                command.CommandText = "select username, rank, online from user_info";

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["online"].ToString() != "0")
                        player = reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "online";
                    playerslist.Add(player);

                }
            
            connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
            return playerslist;
        }

    public int CreateAnAccount(string username,string password,string firstname)
    {
            string beginner = "beginner";
            try
            {
                connection.Open();
                OleDbCommand existcommand = new OleDbCommand();
                existcommand.Connection = connection;
                existcommand.CommandText = "select * from user_info where username='" + username + "'";
                OleDbDataReader reader = existcommand.ExecuteReader();
                bool exist = false;
                while (reader.Read())
                {
                    exist = true;
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
                    command.CommandText = "insert into user_info([username],[password],[firstname],[rank]) values('" + username + "','" + password + "','" + firstname + "', '" + beginner + "')";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Your account is created.");
                    connection.Close();

                    //this.Close();
                    return 1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
            return 0;
        }

    public List<string> ListOfAllPlayers()
        {
            try
            {
                
                playerslist.Clear();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select username, rank, online from user_info";

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["online"].ToString() == "0")
                    {
                        player = reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "offline";
                        playerslist.Add(player);
                        
                        //lb_users.Items.Add(reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "offline");
                    }
                    else
                    {
                        player = reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "online";
                        playerslist.Add(player);
                        
                        //lb_users.Items.Add(reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "online");
                    }
                    //lb_users.Items.Add(reader["username"].ToString() +"  "+reader["rank"].ToString()+ "  " + reader["online"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
            return playerslist;
        }

    public string PlayerStats(string username)
        {
           
            try
            {
                //string test = "tt11";
                connection.Open();
                OleDbCommand statscommand = new OleDbCommand();
                statscommand.Connection = connection;
                statscommand.CommandText = "select firstname, wins, draws, loses, rank from user_info where username='" + username + "'";

                OleDbDataReader stastsreader = statscommand.ExecuteReader();
                while (stastsreader.Read())
                {
                    stats = stastsreader["firstname"].ToString() +","+ stastsreader["wins"].ToString() + "," + stastsreader["draws"].ToString() + "," + stastsreader["loses"].ToString() + "," + stastsreader["rank"].ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
            return stats;
        }
}
}
