using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Vehicle
    {
        public virtual void Indicate(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("Left");
            else
                Console.WriteLine("Ringht");
        }
        public string Name { get; set; } = "asd";

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
