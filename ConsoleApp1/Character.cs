using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum Race : byte
    {
        Human = 1,
        Orc,
        Elf,
        Troll
    }

    enum Spec : byte
    {
        Warrior = 1,
        Hunter,
        Mage,
        Prist
    }
    internal class Character
    {
        public string name;
        public Race race;
        public int level;
        public Spec spec;

        public void Print()
        {
            Console.WriteLine("информация о персонаже:");
            Console.WriteLine($"Имя: {name} ");
            Console.WriteLine($"Уровень: {level}");
            Console.WriteLine($"Класс: {spec}");
            Console.WriteLine($"Раса: {race}");
        }
    }

}
