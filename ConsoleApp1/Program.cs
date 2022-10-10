using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Globalization;

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

        public static bool CheckWin(char sym)
        {
            for (int y = 0; y <= 2; y++)
            {
                if (CheckHorVert(y, sym) >= 3)
                    return true;
            }

            if (CheckDiag(sym) >= 3)
                return true;

            return false;
        }

        private static int CheckHorVert(int y, char sym)
        {
            int v = 0;
            for (int x = 0; x <= 2; x++) // check horizont
            {
                if (field[y, x] == sym ) 
                    v++;
                if (v == 3)
                    return v;
            }

            v = 0;
            for (int x = 0; x <= 2; x++) // check vertical
            {
                if (field[x, y] == sym)
                    v++;
                if (v == 3)
                    return v;
            }
            return v;

        }

        private static int CheckDiag(char sym)
        {
            int v = 0;
            
            for (int i = 0; i <= 2; i++) //check diagonal 1x1 2x2 3x3
            {
                if (field[i, i] == sym)
                    v++;
                if (v == 3)
                    return v;
            }

            v = 0;
            for (int i = 2; i >= 0; i--)
            {
                if (field[i, v] == sym)
                    v++;
                if (v == 3)
                    return v;
            }
            return v; 
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
                AiMove();
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
            Console.ReadKey();
        }
    }
}
