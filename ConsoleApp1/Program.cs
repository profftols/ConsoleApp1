using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task1();
            Task2();
            Task3();*/
            Task4();
        }

        static void Task1 () {
            string ask = Console.ReadLine();
            File.WriteAllText("startup.txt", ask);
        }

        static void Task2() {
            string ask = DateTime.Now.ToString();
            File.AppendAllText("startup.txt", ask);
        }

        static void Task3() {
            byte ask = byte.Parse(Console.ReadLine());
            byte[] bytes = new byte[1];
            bytes[0] = ask;
            File.WriteAllBytes("bytes.bin", bytes);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");
            for (int i = 0; i < fromFile.Length; i++) {
                Console.Write($" {fromFile[i]}");
            }
        }

        static void Task4() {
            Person[] persArray = new Person[5];
            persArray[0] = new Person("Ivan", "Engineer", "ivivan@mailbox.com", "892312312", 30000, 40);
            persArray[1] = new Person("Popre", "Sionir", "ivivan@mailbox.com", "892312313", 45000, 33);
            persArray[2] = new Person("Zolda", "Valadator", "ivivan@mailbox.com", "892312314", 35000, 70);
            persArray[3] = new Person("Jun", "Direcrit", "ivivan@mailbox.com", "892312315", 22000, 25);
            persArray[4] = new Person("Horker", "Joys", "ivivan@mailbox.com", "892312316", 34000, 55);

            for (int i = 0; i < persArray.Length; i++)
            {
                if(persArray[i].Age > 40)
                {
                    persArray[i].Print(); 
                }
            }
        }
    }
}
