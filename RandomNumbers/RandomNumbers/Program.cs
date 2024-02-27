using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int x = 0;
            x = randNum.Next(1,6);

            Console.WriteLine("Rolled dice: "+ x);

            double y = 0;

            y = randNum.NextDouble() * 3;
            Console.WriteLine("Random double number is " + Math.Round(y,2));
        }
    }
}
