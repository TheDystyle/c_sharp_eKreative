using System;

namespace _09_task__переворот
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

        static int[,] Rotate(int[,] fullArr)
        {
            int[,] RotateArr = new int[fullArr.GetLength(1), fullArr.GetLength(0)];
            int k = 0;
            for (int j = 0; j < fullArr.GetLength(1); j++)
            {
                int w = 0;
                for (int i = fullArr.GetLength(0) - 1; i >= 0; i--)
                {
                    RotateArr[k, w] = fullArr[i, j];
                  // Console.Write($"{RotateArr[k, w]} ");
                    w++;
                }
                k++;
              // Console.WriteLine();
            }
            return RotateArr;
        }

        static void PrintArr(int[,] rotateArr, int n, int m)
        {
            Console.WriteLine($"{m} {n}");
            for (int i = 0; i < rotateArr.GetLength(0); i++)
            {
               for (int k = 0; k < rotateArr.GetLength(1); k++)
                {
                    Console.Write($"{rotateArr[i,k]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // вказуємо розмірність нашого масиву
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[,] fullArr = InputInitByKeyBoard(n, m);
            int[,] RotateArr = Rotate(fullArr);
            PrintArr(RotateArr, n, m);
        }
    }
}
