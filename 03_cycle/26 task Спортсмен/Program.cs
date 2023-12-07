using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_task_Спортсмен
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Trim().Split();
            int n = int.Parse(data[0]);
            double x = double.Parse(data[1]);

            int counter = 1;
            double sum = n;

            while(sum < x)
            {
                sum = sum + (0.1 * sum);
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
