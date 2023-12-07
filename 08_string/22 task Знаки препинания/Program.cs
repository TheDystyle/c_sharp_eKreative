using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_task_Знаки_препинания
{
    internal class Program
    {
        static void FindPunctuationMarks(string inputText)
        {
            string ourText = inputText;
            int countMarks = 0;
           
            for (int i = 0; i < ourText.Length; i++)
            {
                if (ourText[i].ToString() == "." ||
                    ourText[i].ToString() == "," ||
                    ourText[i].ToString() == "!" ||
                    ourText[i].ToString() == ":" ||
                    ourText[i].ToString() == ";")
                {
                    countMarks++;
                }
            }
            Console.WriteLine(countMarks);
        }
        static void Main(string[] args)
        {
            FindPunctuationMarks(Console.ReadLine());

            // text for test
            // Hello, world!
            // Press any key to countinue ...
        }
    }
}
