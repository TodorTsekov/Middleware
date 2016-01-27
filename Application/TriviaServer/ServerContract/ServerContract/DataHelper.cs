using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using TriviaContract;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Dynamic;
using System.ServiceModel;

namespace TriviaContract
{

    [DataContract]
    public class DataHelper
    {
        string player;
        List<string> playerslist = new List<string>();
        public string stats;
        string connectionInfo = @"server=athena01.fhict.local;
                                  userid=dbi296402;
                                  password=Za2DpOn15p;
                                  database=dbi296402;
                                  Convert Zero Datetime = True;
                                  Allow Zero DateTime = True;";
        [DataMember]
        public MySqlConnection connection { get; set; }

        public DataHelper()
        {
            connection = new MySqlConnection(connectionInfo);

        }

        public int CreateAnAccount(string username, string password, string firstname)
        {
            string beginner = "beginner";
            int wins = 0;
            int draws = 0;
            int loses = 0;
            int online = 0;
            string sql = "INSERT INTO trivia_users (username,password,firstname,wins,draws,loses,online,rank) VALUES ('" + username + "','" + password + "','" + firstname + "', '" + wins + "', '" + draws + "', '" + loses + "', '" + online + "', '" + beginner + "')";
            string sql2 = "SELECT * FROM trivia_users WHERE username = '" + username + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlCommand command2 = new MySqlCommand(sql2, connection);
            try
            {
                connection.Open();
                //command2.ExecuteReader();
                MySqlDataReader reader = command2.ExecuteReader();
                bool exist = false;
                while (reader.Read())
                {
                    exist = true;
                }
                if (exist == true)
                {
                    // MessageBox.Show("The username already exists.Pick another one.");
                    connection.Close();
                    return 0;
                }
                else
                {
                    connection.Close();
                    connection.Open();

                    command.ExecuteNonQuery();
                    //MessageBox.Show("Your account is created.");
                    connection.Close();

                    //this.Close();
                    return 1;
                }

            }
            //catch (Exception ex)
            //{
            //    throw;
            //    //MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            //}
            finally { }
            return 0;


        }

        public int LogIn(string username, string password)
        {
            string sql = "SELECT * FROM trivia_users WHERE username='" + username + "' and password='" + password + "'";
            string sql2 = "UPDATE trivia_users SET online='" + 1 + "' where username='" + username + "'";
            // we pass 1 to indicate that the player is online.


            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlCommand command2 = new MySqlCommand(sql2, connection);
            connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                //MessageBox.Show("Username and password are correct.");
                connection.Close();
                //connection.Dispose();
                //bool online = true;
                connection.Open();

                command2.ExecuteNonQuery();
                connection.Close();

                //Trivia_Lobby t_lobby = new Trivia_Lobby(username);
                //t_lobby.ShowDialog();
                //this.Close();
                return 1;
            }
            else
            {
                //MessageBox.Show("Username and password are not correct.Or there is no such user in our system.");
                connection.Close();
            }

            return count;
        }

        public List<string> ListOfOnlinePlayers()
        {
            string sql = "SELECT username, rank, online FROM trivia_users";

            MySqlCommand command = new MySqlCommand(sql, connection);

            playerslist.Clear();
            //int check = 1;
            try
            {
                connection.Open();

                //it says there is a data mismach and I think I have passed the variables correctly
                //command.CommandText = "select username, rank, online from user_info where online='" +check+"'";

                //for now I will do it like this, I will try to fix it later on


                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["online"].ToString() != "0")
                    {
                        player = reader["username"].ToString() + "  " + reader["rank"].ToString() + "  " + "online";
                        playerslist.Add(player);
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
            return playerslist;
        }

        public List<string> ListOfAllPlayers()
        {
            string sql = "SELECT username, rank, online FROM trivia_users";

            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {

                playerslist.Clear();
                connection.Open();


                MySqlDataReader reader = command.ExecuteReader();
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
                throw;
                // MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
            return playerslist;
        }

        public string PlayerStats(string username)
        {
            string sql = "SELECT firstname, wins, draws, loses, rank FROM trivia_users WHERE username='" + username + "'";

            MySqlCommand command = new MySqlCommand(sql, connection);

            try
            {
                //string test = "tt11";
                connection.Open();

                MySqlDataReader stastsreader = command.ExecuteReader();
                while (stastsreader.Read())
                {
                    stats = stastsreader["firstname"].ToString() + "," + stastsreader["wins"].ToString() + "," + stastsreader["draws"].ToString() + "," + stastsreader["loses"].ToString() + "," + stastsreader["rank"].ToString();

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw;
                // MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
            return stats;
        }

        public void PlayerOffline(string username, int offline)
        {
            string sql = "UPDATE trivia_users SET online='" + 0 + "' where username='" + username + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();

            if (offline == 1)
            {
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
