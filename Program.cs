using System;
using Exercice;
class Program
{
    private static void averageExercice()
    {
        double[] grades = { 6.5, 5.0, 6.0, 5.2 }; // grades exemple for testing
        double average = GradeAverage.Calculateaverage(grades);
        Console.WriteLine($"The average grade is: {average:F2}");
    }
    
    static void Main()
    {
        Console.WriteLine("Run program");
        averageExercice();
    }
}
        