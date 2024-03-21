using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEthings
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1000;

            while(x > 0)
            {
                Console.WriteLine(x % 10);
                x = Math.Floor(x / 10);

            }
        }
    }
}
