namespace SimpleDatabaseApplication
{
    partial class Trivia_Lobby
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
            this.lb_hello = new System.Windows.Forms.Label();
            this.lb_users = new System.Windows.Forms.ListBox();
            this.btn_invite = new System.Windows.Forms.Button();
            this.lb_wins = new System.Windows.Forms.Label();
            this.lb_draws = new System.Windows.Forms.Label();
            this.lb_loses = new System.Windows.Forms.Label();
            this.lb_rank = new System.Windows.Forms.Label();
            this.cb_playersonline = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hello.Location = new System.Drawing.Point(13, 23);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(0, 20);
            this.lb_hello.TabIndex = 0;
            // 
            // lb_users
            // 
            this.lb_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_users.FormattingEnabled = true;
            this.lb_users.ItemHeight = 16;
            this.lb_users.Location = new System.Drawing.Point(277, 12);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(197, 324);
            this.lb_users.TabIndex = 1;
            // 
            // btn_invite
            // 
            this.btn_invite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invite.Location = new System.Drawing.Point(356, 356);
            this.btn_invite.Name = "btn_invite";
            this.btn_invite.Size = new System.Drawing.Size(99, 47);
            this.btn_invite.TabIndex = 2;
            this.btn_invite.Text = "Invite";
            this.btn_invite.UseVisualStyleBackColor = true;
            // 
            // lb_wins
            // 
            this.lb_wins.AutoSize = true;
            this.lb_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_wins.Location = new System.Drawing.Point(16, 78);
            this.lb_wins.Name = "lb_wins";
            this.lb_wins.Size = new System.Drawing.Size(0, 20);
            this.lb_wins.TabIndex = 3;
            // 
            // lb_draws
            // 
            this.lb_draws.AutoSize = true;
            this.lb_draws.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_draws.Location = new System.Drawing.Point(16, 109);
            this.lb_draws.Name = "lb_draws";
            this.lb_draws.Size = new System.Drawing.Size(0, 20);
            this.lb_draws.TabIndex = 4;
            // 
            // lb_loses
            // 
            this.lb_loses.AutoSize = true;
            this.lb_loses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loses.Location = new System.Drawing.Point(16, 141);
            this.lb_loses.Name = "lb_loses";
            this.lb_loses.Size = new System.Drawing.Size(0, 20);
            this.lb_loses.TabIndex = 5;
            // 
            // lb_rank
            // 
            this.lb_rank.AutoSize = true;
            this.lb_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rank.Location = new System.Drawing.Point(115, 78);
            this.lb_rank.Name = "lb_rank";
            this.lb_rank.Size = new System.Drawing.Size(0, 20);
            this.lb_rank.TabIndex = 6;
            // 
            // cb_playersonline
            // 
            this.cb_playersonline.AutoSize = true;
            this.cb_playersonline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_playersonline.Location = new System.Drawing.Point(165, 12);
            this.cb_playersonline.Name = "cb_playersonline";
            this.cb_playersonline.Size = new System.Drawing.Size(112, 17);
            this.cb_playersonline.TabIndex = 9;
            this.cb_playersonline.Text = "players online only";
            this.cb_playersonline.UseVisualStyleBackColor = true;
            this.cb_playersonline.CheckedChanged += new System.EventHandler(this.cb_playersonline_CheckedChanged);
            // 
            // Trivia_Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 414);
            this.Controls.Add(this.cb_playersonline);
            this.Controls.Add(this.lb_rank);
            this.Controls.Add(this.lb_loses);
            this.Controls.Add(this.lb_draws);
            this.Controls.Add(this.lb_wins);
            this.Controls.Add(this.btn_invite);
            this.Controls.Add(this.lb_users);
            this.Controls.Add(this.lb_hello);
            this.Name = "Trivia_Lobby";
            this.Text = "Trivia_Lobby";
            this.Load += new System.EventHandler(this.Trivia_Lobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hello;
        private System.Windows.Forms.ListBox lb_users;
        private System.Windows.Forms.Button btn_invite;
        private System.Windows.Forms.Label lb_wins;
        private System.Windows.Forms.Label lb_draws;
        private System.Windows.Forms.Label lb_loses;
        private System.Windows.Forms.Label lb_rank;
        private System.Windows.Forms.CheckBox cb_playersonline;
    }
}