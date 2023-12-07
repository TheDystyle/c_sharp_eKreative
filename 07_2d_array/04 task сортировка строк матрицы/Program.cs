using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task_сортировка_строк_матрицы
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
            //for(int i = 0; i < n; i++)
            //{
            //    for(int l = 0; l< m; l++)
            //    {
            //        Console.Write($"{fullArr[i, l]} ");
            //    }
            //    Console.WriteLine();
            //}
            return fullArr;
        }
        static int[] FindMaxAndMinNormInRow(int[,] fullArr)
        {
            // створюємо масив з суммами по строчкам
            int[] modulesArrRow = new int[fullArr.GetLength(0)];

            for (int i = 0; i < fullArr.GetLongLength(0); i++)
            {
                int sum = 0;
                for (int k = 0; k < fullArr.GetLength(1); k++)
                {
                    int temp = 0;

                    int n = Math.Abs(fullArr[i, k]);

                    while (n > 0)
                    {
                        temp = n - (n / 10 * 10);
                        sum += temp;
                        n /= 10;
                    }
                }
                modulesArrRow[i] = sum;
            }

            //перевірка заповнення
            //for (int i = 0; i < modulesArrRow.Length; i++)
            //{
            //    Console.Write($"{modulesArrRow[i]} ");
            //}
            return modulesArrRow;
        }
        static void SortRow(int[] modulesArrRow, int[,] fullArr)
        {
            //сортуємо масив за зростанням сум норми
            //і паралельно сортуємо вихідний масив
            for (int i = 0; i < modulesArrRow.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < modulesArrRow.GetLength(0) - i - 1; j++)
                {
                    if (modulesArrRow[j + 1] < modulesArrRow[j])
                    {
                        int temp = modulesArrRow[j + 1];
                        modulesArrRow[j + 1] = modulesArrRow[j];
                        modulesArrRow[j] = temp;

                        for (int k = 0; k < fullArr.GetLength(1); k++)
                        {
                            int temp2 = fullArr[j + 1, k];
                            fullArr[j + 1, k] = fullArr[j, k];
                            fullArr[j, k] = temp2;
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
            // cума цифр у рядку + сортування за зростанням норми 

            //строчка для відображення кирилиці
            Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            //заповнюємо масив
            int[,] fullArr = InputInitByKeyBoard(n, m);

            //знаходимо норми по строчкам
            int[] modulesArrRow = FindMaxAndMinNormInRow(fullArr);

            //сортуємо нормиі паралельно вихідний масив
            SortRow(modulesArrRow, fullArr);

            //друк вихідного масиву
            Print(fullArr,n,m);
        }
    }
}


//public class Test
//{

//    static int[,] InitByKeyBoardLine(int n, int m)
//    {
//        int[,] arr = new int[n, m];
//        string[] str_arr;
//        for (int i = 0; i < n; i++)
//        {
//            str_arr = (Console.ReadLine()).Split(' ');
//            for (int j = 0; j < m; j++)
//            {
//                arr[i, j] = Convert.ToInt32(str_arr[j]);
//            }
//        }
//        return arr;
//    }

//    static void SumArrRow(int[,] arr, int n, int m)
//    {
//        int[] arrSum = new int[n];
//        for (int i = 0; i < n; i++)
//        {
//            int res = 0;
//            for (int j = 0; j < m; j++)
//            {
//                string text = Math.Abs(arr[i, j]).ToString();
//                for (int k = 0; k < text.Length; k++)
//                {
//                    int b = int.Parse($"{text[k]}");
//                    res += b;
//                }
//            }
//            arrSum[i] = res;
//        }


//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if (arrSum[j + 1] < arrSum[j])
//                {
//                    int temp = arrSum[j + 1];
//                    arrSum[j + 1] = arrSum[j];
//                    arrSum[j] = temp;

//                    for (int k = 0; k < m; k++)
//                    {
//                        int temp2 = arr[j + 1, k];
//                        arr[j + 1, k] = arr[j, k];
//                        arr[j, k] = temp2;
//                    }
//                }
//            }
//        }

//        // for (int i = 0; i < arrSum.Length; i++)
//        // {
//        //     Console.WriteLine(arrSum[i]);
//        // }

//        for (int i = 0; i < arr.GetLength(0); i++)
//        {
//            for (int j = 0; j < arr.GetLength(1); j++)
//            {
//                Console.Write($"{arr[i, j]} ");
//            }
//            Console.WriteLine();
//        }
//    }


//    static void Main(string[] args)

//    {
//        string[] data = Console.ReadLine().Trim().Split();
//        int n = int.Parse(data[0]);
//        int m = int.Parse(data[1]);

//        SumArrRow(InitByKeyBoardLine(n, m), n, m);
//    }

//}