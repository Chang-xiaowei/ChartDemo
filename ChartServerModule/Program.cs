using System;
using System.ServiceModel;

namespace ChatServerModule
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host=new ServiceHost(typeof(ServerOperatorService)))
            {
                host.Opened -= Host_Opened;
                host.Opened += Host_Opened;
                host.Open();
                Console.ReadKey();
                host.Close();
            }
        }

        private static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("服务已经打开");
        }
    }
}
