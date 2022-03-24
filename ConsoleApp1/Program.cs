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
        static void Summa(int[] array, int i, int nac)
        {

            nac += array[i];

            i++;

            if (i == array.Length)

            {
                Console.WriteLine(nac);
                return;
            }

            Summa(array, i, nac);
            
        }
        static void Main(string[] args)
        {
            int[] araay = { 1, 2, 3 };
            Summa(araay, 0, 0 );
        }


    }
}