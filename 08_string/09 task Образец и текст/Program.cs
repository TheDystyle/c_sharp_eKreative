using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_task_Образец_и_текст
{
    internal class Program
    {
        static void PaternAndText(string patern, string inputText, string index)
        {
            char[] sample = patern.ToCharArray();
            char[] inpText = inputText.ToCharArray();
            int k = Int32.Parse(index);

            int counter = 0;
           
            int startposition = k-1;
            int finishPosition = startposition + sample.Length;
            for(int i = startposition, j = 0; i < finishPosition; i++, j++)
            {
                if (sample[j] == inpText[i])
                {
                    counter++;
                    //перевірка змінних
                    //Console.WriteLine($"<< -=-=-=-=-  i = {i} k = {j}   =-=-=-=- >>");
                    //Console.WriteLine($"sample j={j} - {sample[j]} and i={i} {inpText[i]}");
                    //Console.WriteLine($"counter {counter}");
                }
                else
                {
                    counter++;
                    break;
                }
            }

            if(counter == sample.Length)
            {
                Console.WriteLine("YES");
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine("NO");
                Console.WriteLine(counter);
            }
        }
        static void Main(string[] args)
        {
            PaternAndText(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
        }
    }
}
