using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_task_буквы_в_строке
{
    internal class Program
    {
        static void CalculationLiteral(string inputText, ref int counterLiteral, ref int lenString, ref string noLiteral)
        {
            char[] chars = inputText.ToCharArray();
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < chars.Length; i++)
            {
                if (((byte)chars[i] > 64 && (byte)chars[i] < 91) || ((byte)chars[i] > 96 && (byte)chars[i] < 123))
                {
                    counterLiteral++;
                }
                else
                {
                    newString.Append(chars[i]);
                    noLiteral = newString.ToString();
                }
            }
            if (counterLiteral > 0) lenString = 1;
            // прорахунок найбільшої кілкості букв
            int maxLenght = 0;
            int temp = 0;
            for (int i = chars.Length - 1; i > 0; i--)
            {
                if (((byte)chars[i] > 64 && (byte)chars[i] < 123) &&
                     ((byte)chars[i - 1] > 64 && (byte)chars[i - 1] < 123))
                {
                    temp++;
                    if (temp > maxLenght)
                    {
                        maxLenght = temp;
                    }

                }
                else
                {
                    temp = 0;
                }
            }

            lenString = maxLenght + 1;
        }
        static void Main(string[] args)
        {
            int counterLiteral = 0;
            string noLiteral = "";
            int lenString = 0;

            CalculationLiteral(Console.ReadLine(), ref counterLiteral, ref lenString, ref noLiteral);
            Console.WriteLine(counterLiteral);
            Console.WriteLine(noLiteral);
            Console.WriteLine(lenString);
        }
    }
}
