using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesInDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            a = int.MaxValue;
            Console.WriteLine(a);


            uint b = 0;
            b = uint.MaxValue;
            Console.WriteLine(b);


            long c = 0;
            c = long.MaxValue;
            Console.WriteLine(c);

            ulong d = 0;
            d = ulong.MaxValue;
            Console.WriteLine(d);

            ushort e = 0;
            e = ushort.MaxValue;
            Console.WriteLine(e);

            short f = 0;
            f = short.MaxValue;
            Console.WriteLine(f);

            byte g = 0;
            g = byte.MaxValue;
            Console.WriteLine(g);

            sbyte h = 0;
            h = sbyte.MaxValue;
            Console.WriteLine(h);



            Console.WriteLine(typeof(float).IsSecurityCritical);
        }
    }
}
