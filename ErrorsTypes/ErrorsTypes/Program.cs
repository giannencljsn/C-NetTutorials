using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 0; b = 1; c = 0;

            c = b / a;

            Console.WriteLine(c);

        }
    }
}
