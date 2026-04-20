using System;

namespace ConsoleAppAssignment
{
    // This class contains a method that performs a math operation
    class MathOperations
    {
        // This method takes two integers as parameters
        // It performs a math operation on the first integer
        // and displays the second integer to the screen
        public void PerformOperation(int number1, int number2)
        {
            // Perform a simple math operation (for example: multiply the first number by 2)
            int result = number1 * 2;

            // Display the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Display the second integer
            Console.WriteLine("Second number is: " + number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create (instantiate) an object of the MathOperations class
            MathOperations mathObj = new MathOperations();

            // Call the method by passing two numbers directly
            mathObj.PerformOperation(5, 10);

            Console.WriteLine(); // Add a blank line for readability


            // Call the method again, this time using named parameters
            mathObj.PerformOperation(number1: 7, number2: 20);

            // Keep the console window open until the user presses a key
            Console.ReadKey();
        }
    }
}

git init
git add .
git commit -m "Initial commit - console app assignment"
git branch -M main
git remote add origin https://github.com/yourusername/repositoryname.git
git push -u origin main
