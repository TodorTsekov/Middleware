namespace TriviaClient
{
    partial class Trivia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_answer1 = new System.Windows.Forms.Button();
            this.bt_answer2 = new System.Windows.Forms.Button();
            this.bt_answer3 = new System.Windows.Forms.Button();
            this.lbl_questionText = new System.Windows.Forms.Label();
            this.lb_game_score = new System.Windows.Forms.ListBox();
            this.countdown = new System.Windows.Forms.Timer(this.components);
            this.Timer = new System.Windows.Forms.Label();
            this.lb_chat = new System.Windows.Forms.ListBox();
            this.bt_leave = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_global_id = new System.Windows.Forms.Label();
            this.lbl_countdown = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_answer1
            // 
            this.bt_answer1.Location = new System.Drawing.Point(8, 31);
            this.bt_answer1.Name = "bt_answer1";
            this.bt_answer1.Size = new System.Drawing.Size(186, 46);
            this.bt_answer1.TabIndex = 0;
            this.bt_answer1.Text = "button1";
            this.bt_answer1.UseVisualStyleBackColor = true;
            this.bt_answer1.Click += new System.EventHandler(this.bt_answer1_Click);
            // 
            // bt_answer2
            // 
            this.bt_answer2.Location = new System.Drawing.Point(264, 31);
            this.bt_answer2.Name = "bt_answer2";
            this.bt_answer2.Size = new System.Drawing.Size(186, 46);
            this.bt_answer2.TabIndex = 1;
            this.bt_answer2.Text = "button2";
            this.bt_answer2.UseVisualStyleBackColor = true;
            this.bt_answer2.Click += new System.EventHandler(this.bt_answer2_Click);
            // 
            // bt_answer3
            // 
            this.bt_answer3.Location = new System.Drawing.Point(508, 31);
            this.bt_answer3.Name = "bt_answer3";
            this.bt_answer3.Size = new System.Drawing.Size(186, 46);
            this.bt_answer3.TabIndex = 2;
            this.bt_answer3.Text = "button3";
            this.bt_answer3.UseVisualStyleBackColor = true;
            this.bt_answer3.Click += new System.EventHandler(this.bt_answer3_Click);
            // 
            // lbl_questionText
            // 
            this.lbl_questionText.AutoSize = true;
            this.lbl_questionText.Location = new System.Drawing.Point(21, 42);
            this.lbl_questionText.Name = "lbl_questionText";
            this.lbl_questionText.Size = new System.Drawing.Size(56, 13);
            this.lbl_questionText.TabIndex = 3;
            this.lbl_questionText.Text = "QUETION";
            // 
            // lb_game_score
            // 
            this.lb_game_score.FormattingEnabled = true;
            this.lb_game_score.Location = new System.Drawing.Point(634, 12);
            this.lb_game_score.Name = "lb_game_score";
            this.lb_game_score.Size = new System.Drawing.Size(120, 95);
            this.lb_game_score.TabIndex = 4;
            // 
            // countdown
            // 
            this.countdown.Interval = 1000;
            this.countdown.Tick += new System.EventHandler(this.countdown_Tick);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Location = new System.Drawing.Point(12, 9);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(33, 13);
            this.Timer.TabIndex = 6;
            this.Timer.Text = "Timer";
            // 
            // lb_chat
            // 
            this.lb_chat.FormattingEnabled = true;
            this.lb_chat.Location = new System.Drawing.Point(6, 19);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(407, 95);
            this.lb_chat.TabIndex = 7;
            // 
            // bt_leave
            // 
            this.bt_leave.Location = new System.Drawing.Point(634, 264);
            this.bt_leave.Name = "bt_leave";
            this.bt_leave.Size = new System.Drawing.Size(75, 65);
            this.bt_leave.TabIndex = 9;
            this.bt_leave.Text = "Leave Game";
            this.bt_leave.UseVisualStyleBackColor = true;
            this.bt_leave.Click += new System.EventHandler(this.bt_leave_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(327, 120);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 46);
            this.button6.TabIndex = 10;
            this.button6.Text = "Send";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_answer1);
            this.groupBox1.Controls.Add(this.bt_answer2);
            this.groupBox1.Controls.Add(this.bt_answer3);
            this.groupBox1.Location = new System.Drawing.Point(15, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 122);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_questionText);
            this.groupBox2.Location = new System.Drawing.Point(61, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question";
            // 
            // lbl_global_id
            // 
            this.lbl_global_id.AutoSize = true;
            this.lbl_global_id.Location = new System.Drawing.Point(579, 400);
            this.lbl_global_id.Name = "lbl_global_id";
            this.lbl_global_id.Size = new System.Drawing.Size(35, 13);
            this.lbl_global_id.TabIndex = 13;
            this.lbl_global_id.Text = "label1";
            // 
            // lbl_countdown
            // 
            this.lbl_countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_countdown.Location = new System.Drawing.Point(9, 22);
            this.lbl_countdown.Name = "lbl_countdown";
            this.lbl_countdown.Size = new System.Drawing.Size(45, 53);
            this.lbl_countdown.TabIndex = 14;
            this.lbl_countdown.Text = "5";
            this.lbl_countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 20);
            this.textBox1.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_chat);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(15, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 181);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chat";
            // 
            // Trivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_countdown);
            this.Controls.Add(this.lbl_global_id);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_leave);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.lb_game_score);
            this.Name = "Trivia";
            this.Text = "Trivia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_answer1;
        private System.Windows.Forms.Button bt_answer2;
        private System.Windows.Forms.Button bt_answer3;
        private System.Windows.Forms.Label lbl_questionText;
        private System.Windows.Forms.ListBox lb_game_score;
        private System.Windows.Forms.Timer countdown;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.ListBox lb_chat;
        private System.Windows.Forms.Button bt_leave;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_global_id;
        private System.Windows.Forms.Label lbl_countdown;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}