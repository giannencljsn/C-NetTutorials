using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
    class Program
    {
        static string name = "Gianne";
        static void Main(string[] args)
        {
            SayHi();
        }

        static void SayHi()
        {
            name = "Nicole";
            Console.WriteLine($"Hello there {name}");
        }
    }
}
