using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_task_Вывод_двумерного_массива
{
    internal class Program
    {
        static int[] InputItemByKeyboard(string arr)
        {
           

            string[] arrString = arr.Trim().Split();

            int[] fullArray = new int[arrString.Length];

            
            for (int i = 0; i < fullArray.Length; i++)
            {
                fullArray[i] = Int32.Parse(arrString[i]);
            }

            return fullArray;
        }
        static void CreateArrayNM(int[] fullArray, int n, int m)
        {
            int[,] newArr = new int[n,m];
            int i = 0;
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < m; k++)
                {
                    newArr[j,k] = fullArray[i];
                    i++;
                    Console.Write($"{newArr[j, k]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = Int32.Parse(data[0]);
            int m = Int32.Parse(data[1]);

            int[] fullArray = InputItemByKeyboard(Console.ReadLine());
            CreateArrayNM(fullArray, n, m);
            // перевірка заповнення масиву
            //for (int i = 0; i < fullArray.Length; i++)
            //{
            //    Console.WriteLine(fullArray[i]);
            //}
        }
    }
}
