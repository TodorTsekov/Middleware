using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaServer
{
    public interface IChat
    {
        /// <summary>
        /// It receives a message and forwards it to other players.
        /// </summary>
        /// <param name="player_id">The player that send the message.</param>
        /// <param name="message">The message that was sent.</param>
        void receiveMessage(int player_id, string message);
    }
}
