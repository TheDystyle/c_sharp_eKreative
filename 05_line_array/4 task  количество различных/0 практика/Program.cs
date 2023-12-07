using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_практика
{
    internal class Program
    {
        //передача за показчиком через ref
        static void Fun1 (ref int x, ref int y)
        {
            if (x > y)
            {
                x -= 2;
                y += 3;
            }
            else
            {
                y -= 2;
                x += 3;
            }
        }
        //передача за значенням - ініціалізація обов'язкова
        static double Average(double a, double b, double c)
        {
            return (a + b + c)/3;
        }

        //передача через out - 1 variant
        static void MinMax(int c1, int c2, out int max, out int min)
        { 
            if (c1 > c2)
            {
                max = c1;
                min = c2;
            }
            else
            {
                max = c2;
                min = c1;
            }
        }
        //передача через out - 2 variant
        static void ReturnOut2 (out int a, out string s)
        {
            a = 12345;
            s = "here text";
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //void - якщо нічого не повертає
            //
            //якщо відмінне від void, то return обов'язковий


            ///////////////////передача за значенням - ініціалізація обов'язкова
            /*double a, b, c;
            Console.WriteLine("Input a...");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input b...");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Input c...");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine(Average(a,b,c));

            //////////////передача через ref
            int d, e;
            Console.WriteLine("Input d..");
            d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input e..");
            e = Int32.Parse(Console.ReadLine());

             Fun1(ref d, ref e);

            Console.WriteLine($"d = {d}, e = {e}");*/

            /////////////////////передача через out - 1 variant
            /*int c1, c2;

            Console.WriteLine("Input c1...");
            c1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input c2...");
            c2 = Int32.Parse(Console.ReadLine());
            int min, max;
            MinMax(c1, c2, out max, out min);
            Console.WriteLine($"max = {max}, min = {min}");*/

            //передача через out - 2 variant
            int a;
            string s;

            ReturnOut2(out a, out s);

            Console.WriteLine($"a = {a}, s = {s}");
        }
    }
}

//////////////сумма цифр кожного із значень масиву
/*
static int[] SumItemArrey(int[] arr)
{
   int[] sumArray = arr;

   for (int i = 0; i < sumArray.Length; i++)
   {
       int temp = 0;
       int sum = 0;
       while (sumArray[i] > 0)
       {
           temp = sumArray[i] - (sumArray[i] / 10 * 10);
           sum += temp;
           sumArray[i] /= 10;
       }
       sumArray[i] = sum;
   }
   return sumArray;
}*/
//////////////// вводимо елементи масиву однією строчкою
/*static int[] InputByKeyBoardString(string str, int n)
{
    string[] date = str.Trim().Split();
    int[] arr = new int[n];
    //видалити/закоментувати виведення
    //Console.WriteLine($"lenght array - {date.Length}");
    for (int i = 0; i < n; i++)
    {
        arr[i] = Int32.Parse(date[i]);
        //видалити/закоментувати виведення
        //Console.WriteLine(arr[i]);
    }
    return arr;
}*/

///////заготовка (прац не правильно) визначення макс і мін
/*
 *   static void MinMaxItem(int[] arr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int temp = 0;

            for(int i = 1;i < arr.Length;i++)
            {
                if (arr[i] > max)
                {
                    temp = max;
                    max = arr[i];
                }
                if (temp < min)
                {
                    min = temp;
                }
            }
            Console.WriteLine($"{max}\n{min}");
        }
*/







/* static void Print(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

        }

        static int[] InitByKeyBoard(int n)
            {
            int[] arr = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
            return arr;
            }

        static int[] InitByRandom(int n)
        {
            int[] arr = new int[n];
            var rand = new Random();
            for (int i = 0;i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100,100);
            }
            return arr;
        }*/