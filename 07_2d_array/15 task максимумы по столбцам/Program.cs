using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_task_максимумы_по_столбцам
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
        static void PrintMaxElementInColumn(int[,] fullArr, int n, int m)
        {

            
            for (int j = 0; j < m; j++)
            {
                int max = int.MinValue;
                for (int i = 0; i < n; i++)
                {
                    if (fullArr[i,j] > max)
                    {
                        max = fullArr[i,j];
                    }
                }
                
                Console.Write($"{max} ");
            }

        }
        static void Main(string[] args)
        {
            // макс елемент в кожному стовбці
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[,] fullArr = InputInitByKeyBoard(n, m);
            PrintMaxElementInColumn(fullArr, n, m);
        }
    }
}
