using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = "#include <iostream>";
            string line2 = "int main()";
            string line3 = "{";
            string line4 = "    std::cout << \"Hello World!\" << std::endl;";
            string line5 = "}";

            Console.WriteLine("{0}\n\n{1}\n{2}\n{3}\n{4}", line1, line2, line3, line4, line5);
        }
    }
}
