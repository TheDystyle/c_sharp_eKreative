using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_task_Сумма_цифр_двоичного_представления
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n10 = Convert.ToInt32(Console.ReadLine());

           int n2 = n10 % 2 ;
           int sum = n10 % 2;

           while (n10 >= 2)
            {
                n10 = n10 / 2;
                sum = sum + n10 % 2;
            }

            Console.WriteLine(sum);
        }
    }
}
