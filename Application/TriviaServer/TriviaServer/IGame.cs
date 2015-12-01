using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TriviaContract.Utilities;

namespace TriviaContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace="TriviaContract", CallbackContract=typeof(IGameCallback))]
    [ServiceKnownType(typeof(Answer))]
    [ServiceKnownType(typeof(Question))]
    [ServiceKnownType(typeof(Player))]
    public interface IGame
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        
        /// <summary>
        /// It starts the game after the check is complete. The check of players is done here.
        /// </summary>
        [OperationContract]
        void startGame();

        /// <summary>
        /// It sends a question to a player.
        /// </summary>
        /// <returns>The next question to be asked.</returns>
        [OperationContract]
        Question getQuestion();

        /// <summary>
        /// It sets that a player is ready to start a game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        [OperationContract]
        void setReady(int playerId);

        /// <summary>
        /// It sends the answer of a player to the server. The check of the answer is done here.
        /// </summary>
        /// <param name="playerId">The id of the player that sent the answer.</param>
        /// <param name="answer">The id of the answer.</param>
        [OperationContract]
        void setAnswer(int playerId, int answer);

        /// <summary>
        /// It indicates that a player wants to leave the game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        [OperationContract]
        void leave(int playerId);

        /// <summary>
        /// It indicates that a player wants to leave the game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        [OperationContract]
        void restart(int playerId);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "TriviaServer.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
