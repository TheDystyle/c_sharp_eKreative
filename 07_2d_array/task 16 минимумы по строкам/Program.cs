using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_16_минимумы_по_строкам
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
        static void PrintMinElementInRow(int[,] fullArr, int n, int m)
        {
            

            for (int i = 0; i < n; i++)
            {
                int min = fullArr[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (fullArr[i, j] < min)
                    {
                        min = fullArr[i, j];
                    }
                }
                Console.WriteLine($"{min} ");
            }
            
        }
        static void Main(string[] args)
        {
            // мін елемент в кожній строчці
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[,] fullArr = InputInitByKeyBoard(n, m);
            PrintMinElementInRow(fullArr, n, m);
        }
    }
}
