using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int.TryParse(Console.ReadLine(), out x);

            if (x == 0)
            {
                Console.WriteLine("This is not a valid input!");
            }
            else
            {
                Console.WriteLine("You have entered no. " + x);
            }
        }
    }
}
