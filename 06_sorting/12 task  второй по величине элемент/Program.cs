using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12_task__второй_по_величине_элемент
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
        static void FindSecondMaxElement(int[] newArr, int[] fullArray)
        {
            Array.Sort(newArr);
            //Console.WriteLine("sort");
            //for (int i = 0; i < newArr.Length; i++)
            //{
            //    Console.Write($"{newArr[i]} ");
            //}
            //Console.WriteLine("\n second max");
            int elem = 0;
            
            //з нового відсортованого  масиву знаходимо 2ге найбільше значення
            //йдемо з кінця наперед
            //присвоюємо його змінній ЕЛЕМ
            for (int i = newArr.Length - 2; i >= 0; i--)
            {
                if (newArr[i] < newArr[i+1])
                {
                    elem = newArr[i];
                    //Console.WriteLine(newArr[i]);
                    break;
                }
            }
            
            // шукаємо в першому масиві номер позиції по змінній ЕЛЕМ
            for(int i = 0; i < fullArray.Length; i++)
            {
                if(elem == fullArray[i])
                {
                    Console.WriteLine($"{fullArray[i]} {i+1}");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] fullArray = InputItemArrayByKeyboard(Console.ReadLine(), Console.ReadLine());
            int[] newArr = new int[fullArray.Length];
            fullArray.CopyTo(newArr, 0);
            FindSecondMaxElement(newArr, fullArray);

        }
    }
}
