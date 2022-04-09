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
        static int Mult(in int b, int c, int a) // c - число умножения, b - число умножения
        {
            a++;
            c *= c;

            if (b == a)
                return c;

            Mult(b, c, a);

        }

        static int Div(int a, int b)
        {

            return a;
        }
        static void Main(string[] args)
        {
            Choise();
        }

        static void Choise()
        {

            if (true)
            {
                int a, b, c;

                Console.WriteLine("Выберете комманду: \n Деление (1) \n Умножение (2) \n Закрыть програму (0)");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите число для арифмитической операции: ");
                c = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("Сколько раз делить?");
                        b = int.Parse(Console.ReadLine());
                        Div(b, c);
                        break;
                    case 2:
                        Console.WriteLine("Сколько раз умножить?");
                        b = int.Parse(Console.ReadLine());
                        Mult(b, c);
                        break;
                    case 0:
                        return;
                }/*
            else
                {
                    Console.WriteLine("Итог: \n вывод результата (1) \n вернуться в главное меню (0)");

                }*/
            }
        }
    }
}