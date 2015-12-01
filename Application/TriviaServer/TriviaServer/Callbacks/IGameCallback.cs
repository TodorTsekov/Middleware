using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaServer
{
    interface IGameCallback
    {
        /// <summary>
        /// It sets the unique id on the client.
        /// </summary>
        void setId();

        /// <summary>
        /// It notifies the client that the game starts.
        /// </summary>
        void startGame();
    }
}
