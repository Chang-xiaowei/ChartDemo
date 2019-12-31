using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF.Interfaces;

namespace ServiceProxy
{
    public class ServerCallback : IServerCallback
    {
        //public void Display(double result)
        //{
        //    Console.WriteLine("The result is:{0}", result);
        //}
        public void SendData(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
