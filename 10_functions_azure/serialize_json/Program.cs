using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializer_json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // testing JSON serialize

            string[] arr = new string[] {"1 - Many hands make light work.",
                "2 - Strike while the iron is hot.",
                "3 - Honesty is the best policy.",
                "4 - The grass is always greener on the other side of the fence.",
                "5 - Don’t judge a book by its cover." };

            Random rnd = new Random();
            int value = rnd.Next(1, 5);

            DateTime currentDateTime = DateTime.Now;
            string dayOfWeek = currentDateTime.DayOfWeek.ToString();
            Console.WriteLine("Today is " + dayOfWeek);

            string[] statusArr =
            {
                arr.IsReadOnly.ToString(),
                arr.Length.ToString(),
                arr.Rank.ToString(),
                arr.LongLength.ToString(),
                arr.IsFixedSize.ToString(),
                arr.IsSynchronized.ToString(),
                arr.SyncRoot.ToString()
            };
           
            Console.WriteLine(statusArr);

            var myRequest = new OutputJSON(arr[value],dayOfWeek,statusArr);

            string json = JsonSerializer.Serialize(myRequest);
            Console.WriteLine(json);

           /* 
                arr.IsReadOnly.ToString(),
                arr.Length.ToString(),
                arr.Rank.ToString(),
                arr.LongLength.ToString(),
                arr.IsFixedSize.ToString(),
                arr.IsSynchronized.ToString(),
                arr.SyncRoot.ToString()
           */

            //Console.WriteLine($"IsReadOnly: {arr.IsReadOnly}");
            //Console.WriteLine($"Length: {arr.Length}");
            //Console.WriteLine($"Rank: {arr.Rank}");
            //Console.WriteLine($"LongLength: {arr.LongLength}");
            //Console.WriteLine($"IsFixedSize: {arr.IsFixedSize}");
            //Console.WriteLine($"IsSynchronized: {arr.IsSynchronized}");
            //Console.WriteLine($"SyncRoot: {arr.SyncRoot}");
        }
        public class OutputJSON
        {
            public string? Phrase { get; set; }
            public string? DayOfWeek { get; set; }
            public Array Status { get; set; }
            public OutputJSON(string phrase, string dayNow, Array status)
            {
                Phrase = phrase;
                DayOfWeek = dayNow;
                Status = status;
            }
        }

    }
}

