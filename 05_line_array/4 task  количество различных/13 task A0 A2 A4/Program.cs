using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task_A0_A2_A4
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

        static void PairNumbers(int[] arr)
        {
            for(int i  = 0; i < arr.Length;i+=2)
            {
                Console.Write($"{arr[i]} ");
            }
            
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());
            PairNumbers(myArr);
        }
    }
}
