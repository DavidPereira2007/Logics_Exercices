using System;
using Exercice;
class Program
{
    static void Main()
    {
        Console.WriteLine("Run program");
        double[] grades = { 6.5, 5.0, 6.0, 5.2 }; // grades exemple for testing
        double average = GradeAverage.Calculateaverage(grades);
        Console.WriteLine($"The average grade is: {average:F2}");
    }
}