using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_task_Сумма_четырёхзначных_чисел
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int start = 1000;
            int sum = 0;

            while (start <= 9999)
            {
               
                if(start%k == 0)
                {
                    sum += start;
                }
                start++;
            }

            Console.WriteLine(sum);
        }
    }
}
