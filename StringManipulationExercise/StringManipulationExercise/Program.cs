using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteShow = "     The Office        ";
            string season = "           - Season 6   ";
            string newName = "";
       

            
            newName = favoriteShow.Insert(favoriteShow.Trim().Length, season);
            Console.WriteLine(newName);

        }
    }
}
