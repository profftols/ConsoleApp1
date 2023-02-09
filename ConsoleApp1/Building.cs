using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp1
{
    internal class Building
    {
        private static int Numberbuild;
        private double heightB = 2.7;
        private double heightbuild
        {
            set
            {
                if (value <= 2.6)
                    Console.WriteLine("Высота этажа не может быть менее 2.7м");
                else
                    heightB = value;
            }
            get { return heightB; }
        }
        private int floor;
        private int apartments;
        private int porch;
        private int numberbuild;
        

        public Building(int Number, double Height, int Floor, int Apart, int Porch)
        {
            Numberbuild = Number;
            numberbuild = Numberbuild;
            floor = Floor;
            heightbuild = HeightFloor(Height);
            apartments = Apart;
            porch = Porch;
            
        }
        
        public void ReadBuild()
        {
            Console.WriteLine($"Здание с адресом: {numberbuild}\nЭтажность: {floor}\nПодьездов: {porch}\nКоличество квартир:{apartments}\nВысота здания: {heightbuild}m");
            Console.ReadKey();
            Console.Clear();
        }

        public double HeightFloor(double Height)
        {
            double value = heightB * floor;

            if(value == Height)
                return Height;
            else 
                return value;
        }

        public void Read()
        {
            Console.WriteLine("1.Высота этажа\n2.Количество квартир в подъезде\n3.Количество квартир на этаже");
            string value = Console.ReadLine();
            switch(value)
            {
                case "1":
                    UpFloor();
                    break;

                case "2":
                    ApartmentsPorch();
                    break;

                case "3":
                    ApartmentsFloor();
                    break;

                default: 
                    Console.WriteLine("Диапазон от 1 до 3");
                    Read();
                    break;
            }
        }

        private void UpFloor()
        {
            Console.WriteLine($"Высота одного этажа: {heightbuild / floor}m");
        }
        
        private void ApartmentsPorch()
        {
            Console.WriteLine($"Количество квартир в подьезде: {apartments / porch}");
        }

        private void ApartmentsFloor()
        {
            Console.WriteLine($"Количество квартир на этаже: {(apartments / porch) / floor}");
        }
    }
}
