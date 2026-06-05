namespace Exercice;
using System;
using System.Linq;
// Create a program that receives 4 grades from a student and calculates the average.
public class GradeAverage
{
    
    private static bool  ValidateGrades(double[] grades)
    {
        if (grades.Length <= 1 )
        {
            throw new ArgumentException("The array of grades cannot be empty and must be greater than 1.");
        }

        foreach (double grade in grades)
        {
            if (grade < 0)
            {
                throw new ArgumentException("The grades cannot be negative.");
            }
        }

        return true;
    }

    public static double Calculateaverage(double[] grades)
    {
        if (!ValidateGrades(grades)) // Validation of the grades array
        {
            throw new ArgumentException("The array of grades is not valid.");
        }

        double SumofGrades = grades.Sum();

        return SumofGrades / grades.Length;
    }

}