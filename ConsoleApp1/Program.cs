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
        static void Index(int[] arr)
        {

            Console.WriteLine("введите значение индекса: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("введите вносимое число в массив: ");
            int b = int.Parse(Console.ReadLine());

            arr[a] = b;
        }

        static void End(int[] arr)
        {
            Console.WriteLine("введите значение: ");
            int a = int.Parse(Console.ReadLine());

            arr[arr.Length - 1] = a;
            //arr[^1] = a;
        }

        static void Start(int[] arr)
        {
            Console.WriteLine("введите значение: ");
            int a = int.Parse(Console.ReadLine());

            arr[0] = a;
        }

        static void Main(string[] args)
        {
            int[] array = { 2, 4, 5, 6, 7 };

            Console.WriteLine("Размер массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Куда добавим элемент в массив?");
            string str = Console.ReadLine();

            switch (str)
            {
                case "начало":
                    Start(array);
                    break;

                case "конец":
                    End(array);
                    break;

                case "индекс":
                    Index(array);
                    break;

                default:
                    Console.WriteLine("нераспознанная команда");
                    break;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}