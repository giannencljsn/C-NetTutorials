using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            int y = 4;

            //Max

            Console.WriteLine("Max : " + Math.Max(x,y));

            //Min
            Console.WriteLine("Min : " + Math.Min(x, y));

            //sqrt
            Console.WriteLine("SQRT : " + Math.Sqrt(x));


            //pow
            Console.WriteLine("POW: " + Math.Pow(x,y));

            //PI
            Console.WriteLine("Pi is: " + Math.PI);
        }
    }
}
