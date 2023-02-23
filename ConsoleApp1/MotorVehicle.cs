using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    internal class MotorVehicle : Vehicle
    {
        public override void Indicate(bool turningLeft)
        {
            if (turningLeft)
                Console.WriteLine("left ind");
            else
                Console.WriteLine("ringt ind");
        }
    }
}
