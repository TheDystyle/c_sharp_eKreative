using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_task__Сортировка___чётные_и_нечётные
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
        static void SortEvenAndOdd(int[] fullArray)
        {
            int[] even = new int[0];
            int[] odd = new int[0];
            int iE = 0;
            int iO = 0;

            for(int i = 0; i < fullArray.Length; i++)
            {
                if (fullArray[i]%2 == 0)
                {
                    Array.Resize(ref even, even.Length+1);
                    even[iE] = fullArray[i];
                    iE++;
                }
                if (fullArray[i] % 2 != 0)
                {
                    Array.Resize(ref odd, odd.Length + 1);
                    odd[iO] = fullArray[i];
                    iO++;
                }
            }
            Array.Sort(even);
            Array.Sort(odd);
            for (int i = 0; i < even.Length; i++)
            {
                Console.Write($"{even[i]} ");
            }
            for (int i = 0; i < odd.Length; i++)
            {
                Console.Write($"{odd[i]} ");
            }
        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            SortEvenAndOdd(fullArray);
        }
    }
}
