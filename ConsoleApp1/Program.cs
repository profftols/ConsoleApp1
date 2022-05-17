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
        static void Main(string[] gs)
        {
            Cherr cherr = new Cherr();

            Console.WriteLine(cherr.A);

            cherr.Ask();

            Console.WriteLine("Какой будет ответ значения А?");
            int a = int.Parse(Console.ReadLine());

            if (a == cherr.A)
            {
                Console.WriteLine("Правильный ответ");
                return;
            }
            Console.WriteLine($"Ответ неверный! правильный ответ {cherr.A}");
        }
    }
}