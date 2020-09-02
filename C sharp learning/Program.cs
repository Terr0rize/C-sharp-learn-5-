using System;
using System.Collections.Generic; //массив, списки.
using System.Globalization;

namespace C_sharp_learning
{
    class MainClass
    {
        static void Main(string[] args) //метод срабатывает при старте программы
        {
            string[] names = new string[3]
            { "Ayrat", "Jenya", "Sanya"};
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Numberic of massiv: " + names[i] + "\n");
            }
            Console.WriteLine("________________________\n\n");


         int[] array = new int[5];
         array[0] = 24;
         array[1] = 45;
         array[2] = 75;
         array[3] = 88;
         array[4] = 56;
            //Console.WriteLine(array [4]); //вывод одного значения
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Numberic of massiv: " + array[i]);
            }
            Console.WriteLine("________________________\n\n");

            List<int> num = new List<int>();
            num.Add(23);
            num.Add(25);
            num.RemoveAt(0); //удаляет элемент листа
            //num.Remove(25); удаляет заданное числл
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine("Numberic of massiv: " + num[i] + "\n");
            }

            Console.WriteLine("________________________\n\n");
            int length = 10;
            int[,] dvumer = new int[length,length];           
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    dvumer[i, j] = i + j;
                    Console.Write(dvumer[i, j]);
                }
                Console.WriteLine();
            } 
            Console.ReadKey();

            

        }
    }
}
