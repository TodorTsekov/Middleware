using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaContract
{
    interface IChatCallback
    {
        /// <summary>
        /// It receives a message from the chat.
        /// </summary>
        /// <param name="id">The id of the player that sent the message.</param>
        /// <param name="message">The body of the message.</param>
        void getMessage(int id, string message);
    }
}
