using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Are you enjoying C#? (Hell yes!/Hell no!)");
            string userInput = Console.ReadLine();
            string userOutput = userInput.ToLower();

            switch (userOutput)
            {
                case "hell yes!":
                    Console.WriteLine("Keep watching if you enjoy!");
                    break;
                case "hell no!":
                    Console.WriteLine("Feel free to message us in case of questions and feedback!");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
