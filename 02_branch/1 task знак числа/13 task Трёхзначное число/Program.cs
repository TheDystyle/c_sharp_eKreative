using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task_Трёхзначное_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            int condition1 = number / 10000;
            int condition2 = number / 1000;
            int condition3 = number / 100;

            if (condition3 > 0 && condition1 == 0 && condition2 == 0)
            {
                Console.WriteLine(condition3);
            }

            else
            {
                Console.WriteLine( number %10 );
            }
        }
    }
}
