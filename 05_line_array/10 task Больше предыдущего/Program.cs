using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task_Больше_предыдущего
{
    internal class Program
    {
        static int[] InitByKeyBoard(string n, string items)
        {
            int quantity = Int32.Parse(n);
            string[] date = items.Trim().Split();

            int[] arr = new int[date.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        static void CountElementsMoreThenPrevious(int[] arr)
        {
            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > arr[0])
                {
                    arr[0] = arr[i];
                    counter++;
                }
                else
                {
                    arr[0] = arr[i];
                }
            }

            

            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            int[] numbers = InitByKeyBoard(Console.ReadLine(), Console.ReadLine());
            CountElementsMoreThenPrevious(numbers);

        }
    }
}
