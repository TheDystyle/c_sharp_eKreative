using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task__Объединение_последовательностей
{
    internal class Program
    {
        static long[] ArrayFillingSquareAndCube(int n)
        {
            long[] arrMult = new long[n * 2];

            //заповнюємо першу частину масиву квадратами
            for (int i = 1; i < n; i++)
            {
                arrMult[i] = (i + 1) * (i + 1);
            }
            // Console.WriteLine("square ");

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(arrMulty[i]);
            //}


            //заповнюємо масив кубами
            for (int i = n, k = 1; i < n * 2; i++, k++)
            {
                arrMult[i] = k * k * k;
            }
            //Console.WriteLine("cube ");
            //for (int i = n; i < n*2; i++)
            //{
            //    Console.WriteLine(arrMulty[i]);
            //}
            //for (int i = 0; i < n * 2; i++)
            //{
            //    Console.WriteLine(arrMult[i]);
            //}
            return arrMult;
        }
        static void SortArray(long[] arrMult, int n)
        {
            //int lenght = arrMult.Length;
            //int temp, smallest;
            //for (int i = 0; i < lenght - 1; i++)
            //{
            //    smallest = i;
            //    for (int j = i + 1; j < lenght; j++)
            //    {
            //        if (arrMult[j] < arrMult[smallest])
            //        { smallest = j; }
            //    }
            //    temp = arrMult[smallest];
            //    arrMult[smallest] = arrMult[i];
            //    arrMult[i] = temp;
            //}
            int min;
            for(int i = 0; i < arrMult.Length; i++)
            {
                min = i;
                long temp;
                for(int j = i + 1; j < arrMult.Length; j++)
                {
                    //if (arrMult[j] == arrMult[min])
                    //{
                    //    arrMult[n+n-3] = arrMult[j];
                    //    min = j+1;
                    //}
                    //else
                    //{
                        if (arrMult[j] <= arrMult[min])
                        {
                            min = j;
                        }
                    //}
                }
                temp = arrMult[min];
                arrMult[min] = arrMult[i];
                arrMult[i] = temp;

            }
            //for (int i = 0; i < n * 2; i++)
            //{
            //    Console.Write($"{arrMult[i]} ");
            //}
            //Console.WriteLine();
            Console.WriteLine(arrMult[n]);
        }
        static void Main(string[] args)
        {
            //int n = Int32.Parse(Console.ReadLine());
            //long[] arrMult = ArrayFillingSquareAndCube(n);
            //SortArray(arrMult, n);

            //  чесно списана  )))
            long k = Convert.ToInt32(Console.ReadLine());
            long a = 1;
            long b = 1;
            long result = 0;
            for(int i = 1; i <= k; i++)
            {
                if (a*a < b * b * b)
                {
                    result = a * a++;
                }
                else if (a*a > b * b * b)
                {
                    result = b * b * b++;
                }
                else if (a*a == b * b * b)
                {
                    b++;
                    result = a*a++;
                }
            }
            Console.WriteLine(result);

        }
    }
}