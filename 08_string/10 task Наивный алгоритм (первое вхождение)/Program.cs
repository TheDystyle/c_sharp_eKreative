using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _10_task_Наивный_алгоритм__первое_вхождение_
{
    internal class Program
    {
        static void PatternAndText(string pattern, string inputText)
        {
            int p = pattern.Length;
            int t = inputText.Length;
            int index = 0;
            string answer = "";

            for (int i = 0; i <= t - p; i++)
            {
                int j;
                for (j = 0; j < p; j++)
                {
                    //Console.Write(pattern[j]);
                    answer += pattern[j];

                    if (inputText[i + j] != pattern[j])
                    {
                        break;
                    }
                }
                if (j == p)
                {
                    //визначаємо входження до того моменту поки повністю пройшли весь патерн
                    index = i + 1;
                    break;
                }

            }
           // Console.WriteLine();
            if (index != 0)
            {
                Console.WriteLine(answer);
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine('0');
            }


            /* =-=-=- 1й тестовий варіант  -=-=-=-*/
            /* string sub = patern;
             string fullText = inputText;
             string answer = "";

             int position = fullText.IndexOf(sub);

             if (position == -1)
             {
                 Console.WriteLine(0);
             }
             else
             {
                 int temp = 0;

                 for (int i = 0; i < fullText.Length; i++)
                 {
                     for (int j = 0; j < sub.Length; j++)
                     {
                         if (sub[j] == fullText[i] && temp < sub.Length)
                         {
                             answer += sub[j];
                             // темпом рахуємо кількість співпадінь підряд 
                             //якщо темп = довжині підстроки-1, то break
                             temp++;
                             i++;
                             //Console.Write($"{sub[j]} ");

                         }
                         else
                         {
                             if (temp < sub.Length)
                             {
                                 answer += sub[j];
                                 //Console.Write($"{sub[j]} ");
                                 temp = 0;
                                 break;
                             }
                             else
                             {
                                 break;
                             }

                         }
                     }
                 }
                 Console.WriteLine(answer);
                 Console.WriteLine(position+1);
             }
            */
        }
        static void Main(string[] args)
        {
            PatternAndText(Console.ReadLine(), Console.ReadLine());
            //  abbbbbabb
            //aaabbbbbabbababbabbbabbab
        }
    }
}
