using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task_Наивный_алгоритм___2__первое_вхождение_
{
    internal class Program
    {
        static void PaternAndText(string patern, string inputText)
        {
            string sub = patern;
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
                Console.WriteLine(position + 1);
            }

        }
        static void Main(string[] args)
        {
            PaternAndText(Console.ReadLine(), Console.ReadLine());
            //  acbab
            //baaaaaacbabcaacbaaba
           
        }
    }
}
