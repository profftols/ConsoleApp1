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
        static int Sumint(int i)
        {
            int c;
            int d;
            int e;
            if (i <= 9)
            {
                return i;

            }
            c = i % 10;
            //Console.WriteLine(c);
            d = i / 10;
            //Console.WriteLine(d);
            e = c + Sumint(d);
            //Console.WriteLine(e);
            return e;
            
        }
        static void Main(string[] args)
        {
            int i = 123;
            int f;
            f = Sumint(i);
            Console.WriteLine(f);
        }


    }
}