using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_task__Сортировка_модулей
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

        static void SortModuleItem(int[] fullArr)
        {
            int temp = 0;
            for (int i = 0; i < fullArr.Length - 1; i++)
            {
                for (int j = 0; j < fullArr.Length - i - 1; j++)
                {
                    if ((Math.Abs(fullArr[j + 1]) < Math.Abs(fullArr[j])) 
                        || (Math.Abs(fullArr[j]) == Math.Abs(fullArr[j + 1]) 
                        && (fullArr[j] > fullArr[j + 1])))
                    {
                        temp = fullArr[j + 1];
                        fullArr[j + 1] = fullArr[j];
                        fullArr[j] = temp;
                    }
                }
            }
            for(int i = 0;i < fullArr.Length; i++)
            {
                Console.Write($"{fullArr[i]} ");
            }
        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            SortModuleItem(fullArray);
        }
    }
}
