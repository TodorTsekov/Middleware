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
        TriviaServer.GameClient proxy;
        /// <summary>
        /// Callback context.
        /// </summary>
        static InstanceContext ctx;
        public Trivia()
        {
            InitializeComponent();
            ctx=new InstanceContext()
            proxy=new GameClient()
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
