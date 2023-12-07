using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_task__Сумма_трёх_элементов
{
    internal class Program
    {
        static long[] FullInArray(string x)
        {
            long[] fullArray = new long[21];
            fullArray[1] = Int64.Parse(x);

            for(int i=1; i <= 20;i++)
            {
                fullArray[i] = fullArray[i - 1] * (i - 10) + fullArray[1];
            }
            return fullArray;
        }

        static long SumOfItems(long[] arr, string someIndexes)
        {
            long sum = 0;
            string[] indexes = someIndexes.Trim().Split();
            long p = Int64.Parse(indexes[0]);
            long q = Int64.Parse(indexes[1]);
            long r = Int64.Parse(indexes[2]);
           
            sum = arr[p] + arr[q] + arr[r];

            return sum;
        }
        static void Main(string[] args)
        {
            long[] myArr = FullInArray(Console.ReadLine());
            Console.WriteLine(SumOfItems(myArr, Console.ReadLine()));
        }
    }
}
