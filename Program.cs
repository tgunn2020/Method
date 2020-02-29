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

            const string M = "Multiplication";
            const string S = "Subtraction";
            
            while 
            {
                Console.Clear();
                Console.WriteLine("Please enter an operation. Type Addition, Subtraction, Division, or Multiplication.");
            }

            if (function == M)
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
            else if (function == "Division")
            {
                Console.WriteLine("Your input equals: " + (inputValue1 - inputValue2));
            }
            else if (function != (M || S )
            {
                Console.WriteLine("Please retry your equation.");
            }
        }
    }
}
