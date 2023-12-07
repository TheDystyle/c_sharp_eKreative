using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_поменять_местами
{
    internal class Program
    {
        static int[,] InitByKeyBoard(int n, int m)
        {

            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Trim().Split();
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(data[j]);
                }
            }
            return arr;
        }

        static void ChangeRows(int[,] arr, int p, int q)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int temp = arr[p, j];
                arr[p, j] = arr[q, j];
                arr[q, j] = temp;
            }
        }

        static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            int[,] myArr = InitByKeyBoard(n, m);
            string[] stringNum = Console.ReadLine().Trim().Split();
            int p = int.Parse(stringNum[0]);
            int q = int.Parse(stringNum[1]);
            ChangeRows(myArr, p, q);
            PrintArr(myArr);
        }
    }
}



    
