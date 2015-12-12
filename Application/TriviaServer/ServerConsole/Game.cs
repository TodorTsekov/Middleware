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
    public class Game : TriviaContract.IGame
    {
        int client_id;
        List<Player> list_players;
        List<Question> list_question;

        public Game()
        {
            this.client_id = 0;
            this.list_players = new List<Player>();
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

        public int setId()
        {
            client_id++;
            return client_id;
        }

        /// <summary>
        /// It starts the game after the check is complete.
        /// </summary>
        public void startGame()
        {
            return;
        }

        /// <summary>
        /// It sends a question to a player.
        /// </summary>
        public Question getQuestion()
        {
            Answer answer = new Answer(1, "George", true, "Todor", false, "Dolores", false);
            return new Question(1, "What's your name?", answer);

        }

        /// <summary>
        /// It receives the answer the player has supplied.
        /// </summary>
        /// <param name="player_id">The player that supplied the answer.</param>
        /// <param name="answer">The number of the answer the player supplied.</param>
        public void setAnswer(int playerId, int answer)
        {
            return;
        }

        /// <summary>
        /// It sets that a player is ready to start a game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void setReady(int playerId)
        {
            list_players.Add(new Player(playerId));
            Console.WriteLine("Player " + playerId.ToString() + " connected.");
            if (list_players.Count() == 2)
            {
                foreach (Player p in list_players)
                {
                    p.callback = OperationContext.Current.GetCallbackChannel<IGameCallback>();
                    p.callback.startGameInClient(p.id);
                }
            }
        }

        /// <summary>
        /// It indicates that a player wants to leave the game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void leave(int playerId)
        {
            return;
        }

        /// <summary>
        /// It indicates that a player wants to leave the game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void restart(int playerId)
        {
            return;
        }
    }
}
