using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //int y = 2;
            //int result = 0;

            //result = x + y;
            //Console.WriteLine(x.ToString() + "+" + y.ToString() + " = " + result) ;
            //result = x - y;
            //Console.WriteLine(x.ToString() + "-" + y.ToString() + " = " + result);
            //result = x * y;
            //Console.WriteLine(x.ToString() + "*" + y.ToString() + " = " + result);

            //var newResult = (float)x / y;
            //Console.WriteLine(x.ToString() + "/" + y.ToString() + " = " + newResult); ;
            //result = x % y;
            //Console.WriteLine(x.ToString() + "%" + y.ToString() + " = " + result);



            // int add, sub, mul, rem;
            // float div;

            // Console.WriteLine("Select operation: \n" +
            //                   "+  Addition \n" +
            //                   "-  Subtraction \n" +
            //                   "*  Multiplication \n" +
            //                   "/  Division \n" +
            //                   "%  Modulo \n");

            //string choice = Console.ReadLine();

            // Console.WriteLine("Enter first number: ");
            // int x = int.TryParse(Console.ReadLine(), out int parsedX) ? parsedX : 0;
            // Console.WriteLine("Enter second number: ");
            // int y = int.TryParse(Console.ReadLine(), out int parsedY) ? parsedY : 0;

            // switch (choice)
            // {
            //     case "+":
            //          add = x + y;
            //         Console.WriteLine(x.ToString() + " + " + y.ToString() + " = " + add);
            //         break;
            //     case "-":
            //         sub = x - y;
            //         Console.WriteLine(x.ToString() + " - " + y.ToString() + " = " + sub);
            //         break;

            //     case "*":
            //         mul = x - y;
            //         Console.WriteLine(x.ToString() + " * " + y.ToString() + " = " + mul);
            //         break;
            //     case "/":
            //         div = (float) x / y;
            //         Console.WriteLine(x.ToString() + " / " + y.ToString() + " = " + div);
            //         break;

            //     case "%":
            //         rem = x % y;
            //         Console.WriteLine(x.ToString() + " % " + y.ToString() + " = " + rem);
            //         break;


            //     default:
            //         Console.WriteLine("Invalid choice");
            //         break;
            // }


            int x, y;
            int add, sub, mult, rem;
            float div;

            Console.WriteLine("Enter no. 1 ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter no. 2");
            y = int.Parse(Console.ReadLine());

            add = x + y;
            sub = x - y;
            mult = x * y;
            div = (float)x / y;
            rem = x % y;

            Console.WriteLine($"{x.ToString()} + {y.ToString()} = {add} \n" +
                              $"{x.ToString()} - {y.ToString()} = {sub} \n" +
                              $"{x.ToString()} * {y.ToString()} = {mult} \n" +
                              $"{x.ToString()} / {y.ToString()} = {div} \n" +
                              $"{x.ToString()} % {y.ToString()} = {rem} \n");

        }
    }
}
