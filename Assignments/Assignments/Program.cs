using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Program
    {
        static void Main(string[] args)
        {   //Assignment #1 
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you, {userName}! My name is Gianne, How old are you?");
            string age = Console.ReadLine();
            int yearToday = DateTime.Now.Year;
            int systemAge = 22;
            int newYear = (yearToday - systemAge) -1;

            if (int.TryParse(age, out int typeOfage))
            {
                Console.WriteLine($"{typeOfage} good. As for me, I was born in {newYear}. Which makes me {yearToday - newYear}. ");
            }
            else
            {
                Console.WriteLine("Age given is not number!");
            }

            ////Assignment #2 
            Console.WriteLine("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime dt = new DateTime(year, month, day);
            string dayofDate = dt.DayOfWeek.ToString();
            Console.WriteLine(dayofDate);


            ////Assignment #3 
            DateTime currentDate = DateTime.Now;
            string dayName = currentDate.DayOfWeek.ToString();

            switch (dayName)
            {
                case "Saturday":
                    Console.WriteLine("YELLOW day");
                    break;
                case "Sunday":
                    Console.WriteLine("GREEN day");
                    break;
                case "Monday":
                    Console.WriteLine("BLUE day");
                    break;
                case "Tuesday":
                    Console.WriteLine("GREY day");
                    break;
                case "Wednesday":
                    Console.WriteLine("RED day");
                    break;
                case "Thursday":
                    Console.WriteLine("ORANGE day");
                    break;
                case "Friday":
                    Console.WriteLine("WHITE day");
                    break;


            }
        }
    }
}
