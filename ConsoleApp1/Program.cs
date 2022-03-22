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
        static void Uni(int[] a, int i = 0, int k = 0)
        {

            Console.Write($"{a[i]} ");

            k += a[i];
            i++;

            if (i == a.Length)
            {
                Console.WriteLine($" сумма элементов: {k}");
                return;
            }


            Uni(a, i, k);
        }

        static int Sum (int a)
        {
            if (a < 10)
                return a;
            int digit = a % 10;
            int nextA = a / 10;

            return digit + Sum(nextA);
        }
        static void Main(string[] args)
        {
            int result = 561;
            //int i = 0;
            //int k = 0;
            int[] sim = { 1, 4, 6 };
            Console.Write("вывод массива: ");
            Uni(sim);
            Console.WriteLine(Sum(result));
        }
    }
}