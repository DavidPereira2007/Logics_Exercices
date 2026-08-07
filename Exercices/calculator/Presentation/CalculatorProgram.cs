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

            if (choice == "5")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
            
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = choice switch
            {
                "1" => CalculatorMain.Add(num1, num2),
                "2" => CalculatorMain.Subtract(num1, num2),
                "3" => CalculatorMain.Multiply(num1, num2),
                "4" => CalculatorMain.Divide(num1, num2),
                _ => throw new InvalidOperationException("Invalid choice.")
            };

            Console.WriteLine($"The result is: {result}");
        }
    }
}