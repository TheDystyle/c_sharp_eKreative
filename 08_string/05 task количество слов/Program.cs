using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_task_количество_слов
{
    internal class Program
    {
        static void FindCountWord(string inputText)
        {
            string[] ourText = inputText.Trim('.', ',', ';', '-', ' ', '(', ')', '?', '!', '\r', '\n', '\t').Split();
            //foreach (string word in ourText)
            //{
            //    Console.WriteLine(word);
            //}
            int countWord = 0;
            for(int i = 0; i < ourText.Length; i++)
            {
                if(ourText[i] != "")
                {
                    countWord++;
                } 
            }
            Console.WriteLine(countWord);
            //'.', ',', ';', '-', ' ', '(', ')', '?', '!', '\r', '\n', '\t'

        }
        static void Main(string[] args)
        {
            FindCountWord(Console.ReadLine());

            // text for test
            // Hello, world!
            // Press any key to countinue ...
        }
    }
}
