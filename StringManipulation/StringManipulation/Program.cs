using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = "  Boy And The Heron     ";
            //Indexes
            Console.WriteLine(movieName[3]);

            //Trim
            Console.WriteLine(movieName.Trim());

            //Upper case
            Console.WriteLine(movieName.ToUpper());

            //Lower case
            Console.WriteLine(movieName.ToLower());

            //Length
            Console.WriteLine(movieName.Length);
            Console.WriteLine(movieName.Trim().Length);

            //Replace
            Console.WriteLine(movieName.Replace('H', 'h')); ;

        }
    }
}
