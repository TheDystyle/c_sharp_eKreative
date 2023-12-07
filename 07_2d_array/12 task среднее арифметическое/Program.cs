using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task_среднее_арифметическое
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

        static void AverageItemIMoreJ(int[,] fullArr, int n, int m)
        {
            int count = 0;
            double sum = 0;
            

            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(i > j)
                    {
                        count++;
                        sum += fullArr[i, j];
                    }
                }
            }
            double average = sum / count;
            Console.WriteLine($"{average:F6}");
        }
        static void Main(string[] args)
        {
            //знайти середнє арифметичне елементів де  i > j
            // точність 7.000000
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[,] fullArr = InputInitByKeyBoard(n, m);
            AverageItemIMoreJ(fullArr, n, m);
        }
    }
}
