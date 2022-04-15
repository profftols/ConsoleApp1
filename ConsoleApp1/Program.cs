using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character cher = new Character();

            Console.WriteLine("Меню создание персонажа: ");

            cher = GetNew();

            Console.WriteLine("Пресонаж создан!");
            
            cher.Print();
        }

        static Character GetNew()
        {
            var cher = new Character();

            cher.level = 1;

            Console.WriteLine("Назовите персонажа");
            string name = Console.ReadLine();
            cher.name = name;

            Console.WriteLine("Выберете рассу");
            int i = 0;
            var valu = Enum.GetValues(typeof(Race));
            foreach (var item in valu)
            {
                i++;
                Console.WriteLine($"{item} = {i}");
            }    
            int aa = int.Parse(Console.ReadLine());
            cher.race = (Race)aa;

            Console.WriteLine("Выберете класс");
            var volu = Enum.GetValues(typeof(Spec));
            int b = 0;
            foreach (var item in volu)
            {
                b++;
                Console.WriteLine($"{item} = {b}");
            }
            int bb = int.Parse(Console.ReadLine());
            cher.spec = (Spec)bb;

            return cher;
        }
    }
}