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
            ServiceHost gameHost = new ServiceHost(typeof(Game));

            gameHost.Open();

            Console.WriteLine("Service started...\nPress enter to exit");
            for (int i = 0; i < gameHost.BaseAddresses.ToList().Count; i++)
            {
                Console.WriteLine(gameHost.BaseAddresses.ToList()[i].ToString());
            }
            Console.ReadLine();
            gameHost.Close();
        }
    }
}
