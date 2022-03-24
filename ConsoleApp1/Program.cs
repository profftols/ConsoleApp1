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
        static void Sumint(int i)
        {
            int c;
            int d;
            int e;
            int f;
            i *= 100;
            //Console.WriteLine(c);
            Console.WriteLine(i);
            i *= 10;
            Console.WriteLine(i);
            /*d = c %= 10;
            Console.WriteLine(d);
            e = d % 1;
            Console.WriteLine(e);
            f = c + d + e;
            Console.WriteLine(f);*/




        }
        static void Main(string[] args)
        {
            int i = 123;
            Sumint(i);

        }


    }
}