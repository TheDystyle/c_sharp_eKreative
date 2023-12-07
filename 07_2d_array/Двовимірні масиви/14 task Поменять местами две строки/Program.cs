using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_task_Поменять_местами_две_строки
{
    internal class Program
    {
        static string[] InitByKeyBoardLine(int n)
        {
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
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
        static void ChangeRowsLine(string[] arr, int p, int q)
        {
            string temp = arr[p];
            arr[p] = arr[q];
            arr[q] = temp;
        }

        static void PrintArr(string[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"{arr[i]} ");

            }
        }

        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);

            string[] myArr = InitByKeyBoardLine(n);

            string[] stringNum = Console.ReadLine().Trim().Split();
            int p = int.Parse(stringNum[0]) - 1;
            int q = int.Parse(stringNum[1]) - 1;

            ChangeRowsLine(myArr, p, q);
            PrintArr(myArr);
        }
    }
}