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
        static void Exit(int[] array, int i = 0)
        {
            if(i < array.Length)
            { 
                Console.WriteLine(array[i]);
                Exit(array, i+1);
            }
        }
        static void Main(string[] args)
        {
            int[] araay = { 1, 2, 3, 4, 5, 6, 7 };
            Exit(araay);
        }


    }
}