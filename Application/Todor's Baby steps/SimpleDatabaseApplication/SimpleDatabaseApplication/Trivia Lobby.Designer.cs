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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.Location = new System.Drawing.Point(13, 23);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(0, 13);
            this.lb_hello.TabIndex = 0;
            // 
            // lb_users
            // 
            this.lb_users.FormattingEnabled = true;
            this.lb_users.Location = new System.Drawing.Point(277, 12);
            this.lb_users.Name = "lb_users";
            this.lb_users.Size = new System.Drawing.Size(239, 329);
            this.lb_users.TabIndex = 1;
            // 
            // btn_invite
            // 
            this.btn_invite.Location = new System.Drawing.Point(356, 356);
            this.btn_invite.Name = "btn_invite";
            this.btn_invite.Size = new System.Drawing.Size(99, 47);
            this.btn_invite.TabIndex = 2;
            this.btn_invite.Text = "Invite";
            this.btn_invite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // Trivia_Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_invite);
            this.Controls.Add(this.lb_users);
            this.Controls.Add(this.lb_hello);
            this.Name = "Trivia_Lobby";
            this.Text = "Trivia_Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_hello;
        private System.Windows.Forms.ListBox lb_users;
        private System.Windows.Forms.Button btn_invite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}