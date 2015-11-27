using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TriviaContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace="TriviaContract")]
    public interface IGame
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        /// <summary>
        /// It checks if all players are connected and the game is ready to start.
        /// </summary>
        /// <returns>True for succes, false for failure.</returns>
        [OperationContract]
        bool checkPlayers();

        /// <summary>
        /// It sends the unique id to the client.
        /// </summary>
        /// <returns>The unique id of the player.</returns>
        [OperationContract]
        int sendId();

        /// <summary>
        /// It starts the game after the check is complete.
        /// </summary>
        [OperationContract]
        void startGame();

        /// <summary>
        /// It sends a question to a player.
        /// </summary>
        /// <param name="player_id">The player receiving the question.</param>
        /// <param name="question">The question to be asked.</param>
        /// <returns>The next question to be asked.</returns>
        [OperationContract]
        Question sendQuestion(int player_id, Question question);

        /// <summary>
        /// It receives the answer the player has supplied.
        /// <param name="player_id">The player that supplied the answer.</param>
        /// <param name="answer">The number of the answer the player supplied.</param>
        /// </summary>
        [OperationContract]
        void receiveAnswer(int player_id, int answer);

        /// <summary>
        /// It checks which player wins.
        /// </summary>
        /// <returns>The id of the winner.</returns>
        [OperationContract]
        int checkWinner();
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
