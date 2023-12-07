using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_task_previous_next
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberPrev = number - 1;
            int numberNext = number + 1;

            Console.WriteLine("The next number for " + number + " is " + numberNext + ".");
            Console.WriteLine("The previous number for " + number + " is " + numberPrev + ".");
        }
    }
}

