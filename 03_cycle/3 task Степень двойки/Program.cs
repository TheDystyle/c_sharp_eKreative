using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_task_Степень_двойки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = Convert.ToDouble(Console.ReadLine());

            int k = 0;

          while (Math.Pow(2,k) < n)
            {
               k += 1;
            }

            Console.WriteLine(k);
        }
    }
}


/*
 *  
        int n = int.Parse(Console.ReadLine());
        int pow = 0;
        for (int i = 0; Math.Pow(2, i) <= n; i++) {
            Math.Pow(2, i);
            pow++;
           
        }
        System.Console.WriteLine(pow);
*/