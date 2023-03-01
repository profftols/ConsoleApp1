using System;

namespace FileManagerTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ask = "Арбуз Боролся Внутри Ягодиц";

            var code = new Acoder();

            ask = code.Encode(ask);

            Console.WriteLine(ask);

            ask = code.Decode(ask);

            Console.WriteLine(ask);
            
        }
    }
}
