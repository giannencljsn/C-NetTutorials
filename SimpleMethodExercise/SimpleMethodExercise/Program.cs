using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GetName();

        }

        static void GetName()
        {
            string name = string.Empty;
            name = Console.ReadLine();
            sayHi(name);
        }

        static void sayHi(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
    }
}
