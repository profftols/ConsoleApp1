﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Sin
    {
        private int a { get; set; } = 22;
        public void Som()
        {
            Console.WriteLine(a + 22);
            return;
        }
    }
    class Program
    {
        static void Main(string[] gs)
        {
            Sin mob = new Sin();

            mob.Som();
            
        }
    }
}