using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_task__Сортировка_периметра
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
        static int[] SelectionPerimetr(int[,] fullArr, int n, int m)
        {
            //створюємо масив розміром (n+m)*2-4... -4 бо у сторон 4 спільні точки

            int[] perimetrArr = new int[(n+m)*2-4];

            // лічильник зайнятих позицій
            int counter = 0;

            int height = fullArr.GetLength(0), width = fullArr.GetLength(1);
            //Console.WriteLine(width);
            //Console.WriteLine(height);

            // 1st row
            for (int i = 0; i < width; i++)
            {
                perimetrArr[counter] = fullArr[0, i];
                //Console.Write($"{perimetrArr[counter]} ");
                counter++;
            }
            // last row
            for (int i = 0; i < width; i++)
            {
                perimetrArr[counter] = fullArr[height-1, i];
                //Console.Write($"{perimetrArr[counter]} ");
                counter++;
            }

            // 1st column
            for (int i = 1; i < height-1; i++)
            {
                perimetrArr[counter] = fullArr[i,0];
                //Console.Write($"{perimetrArr[counter]} ");
                counter++;
            }

            // last column
            for (int i = 1; i < height - 1; i++)
            {
                perimetrArr[counter] = fullArr[i, width-1];
                //Console.Write($"{perimetrArr[counter]} ");
                counter++;
            }

            // превірка заповнення масиву значеннями периметра
            //for (int i = 0; i < perimetrArr.Length; i++)
            //{
            //    Console.Write($"{perimetrArr[i]} ");
            //}
            //Console.WriteLine($"\n counter - {perimetrArr.Length} \n counter - {counter}");

            return perimetrArr;
        }
        static void SortAndPrint(int[] perimetrArr)
        {
            int t = 0;
            for (int i = 0; i < perimetrArr.Length - 1; ++i)
            {
                for (int j = i + 1; j < perimetrArr.Length; ++j)
                {
                    if (Math.Abs(perimetrArr[j]) > Math.Abs(perimetrArr[i]))
                    {
                        t = perimetrArr[j];
                        perimetrArr[j] = perimetrArr[i];
                        perimetrArr[i] = t;
                    }
                    else if (Math.Abs(perimetrArr[j]) == Math.Abs(perimetrArr[i]) && perimetrArr[j] > perimetrArr[i])
                    {
                        t = perimetrArr[j];
                        perimetrArr[j] = perimetrArr[i];
                        perimetrArr[i] = t;
                    }
                }
            }
           
            
        }

        static void PrintArray(int[] perimetrArr)
        {
            // превірка заповнення масиву значеннями периметра
            for (int i = 0; i < perimetrArr.Length; i++)
            {
                Console.Write($"{perimetrArr[i]} ");
            }
        }
        static void Main(string[] args)
        {
            // вибрати числа по периметру та вивести їх за неспаданням
            // -10 9 -5 4 4 3 3 2 -2 1

            //строчка для відображення кирилиці
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            //заповнюємо двовимірний масив
            int[,] fullArr = InputInitByKeyBoard(n, m);

            //вибираємо периметр і вносимо в одновимірний масив
            int[] perimetrArr = SelectionPerimetr(fullArr,n,m);

            //сортуємо  в одновимірний масив
            SortAndPrint(perimetrArr);

            // друкуємо одновимірний масив
            PrintArray(perimetrArr);

        }
    }
}
