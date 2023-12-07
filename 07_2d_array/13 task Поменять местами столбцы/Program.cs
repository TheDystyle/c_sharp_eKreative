using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task_Поменять_местами_столбцы
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
                   // Console.WriteLine($"position - {fullArr[i,j]}");
                }
            }
            return fullArr;
        }

        static int[,] ChangeColumn(int[,] fullArr, string qp)
        {
            string[] data = qp.Trim().Split();
            int p = Int32.Parse(data[0])-1;
            int q = Int32.Parse(data[1])-1;

            int temp = 0;

            for(int i= 0; i< fullArr.GetLength(0); i++)
            {
                temp = fullArr[i, q];
                fullArr[i,q] = fullArr[i,p];
                fullArr[i,p] = temp;
                //Console.WriteLine($"{fullArr[i,p]}"); 
            }

            return fullArr;
        }

        static void PrintChangeArr(int[,] changeArr)
        {
            for (int i = 0; i < changeArr.GetLength(0); i++)
            {
                for (int k = 0; k < changeArr.GetLength(1); k++)
                {
                    Console.Write($"{changeArr[i, k]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //заміна місцями вказаних стовбців
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            //заповнюємо двовимірний масив
            int[,] fullArr = InputInitByKeyBoard(n, m);

            //заміна стовбців
            int[,] changeArr = ChangeColumn(fullArr, Console.ReadLine());

            //вивести масив
            PrintChangeArr(changeArr);




        }
    }
}
