using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_1_task_Элементы_с_одинаковыми_знаками
{
    internal class Program
    {
        static int[] InitByKeyBoard(string str1, string str2)
        {
            int n = Convert.ToInt16(str1);

            string[] data = str2.Trim().Split(' ');
            int[] arr = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
            {
                arr[i] = Int32.Parse(data[i - 1]);
                //Console.WriteLine(arr[i]);
            }
            return arr;
        }

        static void CheckSameSign(int[] fullArray)
        {
            bool answerItem = false;

            for (int i = 1; i < fullArray.Length; i++)
            {
                if ((fullArray[i] > 0 && fullArray[i - 1] > 0) || (fullArray[i] < 0 && fullArray[i - 1] < 0))
                {
                    answerItem = true;
                    break;
                }
            }

            if (answerItem == true)
            {
                Console.WriteLine("YES");
            }
            if (answerItem == false)
            {
                Console.WriteLine("NO");
            }
        }
        static void Main(string[] args)
        {
            int k = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                int[] fullArray = InitByKeyBoard(Console.ReadLine(), Console.ReadLine());
                CheckSameSign(fullArray);
            }

        }
    }
}
