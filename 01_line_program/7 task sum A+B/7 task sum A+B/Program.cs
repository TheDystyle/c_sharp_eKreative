using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_task_sum_A_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Trim().Split();

            int firstNumber = int.Parse(numbers[0]);
            int secondNumber = int.Parse(numbers[1]);

            int sum = firstNumber + secondNumber;

            Console.WriteLine("{0}+{1}={2}", firstNumber, secondNumber, sum);

        }
    }
}
