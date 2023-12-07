using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task_по_спирали
{
    internal class Program
    {
        static void FullBySpiral(string mStr)
        {
            int m = Int32.Parse(mStr);

            //кількість елементів буде М*М
            int n = 1;
            int[,] helix = new int[m, m];

            //start point
            int right = 0;
            int rightBoard = m - 1;
            int top = 0;
            int topBoard = m - 1;

            //while (n < m * m)
            //{
            for(int i = 0; i < m * m; i++)
            { 
                //прохід зліва направо - рух обежуємо xn
                for (int x = right; x <= rightBoard; x++)
                {
                    helix[top, x] = n++;
                }

                top++;

                //зверху вниз
                for (int y = top; y <= topBoard; y++)
                {
                    helix[y, rightBoard] = n++;
                }

                rightBoard--;

                //справа наліво
                for (int x = rightBoard; x >= right; x--)
                {
                    helix[topBoard, x] = n++;
                }

                topBoard--;

                // знизу вгору
                for (int y = topBoard; y >= top; y--)
                {
                    helix[y, right] = n++;
                }

                right++;
            }
           // }

            for (int y = 0; y < helix.GetLength(0); y++)
            {
                for (int x = 0; x < helix.GetLength(1); x++)
                {
                    Console.Write($"{helix[y, x]} ");
                }
                Console.WriteLine();
            }


        }
        static void Main(string[] args)
        {
            FullBySpiral(Console.ReadLine());
        }
    }
}
