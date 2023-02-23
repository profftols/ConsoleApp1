using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountBank serOne = new AccountBank(400, 40000);
            AccountBank serTwo = new AccountBank(600, 40000);
            
            serOne.ReadBank();
            Console.WriteLine();
            serTwo.ReadBank();

            Console.ReadKey();
            Console.Clear();

            serOne.Transaction(serTwo, 100);

            serOne.ReadBank();
            Console.WriteLine();
            serTwo.ReadBank();

            Console.WriteLine(serOne.Equals(serTwo));

            /*

            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            Console.WriteLine(serOne.RetString(text)); 
            Console.ReadKey();
            Console.WriteLine();
            

            Building bdd = new Building(8, 25, 5, 300, 1);
            bdd.ReadBuild();

            Building Asd = new Building(10, 25, 5, 100, 3);
            Asd.ReadBuild();


            var car = new MotorVehicle();
            car.Indicate(true);

            var bike = new Bike();
            bike.Indicate(true);
            *
            */



        }
    }
}
