using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_task_Максимум__минимум__сумма
{
    internal class Program
    {
        static int[] InitByKeyBoard(string n, string elements)
        {
            int quantity = Int32.Parse(n);
            string[] date = elements.Trim().Split();

            int[] arr = new int[quantity];
            for (int i = 0; i < quantity; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        static void SumAllItems(int[] arr)
        {
            int sum = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }

        static void MaxElementAndPosition(int[] arr)
        {
            int maxElement = arr[0];
            int numberPosition = 0;

            for (int i = 0; i < arr.Length;i++)
            {
                if (arr[i] >= maxElement)
                {
                    maxElement = arr[i];
                    numberPosition = i+1;
                }
                if (numberPosition == 0)
                {
                    numberPosition = 1;
                }
            }

            Console.WriteLine($"{maxElement} {numberPosition}");
        }

        static void MinElementAndPosition(int[] arr)
        {
            int minElement = arr[0];
            int numberPosition = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                    numberPosition = i+1;
                }
                if (numberPosition == 0)
                {
                    numberPosition = 1;
                }
            }

            Console.WriteLine($"{minElement} {numberPosition}");
        }

        static void Main(string[] args)
        {
            int[] myArr = InitByKeyBoard(Console.ReadLine(), Console.ReadLine());
            SumAllItems(myArr);
            MaxElementAndPosition(myArr);
            MinElementAndPosition(myArr);
        }
    }
}
