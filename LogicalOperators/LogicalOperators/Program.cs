using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool HasLicense = true;
            //bool KnowsHowToDrive = true;

            //if (HasLicense == true && KnowsHowToDrive == false)
            //{
            //    Console.WriteLine("Result:" + (HasLicense == true && KnowsHowToDrive == false));

            //} 
            //else if (HasLicense == true && KnowsHowToDrive == true)
            //{
            //    Console.WriteLine("Edi marunong kana magdrive."); 
            //}

            //OR  operator 
            bool WentForARun = true;
            bool WentForSkating = true;

            if(WentForARun && !WentForSkating)
            {
                Console.WriteLine("You are losing fat!");
            } else
            {
                Console.WriteLine("Move yo ass sometime bish!");
            }

        }
    }
}
