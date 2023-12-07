using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_task__Неубывающая_подпоследовательность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int check = n;
            int counter = 1;

            while (check != 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (check <= n)
                {
                    counter++;
                }

                else
                {
                    break;
                }
                check = n;
            }

            Console.WriteLine(counter);
        }
    }
}
