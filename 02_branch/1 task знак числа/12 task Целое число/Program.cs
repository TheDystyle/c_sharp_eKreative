using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_task_Целое_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine());

            if (number %1 == 0)
            {
                double numberAbs = Math.Abs(number);
                
                int a = Convert.ToInt32(numberAbs) / 10000;
                int b = Convert.ToInt32(numberAbs) / 1000 % 10;
                int c = Convert.ToInt32(numberAbs) / 100 % 10;
                int d = Convert.ToInt32(numberAbs) / 10 % 10;
                int e = Convert.ToInt32(numberAbs) %10;

                int sum = a + b + c + d + e;
                Console.WriteLine(sum);
            }
            else
            {
                number = Math.Pow(Math.Abs(number), 1.0/2);
                Console.WriteLine(number);
            }
        }
    }
}
