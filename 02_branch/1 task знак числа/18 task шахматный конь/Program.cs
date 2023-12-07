using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_task_шахматный_конь
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data1 = Console.ReadLine().Trim().Split();
            int i1 = int.Parse(data1[0]);
            int j1 = int.Parse(data1[1]);
           

            string[] data2 = Console.ReadLine().Trim().Split();
            byte i2 = byte.Parse(data2[0]);
            byte j2 = byte.Parse(data2[1]);
           

            string[] data3 = Console.ReadLine().Trim().Split();
            byte i3 = byte.Parse(data3[0]);
            byte j3 = byte.Parse(data3[1]);
            

            string[] data4 = Console.ReadLine().Trim().Split();
            byte i4 = byte.Parse(data4[0]);
            byte j4 = byte.Parse(data4[1]);
            

            string[] data5 = Console.ReadLine().Trim().Split();
            byte i5 = byte.Parse(data5[0]);
            byte j5 = byte.Parse(data5[1]);
           

            string[] start = Console.ReadLine().Trim().Split();
            int startI = int.Parse(start[0]);
            int startJ = int.Parse(start[1]);

            //сумма квадратов разницы нач и конечной координаты Х и Y =5
            //(x1-x2)^2 + (y1-y2)^2 = 5
            string step = "";

            double pow1 = Math.Pow((startI - i1), 2) + Math.Pow((startJ - j1), 2);
            double pow2 = Math.Pow((startI - i2), 2) + Math.Pow((startJ - j2), 2);
            double pow3 = Math.Pow((startI - i3), 2) + Math.Pow((startJ - j3), 2);
            double pow4 = Math.Pow((startI - i4), 2) + Math.Pow((startJ - j4), 2);
            double pow5 = Math.Pow((startI - i5), 2) + Math.Pow((startJ - j5), 2);

            if (pow1 == 5)
            {
                step = step + i1 + " " + j1 + " ";
            }

            if (pow2 == 5)
            {
                step = step + i2 + " " + j2 + " ";
            }

            if (pow3 == 5)
            {
                step = step + i3 + " " + j3 + " ";
            }

            if (pow4 == 5)
            {
                step = step + i4 + " " + j4 + " ";
            }

            if (pow5 == 5)
            {
                step = step + i5 + " " + j5 + " ";
            }

            Console.WriteLine(step);
        }
    }
}
