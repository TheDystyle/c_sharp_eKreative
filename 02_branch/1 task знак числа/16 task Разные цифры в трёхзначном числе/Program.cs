using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_task_Разные_цифры_в_трёхзначном_числе
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namber1 = Convert.ToInt32(Console.ReadLine());
            int namber2 = Convert.ToInt16(Console.ReadLine());
            int namber3 = Convert.ToInt16(Console.ReadLine());
            int namber4 = Convert.ToInt16(Console.ReadLine());
            int namber5 = Convert.ToInt16(Console.ReadLine());

            int temp11 = namber1 / 100;
            int temp12 = namber1 /10 %10;
            int temp13 = namber1 %10;



            if (temp11 == temp12 || temp12 == temp13 || temp13 == temp11)
            {
                Console.WriteLine("NO");
            }
            else Console.WriteLine("YES");

            int temp21 = namber2 / 100;
            int temp22 = namber2 / 10 % 10;
            int temp23 = namber2 % 10;

            if (temp21 == temp22 || temp22 == temp23 || temp23 == temp21)
            {
                Console.WriteLine("NO");
            }
            else Console.WriteLine("YES");

            int temp31 = namber3 / 100;
            int temp32 = namber3 / 10 % 10;
            int temp33 = namber3 % 10;

            if (temp31 == temp32 || temp32 == temp33 || temp33 == temp31)
            {
                Console.WriteLine("NO");
            }
            else Console.WriteLine("YES");

            int temp41 = namber4 / 100;
            int temp42 = namber4 / 10 % 10;
            int temp43 = namber4 % 10;

            if (temp41 == temp42 || temp42 == temp43 || temp43 == temp41)
            {
                Console.WriteLine("NO");
            }
            else Console.WriteLine("YES");

            int temp51 = namber5 / 100;
            int temp52 = namber5 / 10 % 10;
            int temp53 = namber5 % 10;

            if (temp51 == temp52 || temp52 == temp53 || temp53 == temp51)
            {
                Console.WriteLine("NO");
            }
            else Console.WriteLine("YES");
        }
    }
}
