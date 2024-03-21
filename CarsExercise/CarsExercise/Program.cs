using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarsExercise
{
   class Car
    {
        static void Main(string[] args)
        {
           
            Mercedes mercedes = new Mercedes();
            mercedes.DisplayInfo();

            Benz benz = new Benz();
    
            benz.DisplayInfo();
        }



        class Mercedes
        {
            private decimal price = 10000;
            public string color = "black";
            protected int maxSpeed = 300;


            public virtual void DisplayInfo()
            {
                Console.WriteLine(
                    $"Default price : {price} \n" +
                    $"Default color : {color} \n" +
                    $"Default maxSpeed: {maxSpeed} \n");
            }

            protected decimal Price
            {
                get { return price; }
                set { price = value; }
            }
        }

        class Benz : Mercedes
        {

            public override void DisplayInfo()
            {
                decimal newPrice = Price;
                newPrice = 15000;

                color = "blue";
                maxSpeed = 280;
                Console.WriteLine(
                   $"Overriden price: {newPrice} \n" +
                   $"Overriden color: {color} \n" +
                   $"Overriden maxSpeed: {maxSpeed} \n");
            }

        }
    }
}
