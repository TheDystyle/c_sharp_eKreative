using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_task__Среднее_арифметическое
{
    internal class Program
    {
        static int[] InitByKeyBoard(string str1, string str2)
        {
            int n = Convert.ToInt16(str1);

            string[] data = str2.Trim().Split(' ');
            int[] arr = new int[n+1];

            for (int i = 1; i < n+1; i++)
            {
                arr[i] = Int32.Parse(data[i-1]);
            }

            /*int x = arr.Length;
            Console.WriteLine(x);

            Console.WriteLine("stroka ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.WriteLine("masiv ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            return arr;
        }

        static void AverageNotPairItemOnPairPosition(int[] fullArray)
        {
            double average = 0;
           
            double sum = 0;
            double count = 0;

           for (int i = 2; i < fullArray.Length; i++)
            {
                
                if(i%2 == 0)
                {
                    if (fullArray[i] %2 != 0 )
                    {
                        sum += fullArray[i];
                        count++;
                    }
                }
               
            }
           // Console.WriteLine(sum);
            //Console.WriteLine(count);
            if(count == 0)
            {
                Console.WriteLine($"{0:F4}");
            }
            else
            {
                average = sum / count;
                Console.WriteLine($"{average:F4}");
            }
        }
        static void Main(string[] args)
        {
            int[] fullArray = InitByKeyBoard(Console.ReadLine(), Console.ReadLine());
            AverageNotPairItemOnPairPosition(fullArray);
        }
    }
}
