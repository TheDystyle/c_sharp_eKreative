using System;
using System.Text;

namespace _06_task_Поменять_местами_столбцы_с_min_и_max
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
                }
            }
            return fullArr;
        }
        static int[,] FindMaxMinElementAndChange(int[,] fullArr, int n, int m)
        {
            int max = int.MaxValue;
            int min = int.MinValue;
            int indexMax = 0;
            int indexMin = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (fullArr[j, i] < max)
                    {
                        max = fullArr[j, i];
                        indexMin = i;
                    }

                    if (fullArr[j, i] >= min)
                    {
                        min = fullArr[j, i];
                        indexMax = i;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                int temp = fullArr[i, indexMax];
                fullArr[i, indexMax] = fullArr[i, indexMin];
                fullArr[i, indexMin] = temp;
            }
            return fullArr;
        }
        //static void FindMaxMinElementAndChange(int[,] fullArr, int n, int m)
        //{
        //    int min = int.MaxValue;
        //    int max = int.MinValue;
        //    int indexMin = 0;
        //    int indexMax = 0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int k = 0; k < m; k++)
        //        {
        //            if (fullArr[i, k] >= max)
        //            {
        //                max = fullArr[i, k];
        //                indexMax = k;
        //            }
        //            if (fullArr[i, k] < min)
        //            {
        //                min = fullArr[i, k];
        //                indexMin = k;
        //            }
        //        }
        //    }

        //    // заміна стовбців
        //    for (int i = 0; i < n; i++)
        //    {
        //        int temp = 0;
        //        temp = fullArr[i, indexMax];
        //        fullArr[i, indexMax] = fullArr[i, indexMin];
        //        fullArr[i, indexMin] = temp;
        //    }

        //}
        static void PrintArr(int[,] fullArr)
        {
            for (int i = 0; i < fullArr.GetLength(0); i++)
            {
                for (int k = 0; k < fullArr.GetLength(1); k++)
                {
                    Console.Write($"{fullArr[i, k]} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // вибрати стовбчик з мін елементом з мін знач стовбчика
            // вибрати стовбчик з макс елементом з макс знач стовбчика
            //
            //заміна місцями стовбчиків 

            //строчка для відображення кирилиці
            //Console.OutputEncoding = Encoding.UTF8;

            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            //заповнюємо двовимірний масив
            int[,] fullArr = InputInitByKeyBoard(n, m);

            //пошук стовбчиків з мін і макс елементами та заміна цих стовбчиків
            FindMaxMinElementAndChange(fullArr, n, m);

            //виводимо змінений масив
            PrintArr(fullArr);
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