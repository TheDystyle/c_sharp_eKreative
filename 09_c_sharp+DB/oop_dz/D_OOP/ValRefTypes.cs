using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_OOP
{
   public struct PointVal
    {
        public int x;
        public int y;

        public void LogValues()
        {
            Console.WriteLine($"X={x}; y={y}");
        }
    }
    public class PointRef
    {
        public int x;
        public int y;

        public void LogValues()
        {
            Console.WriteLine($"X={x}; y={y}");
        }
    }
    public struct EvilStruct
    {
        public int x;
        public int y;

        public PointRef PointRef;
    }
}
