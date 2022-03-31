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

        enum Season
        {
            Winter,
            Vesna,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] temp = new int[9];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = rand.Next(-25, 40);
            }

            //int[] temp = { -5, 0, 2, 6 };
            Forchseason(temp);
            
        }
        static void Forchseason(int[] temp)
        {
            int colt = 0;
            int polo = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < 0)
                {
                    colt++;
                }
                if (temp[i] > 0)
                {
                    polo++;
                }                           
            }

            if (colt > polo)
            {
                Console.WriteLine((Season)0);
            }
            if (polo > colt)
            {
                Console.WriteLine((Season)2);
            }
            if (colt == polo)
            {
                Console.WriteLine((Season)1);
                Console.WriteLine((Season)3);
            }
            
        }

    }
}