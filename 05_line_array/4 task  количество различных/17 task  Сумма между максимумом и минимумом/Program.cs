using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_task__Сумма_между_максимумом_и_минимумом
{
    internal class Program
    {
        /* static int[] InitByKeyBoard(string str)
         {
             string[] date = str.Trim().Split();
             int[] arr = new int[date.Length];
             for (int i = 0; i < arr.Length; i++)
             {
                 arr[i] = Int32.Parse(date[i]);
             }
             return arr;
         }

         static int SumOfElements(int[] arr)
         {
             int min = arr[0];
             int max = int.MinValue;
             //bool maxFlag = false;
             bool minFlag = false;

             int sumOfNumbers = 0;

             for (int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] < arr[0] && minFlag == false)
                 {
                     min = arr[i];
                     minFlag = true;
                     sumOfNumbers += arr[i];
                 }
                 if (minFlag == true && arr[i] > max)
                 {
                     max = arr[i];
                 }


             }
            Console.WriteLine($"min - {min}");
             Console.WriteLine($"max - {max}");

             return sumOfNumbers; 
         }*/
        ////////////////////////    2 episode  ///////////////
        static int[] InitByKeyBoard(string str1, string str2)
        {
            int n = Int32.Parse(str1);

            string[] data = str2.Trim().Split();
            int[] fullArray = new int[n];
            for(int i = 0; i < n; i++)
            {
                fullArray[i] = Int32.Parse(data[i]);
            }
            return fullArray;
        }

        static void FindMinMaxSumElement(int[] arr)
        {
            int maxElement = arr[0];
            int maxPosition = 0;

            int minElement = arr[0];
            int minPosition = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= maxElement )
                {
                    maxElement = arr[i];
                    maxPosition = i;
                }
                if(arr[i] < minElement)
                {
                    minElement = arr[i];
                    minPosition = i;
                }
            }

           // Console.WriteLine($"min element - {minElement} index {minPosition}");
            //Console.WriteLine($"max element - {maxElement} index {maxPosition}");

            int sum = 0;
            if (minPosition < maxPosition)
            {
                for (int i = minPosition; i <= maxPosition; i++)
                {
                    sum += arr[i];
                }
            }
            else
            {
                for (int i = maxPosition; i <= minPosition; i++)
                {
                    sum += arr[i];
                }
            }
            

            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            /*int n = Convert.ToInt16(Console.ReadLine());
            int[] myArr = InitByKeyBoard(Console.ReadLine());

            Console.WriteLine(SumOfElements(myArr));*/


            ///////// 2 episode //////////////

            //int[] fullArray = ;
            FindMinMaxSumElement(InitByKeyBoard(Console.ReadLine(), Console.ReadLine()));

        }
    }
}
