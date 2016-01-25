﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TriviaClient.TriviaServer;
using System.Windows.Forms;

namespace TriviaClient
{
    public class Game : IGameCallback
    {
        /// <summary>
        /// It notifies the client that the game starts.
        /// </summary>
        public void startGameInClient(int id)
        {
            Trivia t = new Trivia(id);
            t.Show();
        }

        public void results(int score, string message)
        {
            MessageBox.Show("You " + message + " the game. Your score: " + score.ToString());
        }

        /// <summary>
        /// It receives a message from the chat.
        /// </summary>
        /// <param name="id">The id of the player that sent the message.</param>
        /// <param name="message">The body of the message.</param>
        public void getMessage(int id, string message)
        {
            return;
        }
    }
}
