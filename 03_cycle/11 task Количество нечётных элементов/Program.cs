using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task_Количество_нечётных_элементов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int counter = 0;

            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n%2 != 0)
                {
                    counter++;
                }
            }
            while (n != 0);

            Console.WriteLine(counter);
        }
    }
}
