using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_task_К_й_пробел
{
    internal class Program
    {
        static void FindeKGap(string inputText, string position)
        {
            string ourText = inputText;
            int n = Int32.Parse(position);

            int countGap = 0;
            int gapPosition = 0;

            for (int i = 0; i < ourText.Length; i++)
            {
                if (ourText[i].ToString() == " ")
                {
                    countGap++;
                    gapPosition = i+1;
                    //Console.WriteLine($"gap position - {i+1}");
                }
                if(countGap == n)
                {
                    break;
                }
            }

            if(countGap < n)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine($"{gapPosition}");
            }
        }
        static void Main(string[] args)
        {
            FindeKGap(Console.ReadLine(), Console.ReadLine());

            // text for test
            // Hello, world!
            // Press any key to countinue ...
        }
    }
}
