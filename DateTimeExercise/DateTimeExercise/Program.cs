using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime PresentDate = new DateTime(2017, 09, 30);
            DateTime PresentTime = DateTime.Now;


            string formattedTime = string.Format("{0:09:09:59}", PresentTime);
            string formattedDate = string.Format("{0:dddd} of month {0:MMMM} year {0:yyyy}", PresentDate);


            //First Format
            Console.WriteLine(PresentDate.ToShortDateString() + " " + formattedTime);
            //Second Format
            Console.WriteLine(formattedDate);
            //ThirdFormat
            Console.WriteLine(string.Format("Day {0:dddd} \n" +"Month {0:MMMM} \n" + "Year {0:yyyy}", PresentDate));



            // Check the day of the week
        //Console.WriteLine($"Is {formattedDate} a Friday? {PresentDate.DayOfWeek == DayOfWeek.Saturday}");

        }
    }
}
