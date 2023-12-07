using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _29_task_Полные_квадраты
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Trim().Split();
            int start = int.Parse(num[0]);
            int finish = int.Parse(num[1]);

            string answer = "";
            int counter = 0;

            double temp = 0;
            
            while ( start <= finish)
            {
                temp = Math.Sqrt(start) - Math.Floor(Math.Sqrt(start));
                if (temp == 0)
                {
                    answer += start +" ";
                    counter++;
                }
                start++;
 ;          }
          
            if (counter == 0 )
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(answer);
            }
        }
    }
}
/*
 * string[] num = Console.ReadLine().Trim().Split();
            int start = int.Parse(num[0]);
            int finish = int.Parse(num[1]);

            string answer = "";
            int counter = 0;

            for(int i = 1, j = 1; i <= finish;  i++, j++)
            {
                if ((i * j) >= start && (i * j) < finish)
                {
                    answer += i *j + " ";
                    counter++;
                }
               
            }
          
            if (counter == 0 )
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(answer);
            }
 * 
 * 
 * 
 * 
 * 
 * */