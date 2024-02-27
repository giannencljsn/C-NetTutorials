using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] {1, 10, 100, 1000, 10000};
            string[] weekDays = new string[7] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            Console.WriteLine("\\ This is for loop NUMBERS \\");
            for (int i =0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("\\ This is for loop WEEKDAYS \\");

            for (int i=0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }
            Console.WriteLine("\\ This is foreach loop WEEKDAYS \\");
            //foreach 
            foreach (var nameOfDay in weekDays)
            {
                Console.WriteLine(nameOfDay);
            }
            Console.WriteLine("\\ This is foreach loop NUMBERS \\");
            foreach (var nameOfNum in numbers)
            {
                Console.WriteLine(nameOfNum);
            }
        }
    }
}
