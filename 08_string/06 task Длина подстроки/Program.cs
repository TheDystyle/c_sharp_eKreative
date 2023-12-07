using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_task_Длина_подстроки
{
    internal class Program
    {
        static void LenghtSubString(string inputText, string positions)
        {
            string[] data = positions.Trim().Split();
            int i = Int32.Parse(data[0]);
            int j = Int32.Parse(data[1]);
            int lenghtSubString = j - i;

            if (i > j)
            {
                Console.WriteLine(0);
            }
            else
            {
                lenghtSubString += 1;
                Console.WriteLine(lenghtSubString);

                string sub = inputText.Substring(i - 1, lenghtSubString);
                Console.WriteLine(sub);
            }


        }
        static void Main(string[] args)
        {
              LenghtSubString(Console.ReadLine(), Console.ReadLine());
        }
    }
}

//StringBuilder answer = new StringBuilder();
//char[] chars = inputText.ToCharArray();

//int lenghtSubString = j - i + 1;

//if (i > j)
//{
//    Console.WriteLine(0);
//}
//else
//{
//    for (int k = i - 1; k <= lenghtSubString; k++)
//    {
//        answer.Append(chars[k]);
//    }
//    answer.ToString();
//    Console.WriteLine(answer);
//}



