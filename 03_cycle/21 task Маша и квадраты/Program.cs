using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_task_Маша_и_квадраты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            double sum = 0;

            for (int i = a; i <= b; i++)
            {
                sum += Math.Pow(i, 2);
            }

            Console.WriteLine(sum);
        }
    }
}
