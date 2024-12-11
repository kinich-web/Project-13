using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
/// 
/// </summary>
    internal class Program 
    {/// <summary>
     /// найти значения х
     /// </summary>
     /// <param name="args"></param>
        public static double Func(int x)
        {
            return (Math.Sqrt(x) + x) / 2;
        }
        static void Main()
        {
            Console.WriteLine($"{ Func(5) + Func(12) + Func(19):f2}");
            Console.ReadKey();
        }

        
        

    }
}