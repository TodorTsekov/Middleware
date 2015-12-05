using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TriviaContract;

namespace ServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Game));


            host.Open();

            Console.WriteLine("Service started...\nPress enter to exit");
            for (int i = 0; i < host.BaseAddresses.ToList().Count; i++)
            {
                Console.WriteLine(host.BaseAddresses.ToList()[i].ToString());
            }
            Console.ReadLine();
            host.Close();
        }
    }
}
