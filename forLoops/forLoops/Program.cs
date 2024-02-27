using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int pubertyAge = 0;
            int currentAge = 0;
            Console.WriteLine("How old are you?");
            currentAge = int.Parse(Console.ReadLine());
            Console.WriteLine("What age did puberty hit you?");
            pubertyAge = int.Parse(Console.ReadLine());

            for(int g = currentAge; g >=1; g--)
            {
                Console.WriteLine("Gianne is the best cybersecurity specialist!" + g);
                if(g == pubertyAge+1) {
                    Console.WriteLine("Puberty days are coming...");
                    break;
                        }
            }
        }
    }
}
