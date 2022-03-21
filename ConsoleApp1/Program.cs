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
        static void Main(string[] args)
        {
            //int i = 0;
            //int k = 0;
            int[] sim = { 1, 4, 6, 7, 8, 9 };
            Console.Write("вывод массива: ");
            Uni(sim);
        }
    }
}