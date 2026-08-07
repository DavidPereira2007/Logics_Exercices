////////////////////////////////////////
/// by: David de Sousa Pereira 05/08/2026
/// Code: Interface Application
////////////////////////////////////////

namespace Calculator;
using System;
using Calculator;

public static class CalculatorProgram
{
    public static void InitProgram()
    {
        Console.WriteLine("Welcome to the Calculator Program!");
        Console.WriteLine("Please select an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");

        while (true)
        {
            Console.Write("Enter your choice (1-5): ");
            string? choice = Console.ReadLine();

            if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5") // Verify if the choice is valid
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            if (choice == "5") // If choice is 5, exit the program
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }

            Console.Write("Enter the first number: ");
            var num1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            var num2 = Console.ReadLine();

            if (!double.TryParse(num1, out double number1) || !double.TryParse(num2, out double number2)) // Verify if the inputs are valid numbers, if inputs is valid, convert to the new variables number1 and number2
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
                continue;
            }

            double result = choice switch // Call the CalculatorMain methods based in theu ser choice, and return result for the user
            {
                "1" => CalculatorMain.Add(number1, number2),
                "2" => CalculatorMain.Subtract(number1, number2),
                "3" => CalculatorMain.Multiply(number1, number2),
                "4" => CalculatorMain.Divide(number1, number2),
                _ => throw new InvalidOperationException("Invalid choice.")
            };

            Console.WriteLine($"The result is: {result}");
        }
    }
}