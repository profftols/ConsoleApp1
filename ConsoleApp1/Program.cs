using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Мы пишем приложение для выбора цифр \n Поэтому выберете цифру от 1 до 3");
            int choice = int.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                    Console.WriteLine($"вы выбрали {choice}");
                    break;

                case 2:
                    Console.WriteLine($"вы выбрали {choice}");
                    break;

                default:
                    Console.WriteLine("вы вышли за границы выбора");
                    break;
            }
        }
    }
}
