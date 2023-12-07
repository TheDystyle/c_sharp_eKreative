using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_task__Генерация_с_переворотом
{
    internal class Program
    {
        static int[] GenerateArray(string xy)
        {
            string[] array = xy.Trim().Split();
            int x = int.Parse(array[0]);
            int y = int.Parse(array[1]);

            int[] generateArray = new int[10];
            generateArray[0] = x;
            generateArray[1] = y;
            //Console.Write($"{generateArray[0]} {generateArray[1]} ");
            for (int i = 2; i < 10; i++)
            {
                generateArray[i] = generateArray[i - 2] + generateArray[i - 1];
                //Console.Write($"{generateArray[i]} ");
            }

            return generateArray;
        }
        
        static void RepositionAndPrint(int[] arr )
        {
            int temp = 0;

            for(int i=0; i<arr.Length/2; i++)
            {
               //Console.WriteLine($"{i + 1}: {arr[i]} and {arr[arr.Length - (i + 1)]}");
                temp = arr[arr.Length - (i +1)];
                //Console.WriteLine(temp);
                arr[arr.Length - (i + 1)] = arr[i];
               // Console.WriteLine(arr[arr.Length - (i + 1)]);
                arr[i] = temp;
               // Console.WriteLine(arr[i]);

                //Console.WriteLine($"{i+1}: {arr[i]} and {arr[arr.Length - (i + 1)]}\n");
            }

            for(int i = 0; i < arr.Length; i++)
            {
               Console.Write($"{arr[i]} ");
            }
        }
        static void Main(string[] args)
        {
           int[] myGenerateArray = GenerateArray(Console.ReadLine());
           RepositionAndPrint(myGenerateArray);
        }
    }
}
