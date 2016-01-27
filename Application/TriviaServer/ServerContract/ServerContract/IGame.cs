using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TriviaContract;

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
        /// Sets the id of each client.
        /// </summary>
        /// <returns>The id of the player.</returns>
        [OperationContract]
        int setId();

        /// <summary>
        /// It starts the game after the check is complete.
        /// </summary>
        /// <param name="player1">Id of the 1st player.</param>
        /// <param name="player2">Id of the 2nd player.</param>
        [OperationContract]
        void startGame(int player1, int player2);

        /// <summary>
        /// Gets the result to the player.
        /// </summary>
        /// <param name="player_id">The player's id requesting the result.</param>
        [OperationContract]
        void getResult(int player_id);

        /// <summary>
        /// It sends a question to a player.
        /// </summary>
        /// <param name="counter">The id of the question.</param>
        /// <param name="player_id">The id of the player asking.</param>
        /// <returns>The question with the possible answers.</returns>
        [OperationContract]
        Question getQuestion(int counter, int player_id);

        /// <summary>
        /// It sets if a player is ready. He is added to player list.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        [OperationContract]
        void setReady(int playerId);

        /// <summary>
        /// It receives the answer the player has supplied.
        /// </summary>
        /// <param name="playerId">The id of the player that gave the answer.</param>
        /// <param name="questionId">The id of the question.</param>
        /// <param name="answer">The id of question's answer.</param>
        [OperationContract]
        void setAnswer(int playerId, int questionId, int answer);

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
