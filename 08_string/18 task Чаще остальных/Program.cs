using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_task_Чаще_остальных
{
    internal class Program
    {
        static void FrequentLiteral(string nSymbols, string inputText)
        {
            //int n = Int32.Parse(nSymbols);
            char[] textForFind = inputText.ToCharArray();

            char symbol = (char)122;
            //int indexSybbol = 0;
            int count = 0;

            for(int i = 0; i < textForFind.Length;i++)
            {
                int temp = 0;
                for(int j = 0; j < textForFind.Length; j++)
                {
                    if (textForFind[i] == textForFind[j])
                    {
                        temp++;

                    }
                }
                
                if(temp > count && textForFind[i] < symbol)
                {
                    symbol = textForFind[i];
                    count = temp;
                }
            }
            Console.WriteLine((byte)symbol);
        }
        static void Main(string[] args)
        {
            FrequentLiteral(Console.ReadLine(), Console.ReadLine());
        }
    
    }
}