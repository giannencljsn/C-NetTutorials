using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsIf
{
     class Program
    {
        static void Main(string[] args)
        {

            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                Console.WriteLine("Number 1 is greater than number 2");

            }else if (x < y)
            {
                Console.WriteLine("Number 1 is less than number 2");

            } else if (x == y)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
