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

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
