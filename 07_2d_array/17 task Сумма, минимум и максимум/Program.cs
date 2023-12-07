using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_task_Сумма__минимум_и_максимум
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
                    //Console.WriteLine($"position - {fullArr[i,j]}");
                }
            }
            return fullArr;
        }

        static void PrintSumMinMax(int[,] fullArr, int n, int m)
        {
            int sum = 0, min = int.MaxValue, max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    sum += fullArr[i, j];
                    if (fullArr[i,j] > max)
                    {
                        max = fullArr[i,j];
                    }
                    if (fullArr[i,j] < min)
                    {
                        min = fullArr[i,j];
                    }
                }
            }
            Console.WriteLine($"{sum} {min} {max}");
        }
        static void Main(string[] args)
        {
            // вивести суму, мін елементб макс елемент
            Console.OutputEncoding = Encoding.UTF8;
            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[,] fullArr = InputInitByKeyBoard(n, m);
            PrintSumMinMax(fullArr, n, m);

            //перевіряємо масив на заповнення
            //Console.WriteLine(" Початковий масив:");
            //for (int i = 0; i < n; ++i)
            //{
            //    for (int j = 0; j < m; ++j)
            //        Console.Write("\t" + fullArr[i, j]);
            //    Console.WriteLine();
            //}
        }
    }
}
