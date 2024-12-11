using Microsoft.Build.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace практикум_6
{/// <summary>
/// Вычисление функции
/// </summary>
    internal class Program
    {
        public static int Input(String message)
        { 
        Console.Write(message);
            return int.Parse(Console.ReadLine());
            }
        static double Func(int number)
        {
            return Math.Pow(number, 2) + 1;
        }
        static void Main(string[] args)
        {
            int number = Input("Введите число ");
            Console.WriteLine($"f(x) = {Func(number)}");
            Console.ReadKey();  
        }
    }
}
