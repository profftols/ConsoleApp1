using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            AccountBank client = new AccountBank(0, 0);
            AccountBank clienttwo = new AccountBank(300, 40000);
            
            client.ReadBank();
            Console.WriteLine();
            clienttwo.ReadBank();

            Console.ReadKey();
            Console.Clear();

            client.Transaction(clienttwo, 100);

            client.ReadBank();
            Console.WriteLine();
            clienttwo.ReadBank();

            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            Console.WriteLine(client.RetString(text)); 
            Console.ReadKey();
            Console.WriteLine();
            

            Building bdd = new Building(8, 25, 5, 200, 1);
            bdd.ReadBuild();

            Building Asd = new Building(10, 25, 5, 100, 3);
            Asd.ReadBuild();
            

            Rectangle rect = new Rectangle(4, 6);
            Console.WriteLine("Height: {0}", rect.Height);
            Console.WriteLine("Windth: {0}", rect.Width);

            Rectangle square = new Rectangle(5);
            Console.WriteLine("Heigth: {0}", square.Height);
            Console.WriteLine("Width: {0}", square.Width);
            
            */

            OverridesInteger o1 = new OverridesInteger(1, 2);
            OverridesInteger o2 = new OverridesInteger(3, 4);
            OverridesInteger o3 = o1 + o2;

            Console.WriteLine("J = {0} K = {1}", o3.K, o3.J);

            Console.WriteLine(o1.Calc("1", 76, 2));

            o1.Motrh(2.5);
        }
    }
}
