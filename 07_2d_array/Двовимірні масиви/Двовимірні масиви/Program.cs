using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двовимірні_масиви
{
    internal class Program
    {
        //static void Avarage(int[,] arr, int m, int n)
        //{
        //    int sum = 0;
        //    int counter = 0;

        //    for(int i = 0; i < m; i++)
        //    {
        //        for(int j = 0; j < n; j++)
        //        {

        //            sum = sum + Math.Abs(arr[i, j]);
        //            counter++;
        //        }
        //    }

        //    Console.WriteLine($"sum - {sum}");
        //    Console.WriteLine($"counter - {counter}");
        //    Console.WriteLine($"avarage - {sum/counter}");
        //}

        //static void PositivElement(int[,] arr, int m, int n)
        //{
        //    int nPosEl;
        //    for (int i = 0; i < m; ++i)
        //    {
        //        nPosEl = 0;
        //        for (int j = 0; j < n; ++j)
        //        {
        //            if (arr[i, j] > 0) ++nPosEl;
        //        }
        //          Console.WriteLine(" У рядку {0} {1} додатніх ел-в", i, nPosEl);  
        //    }
        //}


        static void Main(string[] args)
        {

            int[,] a = {{ 4, -2, 3, 11, -5 },
                        { 7, 6, -8, 15, 7 },
                        { 5, 13, 1, -2, 17 }};
            for (int k = 4; k > 0; k--)
            {
                for (int j = 1; j <= k; j++)
                {
                    int sum1 = 0; 
                    for (int i = 0; i < 3; i++)
                    {
                        int temp = 0;
                        int n = Math.Abs(a[i, j]);
                        while (n > 0)
                        {
                            temp = n - (n / 10 * 10);
                            sum1 += temp;
                            n /= 10;
                        }
                        
                    }
                    Console.WriteLine(sum1);
                    int sum2 = 0;      
                    for (int i = 0; i < 3; i++)
                    {
                        int temp = 0;
                        int n = Math.Abs(a[i, j]);
                        while (n > 0)
                        {
                            temp = n - (n / 10 * 10);
                            sum1 += temp;
                            n /= 10;
                        }
                        
                    }
                    Console.WriteLine(sum2);
                    Console.WriteLine("-=-=-=-=-=-=-=-");
                    if (sum1 > sum2)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            int temp = a[i,j];
                            a[i,j] = a[i,j - 1];
                            a[i,j - 1] = temp;
                        }
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }

           

        }

    }
}
//    Console.OutputEncoding = Encoding.UTF8;
//    //// № рядка - 1й індекс
//    //// № рядка - 2й індекс

//    //const int m = 3, n = 3;
//    //int[,] a = new int[m, n] {{ -1,-1, -1 },{-1,-1,-1 },{ 1, 1, 1 }};


//    //Console.WriteLine(" Початковий масив:");
//    //for (int i = 0; i < m; ++i)
//    //{
//    //    for (int j = 0; j < n; ++j)
//    //        Console.Write("\t" + a[i, j]);
//    //    Console.WriteLine();
//    //}

//    //Avarage(a, m, n);
//    //PositivElement(a, m, n);

//    //////////////////////////
//    ///

//    int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//    const int n = 3, m = 3;
//    int[,] numbers = new int[n, m];
//    //int k = -1;
//    for (int i = 0; i < n; i++)
//    {

//        //k++;
//        for (int j = 0; j < m; j++)
//        {
//            numbers[i, j] = data[i];
//            //k++;
//        }
//    }

//    Console.WriteLine(" Початковий масив:");
//    for (int i = 0; i < m; ++i)
//    {
//        for (int j = 0; j < n; ++j)
//            Console.Write("\t" + numbers[i, j]);
//        Console.WriteLine();
//    }