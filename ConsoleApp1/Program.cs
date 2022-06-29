using System;

namespace ConsoleApp1
{
    class Fop
    {
        public int a = 30;
        public int b = 29;
        public string ask = "sum1";  
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat num = new Cat { Age = 4, Name = "Bars" };
            Fop fop = new Fop();

            Console.WriteLine($"{num.Age}, { num.Name}, {fop.ask}");

        }
    }
}
