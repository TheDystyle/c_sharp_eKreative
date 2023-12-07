using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_task_Поменять_местами_строки_с_min_и_max
{
    internal class Program
    {
        static int[,] InputInitByKeyBoard(int n, int m)
        {
            int[,] fullArr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Trim().Split();
                int k = 0;
                for (int j = 0; j < m; j++)
                {
                    fullArr[i, j] = Int32.Parse(data[k]);
                    k++;
                    //Console.Write($"{fullArr[i,j]} ");
                }
            }
            return fullArr;
        }
        static void FindMaxMinElementAndChange(int[,] fullArr)
        {
            int max = int.MinValue;
            int indexMax = int.MinValue;

            int min = int.MaxValue;
            int indexMin = int.MaxValue;

            for (int i = 0; i < fullArr.GetLength(0); i++)
            {
                for (int k = 0; k < fullArr.GetLength(1); k++)
                {
                    if (fullArr[i,k] >= max)
                    {
                        max = fullArr[i,k];
                        indexMax = i;
                    }
                    if (fullArr[i,k] < min)
                    {
                        min = fullArr[i,k];
                        indexMin = i;
                    }
                }
            }


            for(int i = 0; i < fullArr.GetLength(1); i++)
            {
                int temp = 0;
                temp = fullArr[indexMax, i];
                fullArr[indexMax, i] = fullArr[indexMin, i];
                fullArr[indexMin, i] = temp;
            }
        }
        static void PrintArr(int[,] fullArr)
        {
            for (int i = 0; i < fullArr.GetLength(0); i++)
            {
                for (int k = 0; k < fullArr.GetLength(1); k++)
                {
                    Console.Write($"{fullArr[i, k]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {

            // вибрати строку з мін елементом
            // вибрати строку з макс елементом
            //
            //вибрати строчки з мін позиціями
            //
            //заміна місцями строчок 
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            //заповнюємо двовимірний масив
            int[,] fullArr = InputInitByKeyBoard(n, m);

            //пошук строк з мін і макс елементами та заміна цих строчок
            FindMaxMinElementAndChange(fullArr);

            //виводимо змінений масив
            PrintArr(fullArr);
        }
    }
}
