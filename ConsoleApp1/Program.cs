using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {

        static int x_size, y_size, num = 1, x, y;

        static void Straight(ref int y, ref int x, int[,] mass)
        {
            if (x != 0)
            {
                do
                {
                    mass[y, x] = num++;
                    x++;
                } while (mass[y, x] == 0);
                y++;
                x--;
            }
            else
            {
                do
                {
                    mass[y, x] = num++;
                    x++;
                } while (x < y_size);
                y++;
            }
        }

        static void Side(ref int y, ref int x, int[,] mass)
        {
            if (x == y_size)
            {
                x--;
                do
                {
                    mass[y, x] = num++;
                    y++;
                } while (y < x_size);
                y--;
                x--;
            }
            else if (mass[y,x] == 0)
            {
                do
                {
                    mass[y, x] = num++;
                    y++;
                } while (mass[y, x] == 0);
                y--;
                x--;
            }
        }

        static void Bottom(ref int y, ref int x, int[,] mass)
        {
            if (y + 1 == x_size)
            {
                do
                {
                    mass[y, x] = num++;
                    x--;
                } while (x >= 0);
                y--;
                x++;
            }
            else
            {
                do
                {
                    mass[y, x] = num++;
                    x--;
                } while (mass[y, x] == 0);
                y--;
                x++;
            }

        }

        static void Middle(ref int y, ref int x, int[,] mass)
        {
            do
            {
                mass[y, x] = num++;
                y--;
            } while (mass[y, x] == 0);
            y++;
            x++;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задаим размер: \n1) Y координат \n2) X координат \n");

            x_size = 6; //int.Parse(Console.ReadLine());
            y_size = 6; //int.Parse(Console.ReadLine());

            int[,] mass = new int[x_size, y_size];

            /* 
             * Написать методы заполняющие: 
             * 1. по прямой плюс
             * 2. вниз плюс
             * 3. по прямой минус
             * 4. вверх минус
             * (реализовать проверку заполненности массива, иначе повторить)
             */
            do
            {
                Straight(ref y, ref x, mass);
                Side(ref y, ref x, mass);

                if (mass[y, x] == 0)
                    Bottom(ref y, ref x, mass);
                if (mass[y, x] == 0)
                    Middle(ref y, ref x, mass);
            } while (mass[y, x] == 0);

            
            Console.WriteLine();
            for (int h = 0; h < x_size; h++)
            {
                for (int j = 0; j < y_size; j++)
                {
                    Console.Write(mass[h, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
