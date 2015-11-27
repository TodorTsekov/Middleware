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
    public class Question
    {
        public string questionText;
        public List<Answer> lt_answers;
    }
}
