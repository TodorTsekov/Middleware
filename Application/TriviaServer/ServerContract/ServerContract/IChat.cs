using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using TriviaContract;

namespace TriviaContract
{
    [ServiceContract(Namespace = "TriviaContract", CallbackContract = typeof(IChatCallback))]
    public interface IChat
    {
        /// <summary>
        /// It sends a player's message to the server.
        /// </summary>
        /// <param name="player_id">The player that send the message.</param>
        /// <param name="message">The message that was sent.</param>
        void sendMessage(int player_id, string message);
    }
}
