using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_task_количество_столбцов
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

        static void MoreEvenItemThenOdd(int[,] fullArr, int n, int m)
        {
            int res = 0;
            string index = "";
            for (int j = 0; j < m; j++)
            {
                

                int countEven = 0;
                int countOdd = 0;
                for (int i = 0; i < n; i++)
                {
                    if (fullArr[i,j] %2 == 0)
                    {
                        countEven++;
                    }
                    if (fullArr[i, j] % 2 != 0)
                    {
                        countOdd++;
                    }
                }
                if (countEven > countOdd)
                {
                    res++;
                    index += $"{j+1} ";
                }
                //Console.WriteLine($"even - {countEven}, odd - {countOdd}");
            }
            Console.WriteLine(res);
            Console.WriteLine(index);
        }
        static void Main(string[] args)
        {
            //знайти кількість стовбців а також їх номери де парних чисел більше ніж непраних
            // перша строчка - кількість стовбців
            // друга - вивести номери стовбців - вивести за порядком зростання
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[,] fullArr = InputInitByKeyBoard(n, m);
            MoreEvenItemThenOdd(fullArr, n, m);
        }
    }
}
