﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double proportion = ((((4.625 - (13.0 / 18) * (9.0 / 26)) / (9.0 / 4) + 2.5 / 1.25 / 6.75) / ((68.0+53)/68)) / (((1.0 / 2) - 0.375) / 0.125 + ((5.0 / 6) - (7.0 / 12)) / (0.358 - 1.4796 / 13.7)));

            Console.WriteLine(proportion);
        }
    }
}
