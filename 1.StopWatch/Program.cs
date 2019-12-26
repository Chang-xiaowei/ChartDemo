using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.StopWatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.Stop();
            Console.WriteLine("耗时"+stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
