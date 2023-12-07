using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_less
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int count = 1;
                for (int j = i; j <= 2 * i; j++)
                {
                    count *= j;
                }
                sum += count;
                System.Console.WriteLine(count);
            }
            System.Console.WriteLine("sum:" + sum);


        }
    }
}
/* 100 prostih chisel
            * 
            * 
            * int a = 2,
                i = 1;
            Console.WriteLine(1);
            while (i < 10)
            {
                bool simple = true;

                for (int j = 2; j <= Math.Floor(Math.Sqrt(a)); j++)
                {
                    if (a % j == 0)
                    {
                        simple = false;
                        break;
                    }
                }
                if (simple)
                {
                    Console.WriteLine(a); i++;
                }
                a++;
            }*/