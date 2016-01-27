namespace TriviaClient
{
    partial class Login
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
            this.llb_register = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbx_loging = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.but_login = new System.Windows.Forms.Button();
            this.grpbx_loging.SuspendLayout();
            this.SuspendLayout();
            // 
            // llb_register
            // 
            this.llb_register.AutoSize = true;
            this.llb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_register.Location = new System.Drawing.Point(227, 232);
            this.llb_register.Name = "llb_register";
            this.llb_register.Size = new System.Drawing.Size(53, 16);
            this.llb_register.TabIndex = 5;
            this.llb_register.TabStop = true;
            this.llb_register.Text = "register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "If you do not have an account please";
            // 
            // grpbx_loging
            // 
            this.grpbx_loging.Controls.Add(this.label2);
            this.grpbx_loging.Controls.Add(this.label1);
            this.grpbx_loging.Controls.Add(this.tb_password);
            this.grpbx_loging.Controls.Add(this.tb_username);
            this.grpbx_loging.Controls.Add(this.but_login);
            this.grpbx_loging.Location = new System.Drawing.Point(12, 12);
            this.grpbx_loging.Name = "grpbx_loging";
            this.grpbx_loging.Size = new System.Drawing.Size(268, 191);
            this.grpbx_loging.TabIndex = 4;
            this.grpbx_loging.TabStop = false;
            this.grpbx_loging.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(104, 106);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(135, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(104, 50);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(135, 20);
            this.tb_username.TabIndex = 1;
            // 
            // but_login
            // 
            this.but_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_login.Location = new System.Drawing.Point(78, 150);
            this.but_login.Name = "but_login";
            this.but_login.Size = new System.Drawing.Size(104, 35);
            this.but_login.TabIndex = 0;
            this.but_login.Text = "Login";
            this.but_login.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 265);
            this.Controls.Add(this.llb_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpbx_loging);
            this.Name = "Login";
            this.Text = "Login";
            this.grpbx_loging.ResumeLayout(false);
            this.grpbx_loging.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llb_register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpbx_loging;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button but_login;
    }
}