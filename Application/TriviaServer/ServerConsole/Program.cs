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
            Console.WriteLine(host.Description);
            Console.ReadLine();
            host.Close();
        }
    }
}
