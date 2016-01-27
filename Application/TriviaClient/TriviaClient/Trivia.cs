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
using System.Media;

namespace TriviaClient
{
    public partial class Trivia : Form
    {
        private TriviaServer.GameClient proxy;
        static Game callback;
        /// <summary>
        /// Callback context.
        /// </summary>
        static InstanceContext ctx;
        static int global_id;
        private int question_counter;
        private int timer_counter;
        private SoundPlayer tick;
        public Trivia(int id)
        {
            InitializeComponent();
            callback = new Game();
            ctx = new InstanceContext(callback);
            proxy = new TriviaServer.GameClient(ctx);
            global_id = id;
            timer_counter = 5;
            tick = new SoundPlayer(@"..\..\tick.wma");
            this.lbl_global_id.Text = id.ToString();
            this.question_counter = 1;
            Question question = proxy.getQuestion(question_counter, global_id);
            question_counter++;
            lbl_questionText.Text = question.questionText;
            bt_answer1.Text = question.answer.ar_question_answers[0].ToString();
            bt_answer2.Text = question.answer.ar_question_answers[1].ToString();
            bt_answer3.Text = question.answer.ar_question_answers[2].ToString();
            countdown.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Question question = proxy.getQuestion(question_counter, global_id);
            lbl_questionText.Text = question.questionText;

            bt_answer1.Text = question.answer.ar_question_answers[0].ToString();
            bt_answer2.Text = question.answer.ar_question_answers[1].ToString();
            bt_answer3.Text = question.answer.ar_question_answers[2].ToString();
            question_counter++;
        }

        private void bt_answer2_Click(object sender, EventArgs e)
        {
            proxy.setAnswer(global_id, question_counter - 1, 1);
            ask();
        }

        private void bt_answer1_Click(object sender, EventArgs e)
        {
            proxy.setAnswer(global_id, question_counter - 1, 0);
            ask();
        }

        private void bt_answer3_Click(object sender, EventArgs e)
        {
            proxy.setAnswer(global_id, question_counter - 1, 2);
            ask();
        }

        private void ask()
        {
            Question question = proxy.getQuestion(question_counter, global_id);
            lbl_questionText.Text = question.questionText;

            bt_answer1.Text = question.answer.ar_question_answers[0].ToString();
            bt_answer2.Text = question.answer.ar_question_answers[1].ToString();
            bt_answer3.Text = question.answer.ar_question_answers[2].ToString();
            question_counter++;
            timer_counter = 5;
            lbl_countdown.Text = "5";
            countdown.Start();
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            //tick.Play();
            timer_counter--;
            lbl_countdown.Text = timer_counter.ToString();
            if (timer_counter == 0)
            {
                countdown.Stop();
                ask();
            }
        }

        private void bt_leave_Click(object sender, EventArgs e)
        {
            proxy.leave(global_id);
            Application.Exit();
        }
    }
}
