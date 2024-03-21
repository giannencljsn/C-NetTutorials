using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstEmployee, secondEmployee;

            firstEmployee = "David Smith";
            secondEmployee = "Sophia Watson";

            Console.WriteLine($"Inside Main Method \n-----\n {firstEmployee} \n{secondEmployee}\n\n");

            ChangeNames(ref firstEmployee, ref secondEmployee);
            Console.WriteLine($"Inside Main Method \n----\n {firstEmployee} \n{secondEmployee} \n\n");
        }

        static void ChangeNames(ref string firstEmp, ref string secEmp)
        {
            firstEmp = "Olivia Aaron";
            secEmp = "Alvaro Salazar";
            Console.WriteLine($"Outside Main Method \n---\n {firstEmp}, \n{secEmp} \n \n");
        }
    }
}
