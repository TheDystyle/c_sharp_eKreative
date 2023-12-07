using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_task_Чётное_положительное
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            if (number%2 == 0 && number > 0)
            {
                number += 2;
                Console.WriteLine("YES\n" + number);
            }
            else if (number > 0)
            {
                number += 1;
                Console.WriteLine("NO\n" + number);
            }
            else
            { 
                Console.WriteLine("NO\n" + 2);
            }
        }
    }
}
