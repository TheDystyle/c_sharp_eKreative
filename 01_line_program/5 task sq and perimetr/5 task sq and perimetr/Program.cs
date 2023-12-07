using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_task_sq_and_perimetr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sides  = Console.ReadLine().Trim().Split();

            int sideA = int.Parse(sides[0]);
            int sideB = int.Parse(sides[1]);

            int perimeter = (sideA + sideB)*2;
            int area = sideA * sideB;

            Console.WriteLine("The perimeter of the rectangle with sides {0} and {1} is {2}.", sideA, sideB, perimeter);
            Console.WriteLine("The area of the rectangle with sides {0} and {1} is {2}.", sideA, sideB, area);
        }
    }
}
