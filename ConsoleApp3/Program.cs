using System;

namespace ConsoleApp3
{
    internal class Program
    {
        enum DayWeek
        {
            monday =1 ,
            tuesday,
            wednsday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {
            DayWeek dayWeek = DayWeek.sunday;
            Console.WriteLine(dayWeek);
            Console.WriteLine((int)dayWeek);
            Console.WriteLine((DayWeek)1);

        }
    }
}
