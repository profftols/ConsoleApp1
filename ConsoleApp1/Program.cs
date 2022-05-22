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
        static void Main(string[] args)
        {
            string s = "пустота";
            1;
            int num = 99;

            Console.WriteLine(Uni(s)); 

            Console.WriteLine($"{num}, {s}");
        }

        static string Uni(string sex)
        {
            //string n = sex;
            sex = "xe";

            return sex;
        }
    }
}