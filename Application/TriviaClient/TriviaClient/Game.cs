using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using TriviaClient.TriviaServer;

namespace TriviaClient
{
    public class Game : IGameCallback
    {
        public int id;

        /// <summary>
        /// It sets the unique id on the client.
        /// </summary>
        public void setId()
        {
            return;
        }

        /// <summary>
        /// It notifies the client that the game starts.
        /// </summary>
        public void startGameInClient(int id)
        {
            Trivia t = new Trivia(id);
            t.Show();
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
