using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_less
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 6 task 2variant */
            //сколько чисел мы хоти ввести для сравнения?
            int n = Convert.ToInt32(Console.ReadLine()); 

            // происходит первый ввод числа
            int min = Convert.ToInt32(Console.ReadLine());

            int element;

            for (int i = 2; i <= n; i++)
            {
                element = Convert.ToInt32(Console.ReadLine());
                if (element < min)
                {
                    min = element;
                }
            }

            Console.WriteLine(min);



            /*
             * 
             * 6 task
             * 
             * 
             * int n = Convert.ToInt32(Console.ReadLine());

            int min = int.MaxValue;

            int element;

                for (int i = 1; i <= n; i++)
            {
                element = Convert.ToInt32(Console.ReadLine());
                if (element < min)
                {
                    min = element;
                }
            }

            Console.WriteLine(min);*/
            /*
            * task 5   
             */


            //task 4  pro cosinusi

            //int n = Console.ReadLine();






            /* task4
             * 
             * fibonachi
             * 
             */

            /*
             * task 3
             * 
             * (-1)^n+1 * (2n-1)
             * 
            int n = Convert.ToInt32(Console.ReadLine());

            int znak = 1;
            int sum = 0;

            for (int i = 1; i <=n; i++)
            {
            sum += znak * (2 * i -1);
            znak =- znak;
            }
            
            Console.WriteLine(sum);*/












            /*
             * task 2 revers
             * 
             * int n = Convert.ToInt32(Console.ReadLine());

            int revers = 0;
            int copyN = n;

            while (n != 0)
            {
                revers = revers * 10 + n % 10;
                n /= 10;
            }

            if (copyN == revers)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("NOT palindrom");
            }*/





            /*task 1
             * 
             * 
             * int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 1;


            while ( count <= n )
            {
                sum += count++;
            }

            Console.WriteLine(sum);*/
        }
       
    }
}
