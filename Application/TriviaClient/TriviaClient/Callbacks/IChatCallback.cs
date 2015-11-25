using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaClient.Callbacks
{
    interface IChatCallback
    {
        /// <summary>
        /// It receives a chat message from the server.
        /// </summary>
        /// <param name="message">The body of the message.</param>
        public void receiveMessage(string message);

        /// <summary>
        /// It sends the player's message to the server.
        /// </summary>
        /// <param name="player_id">The id of the player sending the message.</param>
        /// <param name="message">The body of the message.</param>
        /// <returns></returns>
        public string sendMessage(int player_id, string message);
    }
}
