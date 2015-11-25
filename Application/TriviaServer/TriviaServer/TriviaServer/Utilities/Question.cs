using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaServer
{
    /// <summary>
    /// It declares a question and its possible answers.
    /// </summary>
    class Question
    {
        public string questionText;
        public List<Answer> lt_answers;
    }
}
