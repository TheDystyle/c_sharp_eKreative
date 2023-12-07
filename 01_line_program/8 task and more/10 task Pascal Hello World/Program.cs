using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task_Pascal_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = "program HelloWorld;\nbegin\n  WriteLn('Hello, World!');\nend.";

            Console.WriteLine("{0}", line1);
        }
    }
}
