using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task_Сортировка_отрицательные_и_положительные
{
    internal class Program
    {
        static int[] ImputItemByKeyboard(string nStr, string numbers)
        {
            int n = Int32.Parse(nStr);
            int[] fullArr = new int[n];
            string[] data = numbers.Trim().Split();
            for (int i = 0; i < n; i++)
            {
                fullArr[i] = Int32.Parse(data[i]);
                // Console.Write($"{fullArr[i]} ");
            }


            return fullArr;
        }

        static int[] SortArr(int[] fullArr)
        {

            for (int i = 0; i < fullArr.Length - 1; i++)
            {

                for (int j = 0; j < fullArr.Length - i - 1; j++)
                {
                    // Console.WriteLine($"i:{arr[i]} j:{arr[j]}");
                    //if (fullArr[j + 1] < fullArr[j])
                    //{
                    //    int t = fullArr[j + 1];
                    //    fullArr[j + 1] = fullArr[j];
                    //    fullArr[j] = t;
                    //}

                    if (fullArr[j + 1] > fullArr[j] && fullArr[j] > 0)
                    {
                        int t = fullArr[j + 1];
                        fullArr[j + 1] = fullArr[j];
                        fullArr[j] = t;
                    }
                }
            }
            return fullArr;
        }
        static void Main(string[] args)
        {
            int[] fullArr = ImputItemByKeyboard(Console.ReadLine(), Console.ReadLine());
            Array.Sort(fullArr);
            //for(int i = 0;i < fullArr.Length;i++ )
            //{
            //    Console.Write($"{fullArr[i]} ");
            //}
            //Console.WriteLine();
            fullArr = SortArr(fullArr);
            for (int i = 0; i < fullArr.Length; i++)
            {
                Console.Write($"{fullArr[i]} ");
            }
            //Console.WriteLine();
        }
    }
}
