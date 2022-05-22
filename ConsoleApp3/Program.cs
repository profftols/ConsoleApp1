using System;

namespace ConsoleApp3
{

    class Program
    {
        enum Season
        {
            winter = -1,
            spring = 0,
            summer = 1
        }

        static void GetSeason(int[] par)
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < par.Length; i++)
            {
                if (par[i] >= 0)
                {
                    a += par[i];
                }
                else
                {
                    b += par[i];
                }

                if (i >= par.Length - 1)
                {
                    int v = a + b;

                    if (v > 0)
                    {
                        Console.WriteLine((Season)1);
                        return;
                    }
                    else if (v < 0)
                    {
                        Console.WriteLine(Season.winter);
                        return;
                    }
                    else
                    {
                        Console.WriteLine(Season.spring);
                        return;
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            /*Random rand = new Random();

            int[] seas = new int[5];

            for (int i = 0; i < seas.Length; i++)
            {
                seas[i] = rand.Next(-4, 4);
            }
            */
            int[] seas = { 0, 1, 5, 6 };
            GetSeason(seas);
        }
    }
}