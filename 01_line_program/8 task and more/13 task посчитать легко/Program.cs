using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task_посчитать_легко
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = (16 + 5.0) / 16;
            double b = 169.0 / 24;

            double proportional = ((7 - 6.35) / 6.5 + 9.9) / ((1.2 / 36 + 1.2 / 0.25 - a) / b);
            Console.WriteLine(proportional);
        }
    }
}
