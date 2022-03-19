using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static int Uni(int a)
        {
            int b = a - 5;
            return b;
        }
        static void Main(string[] args)
        {
            string s = "пустота";
            int[] sim = {1, 4, 6, 7, 8, 9 };
            Console.WriteLine(sim[0]);

            int num = 99;
            Uni(num);

            Console.WriteLine($"{num}, /{s}");
        }
    }
}