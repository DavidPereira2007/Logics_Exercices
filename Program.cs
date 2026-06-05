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

    private static void convertorTimeExercice()
    {
        int totalSeconds = 3665; // seconds exemple for testing
        var (hours, minutes, seconds) = Convertor_time.ConvertSeconds(totalSeconds);
        Console.WriteLine($"{totalSeconds} seconds is equal to {hours} hours, {minutes} minutes and {seconds} seconds.");
    }
    
    static void Main()
    {
        Console.WriteLine("Run program");
        //averageExercice();
        convertorTimeExercice();
    }
}
        