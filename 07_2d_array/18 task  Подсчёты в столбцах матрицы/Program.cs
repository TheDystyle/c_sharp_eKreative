using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_task__Подсчёты_в_столбцах_матрицы
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

        static void PrintDifferenceInEachColumn(int[,] fullArr, int n, int m)
        {
            for(int j = 0; j < m; j++)
            {
                int sumEven = 0;
                int sumOdd = 0;
                for (int i = 0; i < n; i++)
                {
                    if (fullArr[i,j] %2 == 0)
                    {
                        sumEven += fullArr[i, j];
                    }
                    if (fullArr[i,j] %2 != 0)
                    {
                        sumOdd += fullArr[i,j];
                    }
                }
                Console.Write($"{Math.Abs(sumEven - sumOdd)} ");
            }
        }
        static void Main(string[] args)
        {
            // різниці між парними і неапарними в кожному стовбці
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[,] fullArr = InputInitByKeyBoard(n, m);
            PrintDifferenceInEachColumn(fullArr, n, m);
        }
    }
}
