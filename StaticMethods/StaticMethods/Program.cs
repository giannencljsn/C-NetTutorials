using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
     class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person();
            person.SayHi();
        }
        
        static void SayHi()
        {
            Console.WriteLine("Hello everyone. This is coming from Static method");
        }
    }
}
