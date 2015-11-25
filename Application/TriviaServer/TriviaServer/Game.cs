﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TriviaServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Game : IGame
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
        bool checkPlayers();

        /// <summary>
        /// It sends the unique id to the client.
        /// </summary>
        [OperationContract]
        void sendId();

        /// <summary>
        /// It starts the game after the check is complete.
        /// </summary>
        [OperationContract]
        void startGame();

        /// <summary>
        /// It sends a question to a player.
        /// </summary>
        /// <param name="player_id">The player receiving the question.</param>
        /// <param name="question">The question to be asked.</param>
        [OperationContract]
        void sendQuestion(int player_id, Question question);

        /// <summary>
        /// It receives the answer the player has supplied.
        /// </summary>
        /// <param name="player_id">The player that supplied the answer.</param>
        /// <param name="answer">The number of the answer the player supplied.</param>
        [OperationContract]
        void receiveAnswer(int player_id, int answer);

        /// <summary>
        /// It checks which player wins.
        /// </summary>
        [OperationContract]
        void checkWinner();
    }
}