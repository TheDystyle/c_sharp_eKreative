using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_task_Очень_важные_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            if (a < b)
            {
                
                for (int i = a; i <= b; i++)
                {
                    if (i == a)
                    {
                        Console.WriteLine($"{b-a+1} very important numbers:\n{i}");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine($"{a - b + 1} very important numbers:");
                for (int i = a; i >= b; i--)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
