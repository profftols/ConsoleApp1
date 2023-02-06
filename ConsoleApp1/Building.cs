using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Building
    {
        private static int Numberbuild => 10;
        private int heightbuild;
        private int floor;
        private int apartments;
        private int porch;

        public void Build(int floor, int porch, int apartments)
        {
            this.floor = floor;
            this.porch = porch;
            this.apartments = apartments;

            heightbuild = floor * 4;
            this.apartments = floor * apartments;

        }

    }
}
