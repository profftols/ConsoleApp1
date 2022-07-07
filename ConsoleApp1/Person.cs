using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public string Profi { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public int Solary { get; set; }
        public int Age { get; set; }

        public Person(string name, string profi, string mail, string tel, int solary, int age)
        {
            Name = name;
            Profi = profi;
            Mail = mail;
            Tel = tel;
            Solary = solary;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} {Profi} {Mail} {Tel} {Solary} {Age}");
        }
    }
}
