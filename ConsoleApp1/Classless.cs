using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class Cherr
    {
        public static void Print(this DateTime dateTime)
        {
            //Console.WriteLine((int)dateTime.DayOfWeek);

            for (int i = 0; i <= 7; i++)
            {
                if ((int)dateTime.DayOfWeek == i)
                 Console.WriteLine($"до выходных осталось: {6 - i} дн"); return;
            }
        }
    }
}
