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
        static void Menu(int b)
        {
            Console.WriteLine("Меню: \n 1 - умножить \n 2 - делить \n 3 - выход");
            int a = int.Parse(Console.ReadLine());

            if (a >= 3)
                return;

            int i = 0;

            Console.WriteLine("Введите количество итерации: ");
            int c = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Mult(ref b, c);
                    break;
                case 2:
                    Dura(ref b, c);
                    break;
            }
            Result(b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число для арифмитической операции: ");
            int b = int.Parse(Console.ReadLine());

            Menu(b);
        }

        static int Mult(ref int b, int c)
        {
            if (0 >= c)
                return b;

            b *= 2;
            c--;

            return Mult(ref b, c);
        }

        static int Dura(ref int b, int c)
        {
            if (0 >= c)
                return b;

            b /= 2;
            c--;

            return Dura(ref b, c);
        }

        static void Result(in int b)
        {
            Console.WriteLine("Выводим результат? \n 1 - да \n 2 - Выйти из программы");
            int c = int.Parse(Console.ReadLine());

            if (c == 1)
            {
                Console.WriteLine(b);
                Menu(b);
            }
            else
            {
                return;
            }
        }
    }
}