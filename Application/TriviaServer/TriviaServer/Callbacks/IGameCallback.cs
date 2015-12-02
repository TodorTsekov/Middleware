using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace TriviaContract
{
    interface IGameCallback
    {
        /// <summary>
        /// It sets the unique id on the client.
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void setId();

        /// <summary>
        /// It notifies the client that the game starts.
        /// </summary>
        [OperationContract(IsOneWay = true)]
        void startGameInClient();
    }
}
