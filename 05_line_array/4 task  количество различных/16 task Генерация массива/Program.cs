using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_task_Генерация_массива
{
    internal class Program
    {
       static long[] InputItemToArray(int x)
        {
            long[] newNumbers = new long[10];
            newNumbers[0] = x;

            for (int i = 1; i < 10; i++)
            {
                newNumbers[i] = newNumbers[i-1] * newNumbers[i - 1] % 100 - 5 * newNumbers[i - 1] + 6;
            }
            return newNumbers;
        }

        static string PrintElementsOfArray(long[] arr)
        {
            string printArray = "";
            for(int i=0;i < arr.Length; i++)
            {
                printArray += arr[i] + " ";
            }
            return printArray;
        }
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());

            long[] newNumbers = InputItemToArray(x);
            Console.WriteLine(PrintElementsOfArray(newNumbers));
            
        }
    }
}
