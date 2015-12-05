using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaClient.TriviaServer;
using System.ServiceModel;

namespace TriviaClient
{
    public partial class Trivia : Form
    {
        private TriviaServer.GameClient proxy;
        static CallbackHandler callback;
        /// <summary>
        /// Callback context.
        /// </summary>
        static InstanceContext ctx;
        public Trivia()
        {
            InitializeComponent();
            callback=new CallbackHandler();
            ctx = new InstanceContext(callback);
            proxy = new TriviaServer.GameClient(ctx);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Question q = proxy.getQuestion();
            lbl_questionText.Text = q.questionText;

            bt_answer1.Text = q.answer.ar_question_answers[0].ToString();
            bt_answer2.Text = q.answer.ar_question_answers[1].ToString();
            bt_answer3.Text = q.answer.ar_question_answers[2].ToString();
        }
    }
}
