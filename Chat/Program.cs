using ServiceProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Interfaces;

namespace Chat
{
    class Program
    {
        private static ServerProxyCore mServiceCore = ServerProxyCore.GetInStance();
        static void Main(string[] args)
        {
            mServiceCore.Send("Test");
            Console.ReadKey();
        }
    }
}
