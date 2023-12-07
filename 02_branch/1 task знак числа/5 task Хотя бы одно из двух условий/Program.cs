using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_task_Хотя_бы_одно_из_двух_условий
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int number4 = Convert.ToInt32(Console.ReadLine());
            int number5 = Convert.ToInt32(Console.ReadLine());

            if ((number1 % 2 != 0) || ((number1 > 0) && ((number1 >= 100) && (number1 <= 999))))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if ((number2 % 2 != 0) || ((number2 > 0) && ((number2 >= 100) && (number2 <= 999))))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if ((number3 % 2 != 0) || ((number3 > 0) && ((number3 >= 100) && (number3 <= 999))))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if ((number4 % 2 != 0) || ((number4 > 0) && ((number4 >= 100) && (number4 <= 999))))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            if ((number5 % 2 != 0) || ((number5 > 0) && ((number5 >= 100) && (number5 <= 999))))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
