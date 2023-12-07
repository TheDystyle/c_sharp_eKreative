using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_task_программисты_в_уме_не_умножают
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint multiply = 5 * (12 * (123 * (1234 + 54321) + 4321) + 12) * 5;
            Console.WriteLine(multiply);
        }
    }
}
