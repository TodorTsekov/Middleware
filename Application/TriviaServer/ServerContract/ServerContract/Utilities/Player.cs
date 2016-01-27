using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaContract
{
    /// <summary>
    /// It declares a unique player and his answers so far.
    /// </summary>
    [Serializable]
    public class Player
    {
        public int id;
        private int counter;
        public bool[] ar_player_answers;
        public IGameCallback callback { get; set; }

        public Player()
        {
            this.counter = 0;
            this.ar_player_answers = new bool[5];
        }

        public Player(int id)
        {
            this.id = id;
            this.counter = 0;
            ar_player_answers = new bool[5];
        }

        public void addAnswer(bool result)
        {
            try
            {
                this.ar_player_answers[counter] = result;
                counter++;
            }
            catch (IndexOutOfRangeException)
            {
                
            }
        }
    }
}
