using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_task_Количество_нечётных_цифр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int counter = 0;

            while (num > 0)
            {
                if (num %2 != 0)
                {
                    counter++;
                }
                num /= 10;                
            }

            Console.WriteLine(counter);
        }
    }
}
