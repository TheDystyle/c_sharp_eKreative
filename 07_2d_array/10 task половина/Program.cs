using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task_половина
{
    internal class Program
    {
        static void InsertItemToArray(string nStr)
        {
            int n = Int32.Parse(nStr);

            int[,] arr = new int[n,n];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i + j == n - 1)
                    {
                        arr[i,j] = 0;
                    }
                    if(j + i > n - 1)
                    {
                        arr[i,j] = 1;
                    }
                    if (j + i < n - 1)
                    {
                        arr[i, j] = 2;
                    }
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            InsertItemToArray(Console.ReadLine());
        }
    }
}
