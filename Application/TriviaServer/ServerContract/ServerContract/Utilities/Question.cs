using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaContract
{
    /// <summary>
    /// It declares a question and its possible answers.
    /// </summary>
    [Serializable]
    public class Question
    {
        public int id;
        public string questionText;
        public Answer answer;

        public Question()
        {

        }

        public Question(int id, string text, Answer answer)
        {
            this.id = id;
            this.questionText = text;
            this.answer = answer;
        }
    }
}
