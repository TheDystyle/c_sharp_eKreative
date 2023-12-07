using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task_удаление_элемента
{
    internal class Program
    {
        static int[] InputItemArrayByKeyboard(string nString, string mString)
        {
            int n = Int32.Parse(nString);

            // фактично створюємо масив на 1 елемент більше - нумерація по задачі іде з 1
            int[] fullArray = new int[n+1];

            //у строчці на 1 елемент менше - тому робимо зсув у циклі
            // 0 0 0 0 масив
            //   1 2 3 строка
            // тому цикл починається з 1 а з масиву строчки беремо елемент і-1
            // 0й елемент строчки = 1му елементу масиву

            string[] data = mString.Trim().Split();
            for (int i = 1; i < fullArray.Length; i++)
            {
                fullArray[i] = Int32.Parse(data[i-1]);
                //Console.WriteLine(fullArray[i]);
            }

            //for(int i = 0; i < fullArray.Length; i++)
            //{
            //    Console.WriteLine(fullArray[i]);
            //}

            return fullArray;
        }
        static void ReturnArrayWithoutOneNubmer(string bString, int[] fullArray)
        {
            int b = Int32.Parse(bString);
            //Console.WriteLine($"b = {b}");
            for(int i = 1; i < fullArray.Length-1; i++)
            {
                
                if(i >= b)
                {
                    fullArray[i] = fullArray[i + 1];
                }
                Console.WriteLine(fullArray[i]);
            }

            //Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            ReturnArrayWithoutOneNubmer(Console.ReadLine(),fullArray);
        }
    }
}
