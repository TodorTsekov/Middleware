using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SimpleDatabaseApplication
{
    public partial class Register : Form
    {
        private DataHandler dh;

        public Register()
        {
            InitializeComponent();
            dh = new DataHandler();
        }

        private void btn_createacc_Click(object sender, EventArgs e)
        {
            int temp = dh.CreateAnAccount(tb_username.Text, tb_password.Text, tb_firstname.Text);
            if (temp == 1)
            {
                this.Close();
            }


        }
    }
}
