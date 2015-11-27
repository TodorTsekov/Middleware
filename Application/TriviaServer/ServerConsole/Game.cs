using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TriviaContract;

namespace TriviaContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Game : TriviaContract.IGame
    {
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

        /// <summary>
        /// It checks if all players are connected and the game is ready to start.
        /// </summary>
        /// <returns>True for succes, false for failure.</returns>
        [OperationContract]
        public bool checkPlayers()
        {
            return false;
        }

        /// <summary>
        /// It sends the unique id to the client.
        /// </summary>
        [OperationContract]
        public int sendId()
        {
            return 0;
        }

        /// <summary>
        /// It starts the game after the check is complete.
        /// </summary>
        [OperationContract]
        public void startGame()
        {
            return;
        }

        /// <summary>
        /// It sends a question to a player.
        /// </summary>
        /// <param name="player_id">The player receiving the question.</param>
        /// <param name="question">The question to be asked.</param>
        [OperationContract]
        public Question sendQuestion(int player_id, Question question)
        {
            return new Question();
        }

        /// <summary>
        /// It receives the answer the player has supplied.
        /// </summary>
        /// <param name="player_id">The player that supplied the answer.</param>
        /// <param name="answer">The number of the answer the player supplied.</param>
        [OperationContract]
        public void receiveAnswer(int player_id, int answer)
        {
            return;
        }

        /// <summary>
        /// It checks which player wins.
        /// </summary>
        [OperationContract]
        public int checkWinner()
        {
            return 0;
        }
    }
}
