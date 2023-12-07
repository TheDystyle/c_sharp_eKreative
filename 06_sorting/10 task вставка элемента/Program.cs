using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task_вставка_элемента
{
    internal class Program
    {
        static int[] InputItemArrayByKeyboard(string nString, string mString)
        {
            int n = Int32.Parse(nString);

            // фактично створюємо масив на 1 елемент більше - нумерація по задачі іде з 1
            int[] fullArray = new int[n + 1];

            //у строчці на 1 елемент менше - тому робимо зсув у циклі
            // 0 0 0 0 масив
            //   1 2 3 строка
            // тому цикл починається з 1 а з масиву строчки беремо елемент і-1
            // 0й елемент строчки = 1му елементу масиву

            string[] data = mString.Trim().Split();
            for (int i = 1; i < fullArray.Length; i++)
            {
                fullArray[i] = Int32.Parse(data[i - 1]);
            }

            //перевірка заповнення масиву
            //- за потреби розкоментувати
            //for (int i = 0; i < fullArray.Length; i++)
            //{
            //    Console.Write($"{fullArray[i]} ");
            //}

            return fullArray;
        }

        static void InsertOnePositionAndPrint(int[] fullArray, string bcStr)
        {
            string[] bc = bcStr.Trim().Split();
            int b = Int32.Parse(bc[0]);
            int c = Int32.Parse(bc[1]);

           Array.Resize(ref fullArray, fullArray.Length + 1);

            //перевірка Resize
            //Console.WriteLine("Resize");
            //for (int i = 0; i < fullArray.Length; i++)
            //{
            //    Console.Write($"{fullArray[i]} ");
            //}
           // Console.WriteLine("\n");


            //Console.WriteLine("go to first element");
            for (int i = fullArray.Length - 1; i > b; i--)
            {
                fullArray[i] = fullArray[i - 1];
                //Console.WriteLine(fullArray[i]);
            }
            fullArray[b] = c;

            Console.WriteLine("\n");
            //перевірка Resize
            //for (int i = 1; i < fullArray.Length; i++)
            //{
            //    Console.Write($"{fullArray[i]} ");
            //}
        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            InsertOnePositionAndPrint(fullArray, Console.ReadLine());
        }
    }
}
