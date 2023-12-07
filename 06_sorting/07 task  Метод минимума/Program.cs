using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_task__Метод_минимума
{
    internal class Program
    {
        static int[] InputItemArrayByKeyboard(string nString, string mString)
        {
            int n = Int32.Parse(nString);
            int[] fullArray = new int[n];
            string[] data = mString.Trim().Split();

            for (int i = 0; i < fullArray.Length; i++)
            {
                fullArray[i] = Int32.Parse(data[i]);
            }
            return fullArray;
        }
        static void CountChangeFirstItem(int[] fullArray)
        {
            int temp, smallest;
            int firstItem = fullArray[0];
            int firstIndexItem = 0;
            int counter = 0;

            for (int i = 0; i < fullArray.Length - 1; i++)
            {
                smallest = i;
                
                for (int j = i + 1; j < fullArray.Length; j++)
                {
                    if (fullArray[j] < fullArray[smallest])
                    { smallest = j; }
                }
                temp = fullArray[smallest];
                fullArray[smallest] = fullArray[i];
                fullArray[i] = temp;

                for(int l = 0; l < fullArray.Length; l++)
                {
                    if (fullArray[l] == firstItem && firstIndexItem != l)
                    {
                        counter++;
                        firstIndexItem = l;
                    }
                }
            }

                Console.Write($"{counter}");
            
        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            CountChangeFirstItem(fullArray);
        }
    }
}