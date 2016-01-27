using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TriviaContract;
using System.Dynamic;

namespace TriviaContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Game : TriviaContract.IGame, TriviaContract.ILogin
    {
        int client_id;
        int question_counter;
        int[,] games_array; 
        List<Player> list_players;
        List<Question> list_question;
        //login
        DataHelper dataHelper;
       
        List<string> playerslist = new List<string>();

        public Game()
        {
            this.client_id = 0;
            this.question_counter = 1;
            games_array = new int[10, 2];
            for (int i = 0; i < games_array.GetLength(0); i++)
            {
                for (int j = 0; j < games_array.GetLength(1); j++)
                {
                    games_array.SetValue(0, i, j);
                }
            }
            this.list_players = new List<Player>();
            populate();
            //login
            dataHelper = new DataHelper();
        }

        private void populate()
        {
            list_question = new List<Question>(5);
            Answer answer = new Answer(1, "September 1939", true, "August 1939", false, "October 1939", false);
            Question question = new Question(1, "When was 2nd world war started?", answer);
            list_question.Add(question);

            answer = new Answer(2, "Behavior of human beings", false, "Insects", true, "The formation of rocks", false);
            question = new Question(2, "Entomology is the science that studies: ", answer);
            list_question.Add(question);

            answer = new Answer(3, "Tennis", false, "Cricket", false, "Volleyball", true);
            question = new Question(3, "Federation Cup, World Cup, Allywyn International Trophy and Challenge Cup are awarded to winners of:",
                answer);
            list_question.Add(question);

            answer = new Answer(4, "resistance power increases", false, "the infrared light kills bacteria in the body", false,
                "the ultraviolet rays convert skin oil into Vitamin D", true);
            question = new Question(4, "Exposure to sunlight helps a person improve his health because:", answer);
            list_question.Add(question);

            answer = new Answer(5, "by wind erosion", false, "of its mineral content", true, "by water erosion", false);
            question = new Question(5, "The chief purpose of crop rotation is to check the loss of top soil", answer);
            list_question.Add(question);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private Player search(int id)
        {
            foreach (Player p in list_players)
            {
                if (p.id == id)
                {
                    return p;
                }
            }
            throw new Exception("Player not found.");
        }

        /// <summary>
        /// Sets the id of each client.
        /// </summary>
        /// <returns>The id of the player.</returns>
        public int setId()
        {
            client_id++;
            return client_id;
        }

        /// <summary>
        /// It starts the game after the check is complete.
        /// </summary>
        /// <param name="player1">Id of the 1st player.</param>
        /// <param name="player2">Id of the 2nd player.</param>
        public void startGame(int player1, int player2)
        {
            Player p = search(player1);
            p.callback = OperationContext.Current.GetCallbackChannel<IGameCallback>();
            p.callback.startGameInClient(p.id);
            p = null;
            p = search(player2);
            p.callback = OperationContext.Current.GetCallbackChannel<IGameCallback>();
            p.callback.startGameInClient(p.id);

            Console.WriteLine("Players {0} and {1} have started a game.", player1.ToString(), player2.ToString());
        }

        /// <summary>
        /// Gets the result to the player.
        /// </summary>
        /// <param name="player_id">The player's id requesting the result.</param>
        public void getResult(int player_id)
        {
            Player p1 = search(player_id);
            Player p2 = null;
            int temp_p1=0;
            int temp_p2=0;
            //find this player's opponent
            for (int i = 0; i < games_array.GetLength(0); i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (games_array[i, j] == player_id)
                    {
                        if (j == 0)
                        {
                            p2 = search(games_array[i, 1]);
                            break;
                        }
                        else
                        {
                            p2 = search(games_array[i, 0]);
                            break;
                        }
                    }
                }
                if (p1 != null && p2 != null)
                {
                    break;
                }
            }

            //count score of this player
            for (int x = 0; x < p1.ar_player_answers.GetLength(0); x++)
            {
                if (p1.ar_player_answers[x] == true)
                {
                    temp_p1 += 10;
                }
            }
            //count score of other player
            for (int x = 0; x < p2.ar_player_answers.GetLength(0); x++)
            {
                if (p2.ar_player_answers[x] == true)
                {
                    temp_p2 += 10;
                }
            }

            //delicer the reults
            p1.callback = OperationContext.Current.GetCallbackChannel<IGameCallback>();
            p2.callback = OperationContext.Current.GetCallbackChannel<IGameCallback>();
            if (temp_p1 > temp_p2)
            {
                p1.callback.results(p1.id, temp_p1, "win");
                p2.callback.results(p2.id, temp_p2, "lost");
            }
            else if (temp_p1 < temp_p2)
            {
                p1.callback.results(p1.id, temp_p1, "lost");
                p2.callback.results(p2.id, temp_p2, "win");
            }
            else
            {
                p1.callback.results(p1.id, temp_p1, "draw");
                p2.callback.results(p2.id, temp_p2, "draw");
            }
        }

        /// <summary>
        /// It sends a question to a player.
        /// </summary>
        /// <param name="counter">The id of the question.</param>
        /// <param name="player_id">The id of the player asking.</param>
        /// <returns>The question with the possible answers.</returns>
        public Question getQuestion(int counter, int player_id)
        {
            Question question = list_question.Find(q => q.id == counter);
            if (question == null)
            {
                getResult(player_id);
            }
            return question;
        }

        /// <summary>
        /// It receives the answer the player has supplied.
        /// </summary>
        /// <param name="playerId">The id of the player that gave the answer.</param>
        /// <param name="questionId">The id of the question.</param>
        /// <param name="answer">The id of question's answer.</param>
        public void setAnswer(int playerId, int questionId, int answer)
        {
            Player player = list_players.Find(p => p.id == playerId);
            Question question = list_question.Find(q => q.id == questionId);
            player.addAnswer(question.answer.ar_results[answer]);
            Console.WriteLine("Question: " + question.questionText);
            Console.WriteLine("Player " + playerId.ToString() + " answered " + question.answer.ar_question_answers[answer]);
            Console.WriteLine("Which is " + question.answer.ar_results[answer].ToString());

        }

        /// <summary>
        /// It sets if a player is ready. He is added to player list.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void setReady(int playerId)
        {
            list_players.Add(new Player(playerId));
            Console.WriteLine("Player " + playerId.ToString() + " connected.");
            int c = 0;
            bool done = false;
            //for every element of the game_array
            while (c < games_array.GetLength(0) && done == false)
            {
                for (int j = 0; j < 2; j++)
                {
                    //if there is no player number on cell
                    if (games_array[c, j] == 0)
                    {
                        //put player number
                        games_array[c, j] = playerId;
                        done = true;
                        break;
                    }
                }
                c++;
            }
            for (int i = 0; i < games_array.GetLength(0); i++)
            {
                //if both columns in a row have player numbers, start a game
                if (games_array[i, 0] != 0 && games_array[i, 1] != 0)
                {
                    this.startGame(games_array[i, 0], games_array[i, 1]);
                    break;
                }
            }
        }

        /// <summary>
        /// It indicates that a player wants to leave the game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void leave(int playerId)
        {
            Player p = search(playerId);
            if (p != null)
            {
                list_players.Remove(p);
                for (int i = 0; i < games_array.GetLength(0); i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (games_array[i, j] == playerId)
                        {
                            games_array[i, j] = 0;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// It indicates that a player wants to leave the game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void restart(int playerId)
        {
            return;
        }

        //Login

        public int Login(string username, string pass)
        {
            int temp;
            temp = dataHelper.LogIn(username, pass);
            return temp;
        }


        public int CreateAnAccount(string username, string password, string firstname)
        {
            int temp;
            temp = dataHelper.CreateAnAccount(username, password, firstname);
            return temp;
        }

        public List<string> ListOfOnlinePlayers()
        {
            playerslist = dataHelper.ListOfOnlinePlayers();
            return playerslist;
        }

        public List<string> ListOfAllPlayers()
        {
            playerslist = dataHelper.ListOfAllPlayers();
            return playerslist;
        }

        public string PlayerStats(string username)
        {
            string temp;
            temp = dataHelper.PlayerStats(username);
            return temp;
        }

        public void PlayerOffline(string username, int offline)
        {
            dataHelper.PlayerOffline(username, offline);
        }
    }
}
