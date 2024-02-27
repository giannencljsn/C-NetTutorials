using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOREven
{
   class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("ODD OR EVEN? : \nEnter a number");

            string IsItOddOrEven = Console.ReadLine();
            int result = int.Parse(IsItOddOrEven);

            if (result % 2 == 0)
            {
                Console.WriteLine("The number is EVEN!");
            }
            else if (result % 2 == 1)
            {
                Console.WriteLine("The number is Odd!");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
