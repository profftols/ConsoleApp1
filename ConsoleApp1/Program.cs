using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбери от 1 до 2");

            int a = int.Parse(Console.ReadLine());
            string s = "пустот1а";

            int num = 93;

            try
            {
                Choise(a);
            }
            catch (Exception)
            {
                throw;
            }
            
            Console.WriteLine($"{num}, {s}");

            Console.ReadLine(); 
        }

        static int Choise(int a)
        {
            a = 3;
        }
    }
}
