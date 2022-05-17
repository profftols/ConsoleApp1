using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cherr
    {
        private int a = 0;

        public int Ask ()
        {
            Console.WriteLine("Выбери опцию из + или -");
            string v = Console.ReadLine();
            switch (v)
            {
                case "+":
                    return a++;
                case "-":
                    return a--;
                default:
                    Console.WriteLine("Вы выбрали несуществующий вариант");
                    return Ask();
            }
        }

        public int A { get { return a; } }
    }
}
