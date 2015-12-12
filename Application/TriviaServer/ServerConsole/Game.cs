﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TriviaContract;

namespace TriviaContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Game : TriviaContract.IGame
    {
        int client_id;
        List<Player> list_players;

        public Game()
        {
            this.client_id = 0;
            this.list_players = new List<Player>();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        private Player search(int id)
        {
            foreach (Player p in list_players)
            {
                if (p.id == id)
                {
                    return p;
                }
            }
            throw new Exception("Player not found.");
        }

        public int setId()
        {
            client_id++;
            return client_id;
        }

        /// <summary>
        /// It starts the game after the check is complete.
        /// </summary>
        public void startGame()
        {
            return;
        }

        /// <summary>
        /// It sends a question to a player.
        /// </summary>
        public Question getQuestion()
        {
            Answer answer = new Answer(1, "George", true, "Todor", false, "Dolores", false);
            return new Question(1, "What's your name?", answer);
        }

        /// <summary>
        /// It receives the answer the player has supplied.
        /// </summary>
        /// <param name="player_id">The player that supplied the answer.</param>
        /// <param name="answer">The number of the answer the player supplied.</param>
        public void setAnswer(int playerId, int answer)
        {
            return;
        }

        /// <summary>
        /// It sets that a player is ready to start a game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void setReady(int playerId)
        {
            list_players.Add(new Player(playerId));
            if (list_players.Count() == 2)
            {
                foreach (Player p in list_players)
                {
                    p.callback = OperationContext.Current.GetCallbackChannel<IGameCallback>();
                    p.callback.startGameInClient(p.id);
                }
            }
        }

        /// <summary>
        /// It indicates that a player wants to leave the game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void leave(int playerId)
        {
            return;
        }

        /// <summary>
        /// It indicates that a player wants to leave the game.
        /// </summary>
        /// <param name="playerId">The id of the player.</param>
        public void restart(int playerId)
        {
            return;
        }
    }
}
