using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;

            Console.WriteLine(myDate);
            Console.WriteLine(myDate.ToShortDateString());
            Console.WriteLine(myDate.ToLongDateString());
            Console.WriteLine(myDate.ToShortTimeString());
            Console.WriteLine(myDate.ToLongTimeString());

            Console.WriteLine(myDate.AddDays(-9));
            Console.WriteLine(myDate.AddYears(10));

            string formattedDate = string.Format("Date is {0:yyyy M dd HH mm ss tt}", myDate);
          
            Console.WriteLine(formattedDate);
    




        }
    }
}
