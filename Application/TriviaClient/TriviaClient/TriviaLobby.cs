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
    public partial class TriviaLobby : Form
    {
        GameClient proxy;
        static Game callback;
        static InstanceContext ctx;
        static int global_id;

        private DataHandler dh;
        List<string> playerslist = new List<string>();
        //LoginClient proxy;

        string user;
        string stats;
        public TriviaLobby(string username)
        {
            InitializeComponent();
            callback = new Game();
            ctx = new InstanceContext(callback);
            proxy = new GameClient(ctx);
            global_id = proxy.setId();

            dh = new DataHandler();
            //we pass the username from form1 to this form
            user = username;
            //proxy = new LoginClient();
        }

        private void Trivia_Lobby_Load(object sender, EventArgs e)
        {
            try
            {
                // here you load the players stats
                stats = proxy.PlayerStats(user);
                //lb_hello.Text = "Hello, " + stats.Substring(0,5);
                string[] temp = stats.Split(',');
                lb_hello.Text = "Hello, " + temp.ElementAt(0);
                lb_wins.Text = "Wins: " + temp.ElementAt(1);
                lb_draws.Text = "Draws: " + temp.ElementAt(2);
                lb_loses.Text = "Loses: " + temp.ElementAt(3);
                lb_rank.Text = "Rank: " + temp.ElementAt(4);

                //here you load the list of players
                lb_users.Items.Clear();
                playerslist = proxy.ListOfAllPlayers().ToList();
                foreach (string player in playerslist)
                {
                    lb_users.Items.Add(player);
                }


                //lb_users.Items.Add(reader["username"].ToString() +"  "+reader["rank"].ToString()+ "  " + reader["online"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }

        }

        private void cb_playersonline_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_playersonline.Checked == true)
                {
                    playerslist.Clear();
                    lb_users.Items.Clear();
                    playerslist = proxy.ListOfOnlinePlayers().ToList();
                    foreach (string player in playerslist)
                    {
                        lb_users.Items.Add(player);
                    }
                }
                else
                {
                    lb_users.Items.Clear();
                    playerslist = proxy.ListOfAllPlayers().ToList();
                    foreach (string player in playerslist)
                    {
                        lb_users.Items.Add(player);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("We are sorry.Something went wrong with the database." + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proxy.setReady(global_id);
        }
    }
}
