using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_task_Следующий_после_минимального
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

            //for (int i = 0; i < fullArray.Length; i++)
            //{
            //    Console.WriteLine(fullArray[i]);
            //}

            return fullArray;
        }

        static void FindSecondMinElement(int[] newArr, int[] fullArray)
        {
            fullArray.CopyTo(newArr, 0);
            Array.Sort(newArr);
            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.Write($"{newArr[i]} ");
            //}
            //Console.WriteLine();
            int elem = int.MaxValue;
            for (int i = 1; i < newArr.Length; i++)
            {
                if (newArr[i] > newArr[i - 1])
                {
                    elem = newArr[i];
                    Console.Write($"{newArr[i]}");
                    break;
                }
            }
           // Console.WriteLine();
            for (int i = 0; i < fullArray.Length; i++)
            {
                if (fullArray[i] == elem)
                {
                    Console.WriteLine($" {i + 1}");
                    break;
                }
            }

        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            int[] newArr = new int[fullArray.Length];
            FindSecondMinElement(newArr, fullArray);
        }
    }
}
