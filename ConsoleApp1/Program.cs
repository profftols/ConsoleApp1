using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;


namespace ConsoleApp1
{

    class Program
    {
        static int SIZE_X = 3;
        static int SIZE_Y = 3;

        static char[,] field = new char[SIZE_Y, SIZE_X];

        static char PLAYER_DOT = 'X';
        static char AI_DOT = 'O';
        static char EMPTY_DOT = '.';

        static Random random = new Random();

        private static void InitField()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    field[i, j] = EMPTY_DOT;
                }
            }
        }

        private static void PrintField()
        {
            Console.Clear();
            Console.WriteLine("-------");
            for (int i = 0; i < SIZE_Y; i++)
            {
                Console.Write("|");
                for (int j = 0; j < SIZE_X; j++)
                {
                    Console.Write(field[i, j] + "|");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------");
        }

        private static void SetSym(int y, int x, char sym)
        {
            field[y, x] = sym;
        }

        private static bool IsCellValid(int y, int x)
        {
            if (x < 0 || y < 0 || x > SIZE_X - 1 || y > SIZE_Y - 1)
            {
                return false;
            }

            return field[y, x] == EMPTY_DOT;
        }

        private static bool IsFieldFull()
        {
            for (int i = 0; i < SIZE_Y; i++)
            {
                for (int j = 0; j < SIZE_X; j++)
                {
                    if (field[i, j] == EMPTY_DOT)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void PlayerMove()
        {
            int x, y;
            do
            {
                Console.WriteLine("Координат по строке ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_Y);
                x = Int32.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Координат по столбцу ");
                Console.WriteLine("Введите координаты вашего хода в диапозоне от 1 до " + SIZE_X);
                y = Int32.Parse(Console.ReadLine()) - 1;
            } while (!IsCellValid(y, x));
            SetSym(y, x, PLAYER_DOT);
        }

        private static bool CheckWin(char sym)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (field[0, i] == sym | field[i, 2] == sym)
                {
                    if (i == 2)
                        return true;
                }
            }
            /*
            if (field[0, 0] == sym && field[0, 1] == sym && field[0, 2] == sym)
            {
                return true;
            }
            if (field[1, 0] == sym && field[1, 1] == sym && field[1, 2] == sym)
            {
                return true;
            }
            if (field[2, 0] == sym && field[2, 1] == sym && field[2, 2] == sym)
            {
                return true;
            }

            if (field[0, 0] == sym && field[1, 0] == sym && field[2, 0] == sym)
            {
                return true;
            }
            if (field[0, 1] == sym && field[1, 1] == sym && field[2, 1] == sym)
            {
                return true;
            }
            if (field[0, 2] == sym && field[1, 2] == sym && field[2, 2] == sym)
            {
                return true;
            }

            if (field[0, 0] == sym && field[1, 1] == sym && field[2, 2] == sym)
            {
                return true;
            }
            if (field[2, 0] == sym && field[1, 1] == sym && field[0, 2] == sym)
            {
                return true;
            }*/
            return false;
        }

        private static void AiMove()
        {
            int x, y;
            do
            {
                x = random.Next(0, SIZE_X);
                y = random.Next(0, SIZE_Y);
            } while (!IsCellValid(y, x));
            SetSym(y, x, AI_DOT);
        }


        static void Main(string[] args)
        {
            InitField();
            PrintField();
            do
            {
                PlayerMove();
                Console.WriteLine("ваш ход на поле");
                PrintField();
                if (CheckWin(PLAYER_DOT))
                {
                    Console.WriteLine("вы выиграли");
                    break;
                }
                else if (IsFieldFull()) break;
                //AiMove();
                Console.WriteLine("ход компа на поле");
                PrintField();
                if (CheckWin(AI_DOT))
                {
                    Console.WriteLine("выиграли комп");
                    break;
                }
                else if (IsFieldFull()) break;
            } while (true);
            Console.WriteLine("!конец игры!");
        }
    }
}
