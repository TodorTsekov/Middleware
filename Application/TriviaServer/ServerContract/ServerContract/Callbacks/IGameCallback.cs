using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace TriviaContract
{
    public interface IGameCallback
    {
        /// <summary>
        /// It notifies the client when the game starts.
        /// </summary>
        /// <param name="id">The id of the player.</param>
        [OperationContract(IsOneWay = true)]
        void startGameInClient(int id);

        /// <summary>
        /// It presents the results to the player.
        /// </summary>
        /// <param name="score">The score of the player.</param>
        /// <param name="message">Win/lose/draw message.</param>
        [OperationContract(IsOneWay = true)]
        void results(int playerId, int score, string message);
    }
}
