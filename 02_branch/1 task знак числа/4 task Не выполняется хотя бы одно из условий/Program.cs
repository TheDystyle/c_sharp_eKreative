using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_task_Не_выполняется_хотя_бы_одно_из_условий
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
            
            if (((number1 >= 1000) && (number1 <= 9999)) && ((number1 > 0) && (number1 % 2 != 0)) && ((number1 % 3 != 0) && (number1 % 5 != 0)))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            if (((number2 >= 1000) && (number2 <= 9999)) && ((number2 > 0) && (number2 % 2 != 0)) && ((number2 % 3 != 0) && (number2 % 5 != 0)))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            if (((number3 >= 1000) && (number3 <= 9999)) && ((number3 > 0) && (number3 % 2 != 0)) && ((number3 % 3 != 0) && (number3 % 5 != 0)))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            if (((number4 >= 1000) && (number4 <= 9999)) && ((number4 > 0) && (number4 % 2 != 0)) && ((number4 % 3 != 0) && (number4 % 5 != 0)))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }

            if (((number5 >= 1000) && (number5 <= 9999)) && ((number5 > 0) && (number5 % 2 != 0)) && ((number5 % 3 != 0) && (number5 % 5 != 0)))
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
