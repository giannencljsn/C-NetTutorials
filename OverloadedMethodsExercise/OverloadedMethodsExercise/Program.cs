using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedMethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter up to 3 numbers separated by commas");
            string userInput = Console.ReadLine();

            //Split the input into an array of strings
            string[] inputArray = userInput.Split(',');

            //Create an array to store parsed integers
            int[] numbers = new int[inputArray.Length];

            //Create an array to store parsed double
            double[] decimals = new double[inputArray.Length];  
            //Parse each element in the input array
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out numbers[i]))
                {
                    Console.WriteLine($"Integer {i + 1}: {numbers[i]}");
                    
                }
                else if (double.TryParse(inputArray[i], out decimals[i]))
                {
                    Console.WriteLine($"Double {i + 1}: {decimals[i]}");
                }
                else
                {
                    Console.WriteLine($"Invalid input for number {i + 1}. Please enter a valid integer");
                    return;
                }
            }

            int sum = CalculateSum(numbers);
            //Console.WriteLine($"The sum is {sum}");

            double sumDouble = CalculateDouble(decimals);
            //Console.WriteLine($"The sum of double is {sumDouble}");

            if (sum != 0)
            {
                Console.WriteLine($"The sum is {sum}");
            }
            else
            {
                Console.WriteLine($"The sum of double is {sumDouble}");
            }

        }

        static int CalculateSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static double CalculateDouble(double[] decimals)
        {
            double sumDouble = 0;
            foreach(double pointnumbers in decimals){
                sumDouble += pointnumbers;
            }
            return sumDouble;
        }

        
    }
}