using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_task_Число_в_вертикальной_рамке
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberText = Console.ReadLine();

            Console.WriteLine("***");

            foreach (var num in numberText)
            {
                if (num == '-')
                {
                    Console.WriteLine("*-*");
                }
                else
                {
                    Console.WriteLine($"*{num}*");
                }
               
            }
            Console.WriteLine("***");

        }
    }
}
/*
 * 
 *  int n = Convert.ToInt32(Console.ReadLine());

            int revers = 0;

            if (n < 0)
            {
                Console.WriteLine("***\n*-*");
                n = Math.Abs(n);
            }
            else
            {
                Console.WriteLine("***");
            }
            while (n != 0)
            {
                revers = revers * 10 + n % 10;
                n /= 10;
            }

            while(revers != 0)
            {
                Console.WriteLine($"*{revers % 10}*");
                revers /= 10;
            }
            Console.WriteLine("***");
 * 
 * 
 * 
 */