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
    public partial class StartGame : Form
    {
        private GameClient proxy;
        static CallbackHandler callback;
        static InstanceContext ctx;
        static int global_id;
        public StartGame()
        {
            InitializeComponent();
            callback = new CallbackHandler();
            ctx = new InstanceContext(callback);
            proxy = new GameClient(ctx);
            global_id=proxy.set
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proxy.setReady()
        }
    }
}
