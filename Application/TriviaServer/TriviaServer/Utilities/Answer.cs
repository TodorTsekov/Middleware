using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaContract
{
    /// <summary>
    /// It declares an array of possible questions and their correctness.
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// The id of the question refering to these answers.
        /// </summary>
        public int question_id;
        public string[] ar_question_answers;
        public bool[] ar_results;

        public Answer()
        {
            question_id = new int();
            ar_question_answers = new string[3];
            ar_results = new bool[3];
        }

        public Answer(int question_id, 
            string answer1, bool result1,
            string answer2, bool result2,
            string answer3, bool result3)
        {
            this.question_id = question_id;
            this.ar_question_answers[0] = answer1;
            this.ar_question_answers[1] = answer2;
            this.ar_question_answers[2] = answer3;

            this.ar_results[0] = result1;
            this.ar_results[1] = result2;
            this.ar_results[2] = result3;
        }

        public int Question_id { get; set; }
        public string[] Ar_question_answers { get; set; }
        public bool[] Ar_results { get; set; }
    }
}
