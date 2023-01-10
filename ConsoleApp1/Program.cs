using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выводим номер дз урока");
            string str = Console.ReadLine();

            switch (str)
            {
                case "1":
                    MethodReckurs();
                    break;
                case "2":
                    LinkenList();
                    break;

                case "0":
                    return;
            }

        }
        #region Lession1
        static void MethodReckurs()
        {
            long n = long.Parse(Console.ReadLine());

            long b = n;

            NumberType(n); //1

            //Console.WriteLine("\nсложность функции: 1+N*N*N+1+1+1N "); //2

            Console.WriteLine("\nРекурсия:"); //3
            FibonRecursion(n);
            Console.WriteLine(n);

            Console.WriteLine("\n\nЦикл:");
            FibonCycle(b);
        }
        static void NumberType(long n)
        {
            Console.WriteLine("Начало\n");

            long d = 0;
            long i = 2;

            do
            {
                if (n % i == 0)
                    d++;

                i++;

            } while (i < n);

            if (d == 0)
                Console.WriteLine("Простое");
            else
                Console.WriteLine("Непростое");

            Console.WriteLine("\nКонец");

        }

        static long FibonRecursion(long n)
        {

            if (n <2) return n;

            return FibonRecursion(n - 1) + FibonRecursion(n - 2);
        }


        static void FibonCycle(long b)
        {
            int result = 0;
            int j = 1;
            int tmp;

            for (int i = 0; i < b; i++)
            {
                tmp = result;
                result = j;
                j += tmp;
            }

            Console.WriteLine(result);
        }
        #endregion

        #region Lession2
        static void LinkenList()
        {
            DoublyLinkedList<string> linked = new DoublyLinkedList<string>();
            linked.AddList("sare");
            linked.AddList("konor");
            //linked.AddList("ssd");

            foreach (var link in linked)
            {
                Console.WriteLine(link);
            }
        }

        #endregion
    }
}
