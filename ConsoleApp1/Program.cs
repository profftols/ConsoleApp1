using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

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
        }
    }
}
