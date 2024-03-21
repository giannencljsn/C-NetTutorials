using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //Methods 
        //    int a, b, c, d;
        //    int addResult = 0;

        //    a = 5;
        //    b = 3;
        //    addResult = a + b;
        //    Console.WriteLine($"{a} + {b} = {addResult}");
        //    Console.WriteLine("Process is done");

        //    c = 15;
        //    d = 10;
        //    addResult = c + d;
        //    Console.WriteLine($"{c} + {d} = {addResult}");
        //   DisplayMessage();
        //}

        //static void DisplayMessage()
        //{
        //    Console.WriteLine("Process is done");
        //    Console.WriteLine("The code is run by Gianne Nicole Juson");
        //    Console.WriteLine("Finished on " + DateTime.Now.ToShortTimeString());

        //}

        static void Main(string[] args)
        {
            int a, b;
            int addResult = 0;
            int subResult = 0;
            int multResult = 0;
            int divResult = 0;

            a = 5;
            b = 3;


            addResult = PerformAddOperation(a,b);
            subResult = PerformSubOperation(a,b);
            multResult = PerformMultOperation(a,b);
            divResult = PerformDivOperation(a,b);   

            Console.WriteLine($"{a} + {b} = {addResult}");
            Console.WriteLine($"{a} - {b} = {subResult}");
            Console.WriteLine($"{a} * {b} = {multResult}");
            Console.WriteLine($"{a} / {b} = {divResult}");



        }
        static int PerformAddOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x + y;
            return addResult;
        }

        static int PerformSubOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x - y;
            return addResult;
        }
        static int PerformMultOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x * y;
            return addResult;
        }
        static int PerformDivOperation(int x, int y)
        {
            int addResult = 0;
            addResult = x / y;
            return addResult;
        }
    }
}
