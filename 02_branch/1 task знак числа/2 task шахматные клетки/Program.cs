using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_task_шахматные_клетки
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data1 = Console.ReadLine().Trim().Split();
            byte i1 = byte.Parse(data1[0]);
            byte j1 = byte.Parse(data1[1]);
            float answer1 = (i1 + j1) % 2;

            string[] data2 = Console.ReadLine().Trim().Split();
            byte i2 = byte.Parse(data2[0]);
            byte j2 = byte.Parse(data2[1]);
            float answer2 = (i2 + j2) % 2;

            string[] data3 = Console.ReadLine().Trim().Split();
            byte i3 = byte.Parse(data3[0]);
            byte j3 = byte.Parse(data3[1]);
            float answer3 = (i3 + j3) % 2;

            string[] data4 = Console.ReadLine().Trim().Split();
            byte i4 = byte.Parse(data4[0]);
            byte j4 = byte.Parse(data4[1]);
            float answer4 = (i4 + j4) % 2;

            string[] data5 = Console.ReadLine().Trim().Split();
            byte i5 = byte.Parse(data5[0]);
            byte j5 = byte.Parse(data5[1]);
            float answer5 = (i5 + j5) % 2;

            string[] data6 = Console.ReadLine().Trim().Split();
            byte i6 = byte.Parse(data6[0]);
            byte j6 = byte.Parse(data6[1]);
            float answer6 = (i6 + j6) % 2;

            string white = ""; // not pair
            string black = ""; // pair
            
            if (answer1 == 0)
             {
                 black = black + i1 + " " + j1 + " ";
             }
             else
             {
                white = white + i1 + " " + j1 + " ";
            }

            if (answer2 == 0)
            {
                black = black + i2 + " " + j2 + " ";
            }
            else
            {
                white = white + i2 + " " + j2 + " ";
            }

            if (answer3 == 0)
            {
                black = black + i3 + " " + j3 + " ";
            }
            else
            {
                white = white + i3 + " " + j3 + " ";
            }

            if (answer4 == 0)
            {
                black = black + i4 + " " + j4 + " ";
            }
            else
            {
                white = white + i4 + " " + j4 + " ";
            }

            if (answer5 == 0)
            {
                black = black + i5 + " " + j5 + " ";
            }
            else
            {
                white = white + i5 + " " + j5 + " ";
            }

            if (answer6 == 0)
            {
                black = black + i6 + " " + j6 + " ";
            }
            else
            {
                white = white + i6 + " " + j6 + " ";
            }

            Console.WriteLine("{0}\n{1}", white, black );
        }
    }
}