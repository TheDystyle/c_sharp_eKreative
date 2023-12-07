using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_task__Сортировка_столбцов_матрицы
{
    internal class Program
    {
        static int[,] InputInitByKeyBoard(int n, int m)
        {
            int[,] fullArr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Trim().Split();
                for (int j = 0; j < m; j++)
                {
                    fullArr[i, j] = Int32.Parse(data[j]);
                    //Console.Write($"{fullArr[i,j]} ");
                }
            }

            //первірка заповнення
            //for (int i = 0; i < n; i++)
            //{
            //    for (int l = 0; l < m; l++)
            //    {
            //        Console.Write($"{fullArr[i, l]} ");
            //    }
            //    Console.WriteLine();
            //}
            return fullArr;
        }

        static int[] FindMaxAndMinNormInColumn(int[,] fullArr)
        {
            // створюємо масив з суммами по стовпчикам
            int[] modulesArrColumn = new int[fullArr.GetLength(1)];

            for(int i = 0; i < fullArr.GetLongLength(1); i++)
            {
                int sum = 0;
                for (int k = 0; k < fullArr.GetLength(0); k++)
                {
                    int temp = 0;
                    
                    int n = Math.Abs(fullArr[k,i]);

                    while (n > 0)
                    {
                        temp = n - (n / 10 * 10);
                        sum += temp;
                        n /= 10;
                    }
                }
                modulesArrColumn[i] = sum;
            }

            //перевірка заповнення
            //for (int i = 0; i < modulesArrColumn.Length; i++)
            //{
            //    Console.Write($"{modulesArrColumn[i]} ");
            //}
            return modulesArrColumn;
        }

        static void SortColumn(int[] modulesArrColumn, int[,] fullArr)
        {
            //сортуємо масив за зростанням сум норми
            //і паралельно сортуємо вихідний масив
            for (int i = 0; i < modulesArrColumn.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < modulesArrColumn.GetLength(0) - i - 1; j++)
                {
                    if (modulesArrColumn[j + 1] < modulesArrColumn[j])
                    {
                        //Console.Write($"1st before {modulesArrColumn[j]} та {modulesArrColumn[j + 1]} || ");
                        int temp = modulesArrColumn[j + 1];
                        modulesArrColumn[j + 1] = modulesArrColumn[j];
                        modulesArrColumn[j] = temp;
                       // Console.Write($"after {modulesArrColumn[j]} та {modulesArrColumn[j + 1]} || ");

                        for (int k = 0; k < fullArr.GetLength(0); k++)
                        {
                            //Console.Write($"2nd before {fullArr[k, j]} та {fullArr[k, j + 1]} || ");
                            int temp2 = fullArr[k, j + 1];
                            fullArr[k, j + 1] = fullArr[k,j];
                            fullArr[k, j] = temp2;
                           // Console.Write($"after {fullArr[k, j]} та {fullArr[k, j + 1]} || ");
                        }
                    }
                }
            }
        }
        static void Print(int[,] fullArr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < m; l++)
                {
                    Console.Write($"{fullArr[i, l]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // cума цифр у стовбчику + сортування за зростанням норми 

            //строчка для відображення кирилиці
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[,] fullArr = InputInitByKeyBoard(n, m);
           
            //знаходимо норми по стовбчикам
            int[] modulesArrColumn = FindMaxAndMinNormInColumn(fullArr);

            //сортуємо норми і паралельно вихідний масив
            SortColumn(modulesArrColumn, fullArr);

            //друк вихідного масиву
            Print(fullArr, n, m);
        }
    }
}
