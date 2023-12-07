using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_task_Элементы_с_max_и_min_суммой_цифр
{
    internal class Program
    {
        // вводимо елементи масиву однією строкою
        static int[] InputByKeyBoardString(string str, int n)
        {
            string[] date = str.Trim().Split();
            int[] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = Int32.Parse(date[i]);
            }
            return arr;

        }

        /*static void PositionOfElementsWithMaxMinSum(int[] arr)
        {
            int maxSum = 0;
            int minSum = int.MaxValue;
            int indexMax = 0;
            int indexMin = 0;

            int tempSum = 0;
            int tempN = 0;
            int tempI = 0;

            for (int i=0; i < arr.Length; i++)
            {

                tempSum = 0;
                tempN = Math.Abs(arr[i]);
                tempI = arr[i];

                while (tempN > 0)
                
                {
                    tempN = tempI - (tempI / 10 * 10);
                    tempSum += tempN;
                    tempI /= 10;
                }

                if( tempSum >= maxSum )
                {
                    maxSum = tempSum;
                    indexMax = i;
                }
                if ( tempSum < minSum)
                {
                    minSum = tempSum;
                    indexMin = i;
                }
            }

            Console.WriteLine($"{arr[indexMin]}");
            Console.WriteLine($"{arr[indexMax]}");
        }*/

        static void FindElementMaxSum(int[] arr)
        {
            int maxSum = int.MinValue;
            int indexMax = 0;

            int tempSum = 0;
            int tempN = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                tempSum = 0;
                tempN = Math.Abs(arr[i]);

                while (tempN > 0)

                {
                    tempSum += tempN%10;
                    tempN /= 10;
                }

                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    indexMax = i;
                }
                if(tempSum == maxSum)
                {
                    if (arr[i] > arr[indexMax])
                    {
                        indexMax = i;
                    }
                }


            }
            Console.WriteLine(arr[indexMax]);
        }

        static void FindElementMinSum(int[] arr)
        {
            int minSum = int.MaxValue;
            int indexMin = 0;

            int tempSum = 0;
            int tempN = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                tempSum = 0;
                tempN = Math.Abs(arr[i]);
                
                while (tempN > 0)

                {
                    tempSum += tempN % 10;
                    tempN /= 10;
                }

               if (tempSum < minSum)
                {
                    minSum = tempSum;
                    indexMin = i;
                }

                if (tempSum < minSum)
                {
                    minSum = tempSum;
                    indexMin = i;
                }
                if (tempSum == minSum)
                {
                    if (arr[i] < arr[indexMin])
                    {
                        indexMin = i;
                    }
                }

            }

            Console.WriteLine(arr[indexMin]);
        }
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;

            int n = Int32.Parse(Console.ReadLine());
           
            //заповнюємо масив елементами
            int[] myNumbers = InputByKeyBoardString(Console.ReadLine(), n);

            //шукаємо максимальну і мінімальну суму та індекси цих елементів в одному методі
            //PositionOfElementsWithMaxMinSum(myNumbers);

            //другий варіант - шукаємо мін і макс окремими методами
            FindElementMinSum(myNumbers);
            FindElementMaxSum(myNumbers);
            
           
        }
    }
}
