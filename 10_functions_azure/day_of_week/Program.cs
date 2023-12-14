using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_of_week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
            Console.WriteLine(currentDateTime.DayOfWeek);


            string[] arr =new string[] {"1 - Many hands make light work.",
                "2 - Strike while the iron is hot.",
                "3 - Honesty is the best policy.",
                "4 - The grass is always greener on the other side of the fence.",
                "5 - Don’t judge a book by its cover." };

            Random rnd = new Random();
            int value = rnd.Next(1, 5);
            Console.WriteLine(value);
        }
    }
}
