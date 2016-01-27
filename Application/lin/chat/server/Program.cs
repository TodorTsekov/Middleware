using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Runser();

        }
        private void Runser()
        {
            using (ServiceHost host = new ServiceHost(typeof(chat.Chat)))
            {
                host.Open();
                Console.WriteLine("server is staring");
                Console.WriteLine("press any key to exit");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
