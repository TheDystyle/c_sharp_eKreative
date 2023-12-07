using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_task_Сумма_цифр_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                n = -n;
            }

            int sum = 0;
            int temp = n;
            
            while (n > 0)
            {
                temp = n - (n / 10 * 10);
                sum += temp;
                n /= 10;
            }
            
            Console.WriteLine(sum);
        }
    }
}
