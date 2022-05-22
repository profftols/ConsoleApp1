using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "пустота";

            int num = 45;

            Uni(ref num);

            Console.WriteLine($"{num}, {s}");

        }
        
        static void Uni (ref int a)
        {
            a += a;

            return;
        }
    }
}
