using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_task_Больше_соседних
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

        static void CountMoreThenneighbours(int[] arr)
        {
            int counter = 0;
            for(int i=0; i< arr.Length; i++)
            {
               /* if(i == 0)
                {
                    if (arr[i]> arr[i + 1])
                    {
                        counter++;
                    }
                }*/
                if (i > 0 && i != arr.Length - 1)
                {
                    if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                    {
                        counter++;
                    }
                }
                /*if(i == arr.Length - 1)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        counter++;
                    }
                }*/

                //Console.WriteLine($"iteracia {i}. counter = {counter}");

            }
            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            int[] myArr = InitByKeyBoard(Console.ReadLine(), Console.ReadLine());

            CountMoreThenneighbours(myArr);

        }
    }
}
