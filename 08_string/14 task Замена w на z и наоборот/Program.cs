using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_task_Замена_w_на_z_и_наоборот
{
    internal class Program
    {
        static string ChangeZandW(string symbols)
        {
            char[] data = symbols.ToCharArray();

            for (int i = 0; i < data.Length; i++)
            {
                if (Convert.ToByte(data[i]) == 119 /*|| Convert.ToByte(data[i]) == 119*/)
                { 
                    data[i] = (char)122;
                    symbols = new string(data);
                }
                else
                {
                    if (Convert.ToByte(data[i]) == 122 /*|| Convert.ToByte(data[i]) == 119*/)
                    {
                        data[i] = (char)119;
                        symbols = new string(data);
                    }
                }
                
            }
            return symbols;
        }
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();
            
            symbols = ChangeZandW(symbols);
             Console.WriteLine(symbols);

            //строчка для тесту
            //zwz 121 wzw
        }
    }
}
