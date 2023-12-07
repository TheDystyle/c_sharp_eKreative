using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_2_task_Элементы_с_max_и_min_суммой_цифр
{
    internal class Program
    {
        static int[] InitByKeyBoard(string x, string str)
        {
            int n = Int32.Parse(x);

            string[] date = str.Trim().Split();
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;
        }

        static void FindElementMaxSum(int[] fullArr)
        {
            //int element = fullArr[0];
            int maxSum = 0;
            int indexMax = 0;
            int tempSum = 0;
            int tempElement;

            for(int i=0; i < fullArr.Length; i++)
            {
                tempElement = fullArr[i];
                tempElement = Math.Abs(tempElement);

                while (tempElement > 0)
                {
                    tempSum += tempElement % 10;
                    tempElement /= 10;
                }

                if(tempSum > maxSum)
                {
                    maxSum = tempSum;
                    indexMax = i;
                }
                if(tempSum == maxSum)
                {
                    if (fullArr[i] > fullArr[indexMax])
                    {
                        indexMax = i;
                    }
                }
               
            }
            Console.WriteLine(fullArr[indexMax]);
        }

        static void FindElementMinSum(int[] fullArr)
        {
            //int element = fullArr[0];
            int minSum = 0;
            int indexMin = 0;
            int tempSum = 0;
            int tempElement;

            for (int i = 0; i < fullArr.Length; i++)
            {
                tempElement = fullArr[i];
                tempElement = Math.Abs(tempElement);

                while (tempElement > 0)
                {
                    tempSum += tempElement % 10;
                    tempElement /= 10;
                }

                if (tempSum < minSum)
                {
                    minSum = tempSum;
                    indexMin = i;
                }
                if (tempSum == minSum)
                {
                    if (fullArr[i] < fullArr[indexMin])
                    {
                        indexMin = i;
                    }
                }

            }
            Console.WriteLine(fullArr[indexMin]);
        }
        static void Main(string[] args)
        {
            int[] fullArr = InitByKeyBoard(Console.ReadLine(), Console.ReadLine());
            FindElementMinSum(fullArr);
            FindElementMaxSum(fullArr);


        }
    }
}
/*
 * 
            if (tempSum < minSum)
            {
                minSum = tempSum;
                indexMin = i;
            }
            if (tempSum == minSum)
            {
                minSum = tempSum;
                if (indexMin > i)
                {
                    indexMin = i;
                }
            }




            if (tempSum > maxSum)
            {
                maxSum = tempSum;
                indexMax = i;
            }
            if (tempSum == maxSum)
            {
                maxSum = tempSum;
                if (indexMax < i)
                {
                    indexMax = i;
                }
            }*/