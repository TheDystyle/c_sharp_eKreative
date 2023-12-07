using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_task_цифры_в_строке
{
    internal class Program
    {
        static void CalculationDigit(string inputText, ref int counterDigit, ref int lenSubString, ref string noDigit)
        {
            char[] chars = inputText.ToCharArray();
            StringBuilder newString = new StringBuilder();
            
            for(int i = 0; i < chars.Length; i++)
            {
                if ((byte)chars[i] > 47 && (byte)chars[i] < 58)
                {
                    // рахуємо кількість цифр 
                    counterDigit++;
                }
                else
                {
                    // формуємо строку без цифр
                    newString.Append(chars[i]);
                    noDigit = newString.ToString();
                }
            }
            if (counterDigit > 0) lenSubString = 1;

            // прорахунок найбільшої кілкості цифр
            int maxLenght = 0;
            int temp = 0;
            for(int i = chars.Length-1; i > 0 ; i--)
            {
                if (((byte)chars[i] > 47 && (byte)chars[i] < 58) &&
                     ((byte)chars[i - 1] > 47 && (byte)chars[i - 1] < 58))
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

            lenSubString = maxLenght+1;
        }
        static void Main(string[] args)
        {
            int counterDigit = 0;
            string noDigit = "";
            int lenSubString = 0;

            CalculationDigit(Console.ReadLine(), ref counterDigit, ref lenSubString, ref noDigit);
            Console.WriteLine(counterDigit);
            Console.WriteLine(noDigit);
            Console.WriteLine(lenSubString);
        }
    }
}
