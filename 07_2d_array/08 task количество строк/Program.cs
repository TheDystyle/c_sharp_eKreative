using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_task_количество_строк
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
            
            for (int i = 0; i < n; i++)
            {
                int countEven = 0;
                int countOdd = 0;
                for (int j = 0; j < m; j++)
                {
                    
                    if (fullArr[i, j] % 2 == 0)
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
                    index += $"{i + 1} ";
                }
                //Console.WriteLine($"even - {countEven}, odd - {countOdd}");
                
            }
            Console.WriteLine(res);
            Console.WriteLine(index);
        }
        static void Main(string[] args)
        {
            //знайти кількість строк в яких парних елементів більше чим не парних
            // кількість
            //друга - вивести номери строчок - вивести за порядком зростання
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
