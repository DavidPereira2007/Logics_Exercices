////////////////////////////////////////
/// by: David de Sousa Pereira 05/08/2026
/// Code: Service Application
////////////////////////////////////////

namespace Calculator;
using System;


public static class CalculatorMain
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }
}