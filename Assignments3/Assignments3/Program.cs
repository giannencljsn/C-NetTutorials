using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\\\\Assignment No. 4 Upside Down Triangle\\\\");

            for (int i=16; i >=0; i--)
            {
            

                for(int j =0; j <=i; j++)
                {
                    Console.Write("0");
                    

                }
                Console.WriteLine ();

            }
            Console.WriteLine("\\\\Assignment No. 5 (Months/Days) \\\\");
            
            Random randMonth = new Random();
            Random randDay = new Random();
              
            int randNum = randMonth.Next(1,13);
            int randNumDay = 0;

            //Console.WriteLine(randNum);
            //Console.WriteLine(randNumDay);

            switch (randNum)
            {
                case 1:
                    Console.Write("January - " );

                    break;
                case 2:
                    Console.Write("February - " );
                    break;
                case 3:
                    Console.Write("March - " );
                    break;
                case 4:
                    Console.Write("April - " );
                    break;
                case 5:
                    Console.Write("May - " );
                    break;
                case 6:
                    Console.Write("June - ");
                    break;
                case 7:
                    Console.Write("July - " );
                    break;
                case 8:
                    Console.Write("August - " );
                    break;
                case 9:
                    Console.Write("September - ");
                    break;
                case 10:
                    Console.Write("October - ");
                    break;
                case 11:
                    Console.Write("November - ");
                    break;
                case 12:
                    Console.Write("December - ");
                    break;

                default:
                    Console.Write("Invalid number!");
                    break;
                 
            }

            
            if (randNum == 1 || randNum == 3 || randNum == 5 || randNum == 7 || randNum == 8 || randNum == 10 || randNum == 12)
            {
                randNumDay = randDay.Next(1, 31);
                Console.Write( randNumDay + " days");
            }
            else if (randNum == 4 || randNum == 6 || randNum == 9 || randNum == 11)
            {
                randNumDay = randDay.Next(1, 30);
                Console.Write(randNumDay + " days");

            }
            else if (randNum == 2)
            {
                randNumDay = randDay.Next(1, 28);
                Console.Write(randNumDay + " days");
            }
            else
            {
                Console.WriteLine("Invalid month!");
            }
            Console.WriteLine();


            Console.WriteLine("\\\\Assignment No. 6 Roll dice\\\\");
            Console.WriteLine("yes,no");
            string answer = Console.ReadLine().ToLower();
            
            if(answer == "yes")
            {
                Console.WriteLine("You answered yes!");
                Random dice = new Random();
                int rolled = dice.Next(1,7);

                Console.WriteLine("New dice no. is " + rolled);
            }
            else if(answer == "no") {
                Environment.Exit(0);
            }
           
        }


    }
}
