using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            int g = 1;

            while (g <= 22)
            {
                Console.WriteLine($"This is age: {g}");
                g++;
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Do While Loop");
            int x = 100;
            do
            {
               
                Console.WriteLine("This is age : " + x);
                x--;

            } while (x >= 1);
            
        }
    }
}
