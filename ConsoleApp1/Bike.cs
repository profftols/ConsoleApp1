using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Bike : Vehicle
    {
        public override void Indicate(bool turningLeft)
        {
            base.Indicate(turningLeft);

            if (turningLeft)
                Console.WriteLine("Hand left");
            else
                Console.WriteLine("Hand ringt");
        }
    }
}
