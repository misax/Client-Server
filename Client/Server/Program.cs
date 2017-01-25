using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
                using(ServiceHost host = new ServiceHost(typeof(Service1))) {
                host.Open();
                Console.WriteLine("Server is open");
                Console.WriteLine("Please <enter> to close server");
                Console.ReadLine();
            }
        }
    }
}
