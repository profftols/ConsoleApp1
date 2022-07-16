using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;


namespace ConsoleApp1
{

    class Program
    {

        [Serializable]
        public class MyArraySizeExeption : Exception { }
        public class MyArrayDateExeption : Exception { }
        static void Main(string[] args)
        {
            TaskManager();

            string[,] array = new string[4, 4]
                               { 
                                { "3", "5", "3", "1" }, 
                                { "3", "6", "3", "1" }, 
                                { "5", "z", "6", "1" }, 
                                { "2", "2", "1", "2" } 
                               };

            ArraySum(array);
            //ArrayDataException();
            //Task4();
        }
        
        static void TaskManager() {
            Process[] proc = Process.GetProcesses();
            for (int i = 0, j = 0; i < proc.Length; i++, j++)
            {
                Console.WriteLine($"{j}, {proc[i].Id} - {proc[i].ProcessName} ");
            }
            Console.WriteLine("Введите id процесса для закрытие задачи");
            int id = int.Parse(Console.ReadLine());
            proc[id].Kill();
        }
        static void ArraySum(string[,] array) {

            int sum = 0;

            if (array.Length != 17) 
            {
                Console.WriteLine("Массив прывышает заданнных размером 4х4");
                throw new MyArraySizeExeption();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    try
                    {
                        sum += Int32.Parse(array[i, k]);
                    } 
                    catch
                    {
                        Console.WriteLine($"Ошибка в секторе массива: {i} - {k}, {array[i, k]} \nСумма массива: {sum}");
                        throw new MyArrayDateExeption();
                    }
                }
            }
            Console.WriteLine($"Сумма массива: {sum}");
        }
        /*

        static void ArrayDataException(string[,] array) {
            
        }
        static void Task4() {
            
        }*/
    }
}
