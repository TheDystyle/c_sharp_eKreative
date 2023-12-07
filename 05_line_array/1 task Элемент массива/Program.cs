using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_task_Элемент_массива
{
    internal class Program
    {
        static int[] InputItemToArrayByKeyboard(string n)
        {
            string[] numberSeries = n.Trim().Split();

            int[] fullArray = new int[numberSeries.Length];
            for(int i = 0; i < numberSeries.Length; i++)
            {
                fullArray[i] = Int32.Parse(numberSeries[i]);
                //Console.WriteLine($"position {i} - element {fullArray[i]}");
            }
            return fullArray;
        }

        static void CheckedPosition(string indexes, int[] arr)
        {
            string[] fk = indexes.Trim().Split();
            int f = Int32.Parse(fk[0]);
            int k = Int32.Parse(fk[1]);

            if(f > k)
            {
                Console.WriteLine("Error");
                return;
            }
            
            int counterPosition = 0;
            for(int i = f; i < k; i++)
            {
                counterPosition++;
            }


            if (counterPosition < 10)
            {
                Console.WriteLine(arr[counterPosition]); 
                
            }
            else
            {
                Console.WriteLine("Error");

            }
        }

        //static void
        static void Main(string[] args)
        {
            int[] fullArray = InputItemToArrayByKeyboard(Console.ReadLine());
            CheckedPosition(Console.ReadLine(), fullArray);
        }
    }
}
