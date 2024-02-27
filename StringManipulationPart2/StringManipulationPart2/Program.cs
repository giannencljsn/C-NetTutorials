using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieTitle = "The Grave of The Fireflies";

            //Index of 
            Console.WriteLine(movieTitle.IndexOf('F')); 

            //Last index of 
            Console.WriteLine(movieTitle.LastIndexOf('F'));

            //Substring
            Console.WriteLine(movieTitle.Substring(17));
            //Remove
            Console.WriteLine(movieTitle.Remove(17));
            //Insert
            Console.WriteLine(movieTitle.Insert(17, "Fireball"));
        }
    }
}
