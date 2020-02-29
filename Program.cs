using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am Tyler Gunnells." + "\n");

            Console.WriteLine("Please input a random interger.");

            int inputValue1;
            while (!int.TryParse(Console.ReadLine(), out inputValue1))
            {
                Console.Clear();
                Console.WriteLine("Please input a random interger.");
            };

            Console.WriteLine("\n" + "Please input a random interger.");

            int inputValue2;
            while (!int.TryParse(Console.ReadLine(), out inputValue2))
            {
                Console.Clear();
                Console.WriteLine("Please input a random interger.");
            };

            Console.WriteLine("\n" + "Please enter an operation. Type Addition, Subtraction, Division, or Multiplication.");

            string function = Console.ReadLine();

            if (function == "Multiplication")
            {
                Console.WriteLine("Your input equals: " + (inputValue1 * inputValue2));
            }
            else if (function == "Addition")
            {
                Console.WriteLine("Your input equals: " + (inputValue1 + inputValue2));
            }
            else if (function == "Subtraction")
            {
                Console.WriteLine("Your input equals: " + (inputValue1 + inputValue2));
            }
            else if (function == "Division" && inputValue2 == 0)
            {
                Console.WriteLine("Cannot use the value 0 as a divisor.");
            }
            else if (function == "Division")
            {
                Console.WriteLine("Your input equals: " + (inputValue1 - inputValue2));
            }
            else
            {
                Console.WriteLine("Please resubmit your input values using the correct format.");
            }

        }
    }
}
