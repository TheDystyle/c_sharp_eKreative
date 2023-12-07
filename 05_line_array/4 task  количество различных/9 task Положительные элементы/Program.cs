using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_task_Положительные_элементы
{
    internal class Program
    {
        static int[] InitByKeyBoard(string str)
        {
            string[] date = str.Trim().Split();
            int[] arr = new int[date.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }
        static int ReturnCountePosition(int [] arr)
        {
            int counter = 0;
            for(int i = 0; i < arr.Length;i++)
            {
                if (arr[i] > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());
            Console.WriteLine(ReturnCountePosition(myArr));
        }
    }
}
