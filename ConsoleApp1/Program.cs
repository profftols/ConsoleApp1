﻿using System;
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

            try
            {
                Choise(a);
            }
            catch (Exception)
            {

                throw;
            }
        }

        static int Choise(int a)
        {
            
        }
    }
}
