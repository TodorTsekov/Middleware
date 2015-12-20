namespace SimpleDatabaseApplication
{
    partial class Register
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
            this.btn_createacc = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_firstname = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_firstname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_createacc
            // 
            this.btn_createacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createacc.Location = new System.Drawing.Point(66, 209);
            this.btn_createacc.Name = "btn_createacc";
            this.btn_createacc.Size = new System.Drawing.Size(152, 40);
            this.btn_createacc.TabIndex = 0;
            this.btn_createacc.Text = "Create an account";
            this.btn_createacc.UseVisualStyleBackColor = true;
            this.btn_createacc.Click += new System.EventHandler(this.btn_createacc_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(104, 50);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(149, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(104, 98);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(149, 20);
            this.tb_password.TabIndex = 2;
            // 
            // tb_firstname
            // 
            this.tb_firstname.Location = new System.Drawing.Point(104, 150);
            this.tb_firstname.Name = "tb_firstname";
            this.tb_firstname.Size = new System.Drawing.Size(149, 20);
            this.tb_firstname.TabIndex = 3;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(12, 46);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(87, 20);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(12, 96);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(82, 20);
            this.lb_password.TabIndex = 5;
            this.lb_password.Text = "Password:";
            // 
            // lb_firstname
            // 
            this.lb_firstname.AutoSize = true;
            this.lb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_firstname.Location = new System.Drawing.Point(12, 148);
            this.lb_firstname.Name = "lb_firstname";
            this.lb_firstname.Size = new System.Drawing.Size(90, 20);
            this.lb_firstname.TabIndex = 6;
            this.lb_firstname.Text = "First Name:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb_firstname);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_firstname);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_createacc);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_createacc;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_firstname;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_firstname;
    }
}