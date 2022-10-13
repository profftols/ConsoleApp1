using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace ConsoleApp1
{

    class Program
    {
        static int x_size, y_size, num = 1;

        static void Filling(int[,] mass) //spiral filling logic
        {
            for (int y = 0; y < y_size; y++)
            {
                if (y == 0)
                {
                    for (int x = 0; x < x_size; x++)
                    {
                        mass[x, y] = num++;
                    }
                }
            }
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Задаим размер: \n1) X координат \n2) Y координат \n");
            
            x_size = int.Parse(Console.ReadLine());
            y_size = int.Parse(Console.ReadLine());
            
            int[,] mass = new int[x_size, y_size];
            /* Написать методы заполняющие: 
             * 1. по прямой плюс
             * 2. вниз плюс
             * 3. по прямой минус
             * 4. вверх минус
             * (реализовать проверку заполненности массива, иначе повторить)
             */
            Filling(mass);
            
            Console.WriteLine();

            for (int i = 0; i < y_size; i++) //array full check
            {
                for (int j = 0; j < x_size; j++)
                {
                    Console.Write(mass[j,i]);
                }
                Console.WriteLine();
            }
        }
    }
}
