using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_task_Сортировка_пузырьком
{
    internal class Program
    {
        static int[] InputItemArrayByKeyboard(string nString, string mString)
        {
            int n = Int32.Parse(nString);
            int[] fullArray = new int[n];

            string[] data = mString.Trim().Split();
            for (int i = 0; i < n; i++)
            {
                fullArray[i] = Int32.Parse(data[i]);
                //Console.WriteLine(fullArray[i]);
            }

            return fullArray;
        }
        
        static void BubleSorting(int[] fullArray)
        {
            int counter = 0;
            int t = 0;

            for (int i = 0; i < fullArray.Length - 1; ++i)
            {
                for (int j = 0; j < fullArray.Length - i - 1; ++j)
                {
                    if (fullArray[j + 1] < fullArray[j])
                    {
                        t = fullArray[j + 1];
                        fullArray[j + 1] = fullArray[j];
                        fullArray[j] = t;
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            BubleSorting(fullArray);
        }
    }
}
