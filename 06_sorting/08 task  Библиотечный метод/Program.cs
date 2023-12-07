using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_task__Библиотечный_метод
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
        static void SortArray(int[] fullArray)
        {
            int n = fullArray.Length;
            int detectSort = 0;

            for (int i = 1; i < n; ++i)
            {
                detectSort = 0;
                int key = fullArray[i];
                int j = i - 1;
                
                while (j >= 0 && fullArray[j] > key)
                {
                    fullArray[j + 1] = fullArray[j];
                    j = j - 1;
                    detectSort++;
                }
                fullArray[j + 1] = key;
                if(detectSort > 0)
                {
                    for (int k = 0; k < fullArray.Length; k++)
                    {
                        Console.Write($"{fullArray[k]} ");
                    }
                    Console.WriteLine();
                }
            }
            if (detectSort == 0)
            {
                Console.WriteLine("The array is already sorted");
            }


            //for (int k = 0; k < numbers.Length; k++)
            //{
            //    Console.Write($"{numbers[k]} ");
            //}
            //Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            SortArray(fullArray);
        }
    }
}
