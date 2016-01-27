using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TriviaContract;

namespace TriviaContract
{
    [ServiceContract(Namespace = "TriviaContract")]
    public interface ILogin
    {
        /// <summary>
        /// It logs user in the lobby.
        /// </summary>
        /// <param name="username">Users username</param>
        /// <param name="password">Users password</param>
        /// <returns></returns>
        [OperationContract]
        int Login(string username, string password);
        /// <summary>
        /// It creates an account for the user.
        /// </summary>
        /// <param name="username">Users username</param>
        /// <param name="password">Users password</param>
        /// <param name="firstname">Users firstname</param>
        /// <returns></returns>
        [OperationContract]
        int CreateAnAccount(string username, string password, string firstname);
        /// <summary>
        /// It gives a list of online players only.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<string> ListOfOnlinePlayers();
        /// <summary>
        /// It gives a list of all players.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<string> ListOfAllPlayers();
        /// <summary>
        /// It gives players stats, like wins, loses, draws and rank.
        /// </summary>
        /// <param name="username">Users username</param>
        /// <returns></returns>
        [OperationContract]
        string PlayerStats(string username);

        [OperationContract]
        void PlayerOffline(string username, int offline);
    }
}
