using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using chat;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            statusStrip1.Text = "DISCONNECTE";
        }
        private ChannelFactory<Triva> remotefactory;
        private Triva remoteproxy ;
        private User clientuser;
        private bool isconnected = false;
        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { statusStrip1.Text = "connecting";
            Form2 login = new Form2();
            login.ShowDialog(this);
                if(!String.IsNullOrEmpty(login.Name))
                {
                    remotefactory = new ChannelFactory<Triva>("Chatconfig");
                    remoteproxy = remotefactory.CreateChannel();
                    clientuser = remoteproxy.ClientConnect(login.Name);
                    if (clientuser != null)
                    {
                        menuStrip1.Enabled = false;
                        button1.Enabled = true;
                        textBox2.Enabled = true;
                        isconnected = true;
                        statusStrip1.Text = "connect as" + clientuser.Name;
                    }
                    else
                        statusStrip1.Text = "disconnect";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("an error occurred" + ex.Message,"fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
