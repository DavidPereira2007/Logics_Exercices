////////////////////////////////////////
/// by: David de Sousa Pereira 23/07/2026
/// Code: A simple exercice to count the number of vowels in a string
////////////////////////////////////////
namespace Exercice;
using System;

// Create a program that receives a string and counts the number of vowels in it.
public class VowelCounter
{
    private static bool ValidateString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new ArgumentException("The input string cannot be null or empty.");
        }

        return true;
    }

    public static int CountVowels(string input)
    {
        if (!ValidateString(input)) // validate the input string
        {
            throw new ArgumentException("The input string is not valid.");
        }

        int vowelCount = 0;
        string vowels = "aeiouAEIOU"; // define the vowels to check against

        foreach (char c in input) // loop through each character in the input string
        {
            if (vowels.Contains(c)) // Verify if c contain vowel
            {
                vowelCount++; // add a vowelCount
            }
        }

        return vowelCount;
    }

}