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
            
            AccountBank client = new AccountBank(0, 0, 50000, 0);
            AccountBank clienttwo = new AccountBank(400, 600, 200, 40000);

            do
            {
                Console.WriteLine("Информация о счете: \n1.Расчетный\n2.Депозитный\n3.Кредитный\n4.Бюджетный");
                int check = int.Parse(Console.ReadLine());

                Console.Clear();

                client.CheckBalance((AccountBank.AccType)check);
                clienttwo.CheckBalance((AccountBank.AccType)check);

                Console.WriteLine();

            } while (true);
        }
    }
}
