////////////////////////////////////////
/// by: David de Sousa Pereira 06/09/2026
/// Code: Hangman system
/// 
/// Hangman Exemple:
///  O
/// /|\
/// / \
/// 
////////////////////////////////////////
namespace Hangman;


using System;

public static class HangmanSystem
{


    public static void PlayHangman()
    {
        // Escolher uma palavra para o jogo da forca
        string word = ChooseWord();

        // Inicializar variáveis do jogo
        int wordLength = word.Length;

        char[] correctLetters = new char[wordLength];
        char[] IncorrectLetters = new char[26]; // 26 letters in the alphabet

        int incorrectCount = 0;

        // Começar o jogo da forca, gerando o loop de gameplay
        while (incorrectCount < 6 && new string(correctLetters) != word)
        {
            Console.Clear();

            PrintHangman(incorrectCount);
            PrintStateHangman(wordLength, correctLetters);
            PrintIncorrectLetters(IncorrectLetters);

            char letter = GetLetter();

            if (IsLetterCorrect(letter, word))
            {
                for (int i = 0; i < wordLength; i++) // Loop through the word to find all occurrences of the guessed letter
                {
                    if (word[i] == letter)
                    {
                        correctLetters[i] = letter;
                    }
                }
            }
            else
            {
                incorrectCount++;
                IncorrectLetters[IncorrectLetters.Length - 1] = letter; // Add the incorrect letter to the array of incorrect letters
            }
        }

        Console.Clear();

        // Check if the player has won or lost
        if (new string(correctLetters) == word)
        {
            Console.WriteLine($"Congratulations! You've guessed the word: {word}");
        }
        else
        {
            Console.WriteLine($"Game over! The correct word was: {word}");
        }
    }

    private static bool IsLetterCorrect(char letter, string word)
    {
        return word.Contains(letter);
    }

    private static void PrintIncorrectLetters(char[] IncorrectLetters)
    {
        Console.WriteLine(); // Space for better readability
        Console.Write("Incorrect letters: ");
        foreach (char letter in IncorrectLetters)
        {
            if (letter != '\0') // Check if the letter is not the default char value
            {
                Console.Write(letter + " ");
            }
        }
        Console.WriteLine();
    }

    private static char GetLetter()
    {
        Console.Write("Enter a letter:");
        char letter = Console.ReadKey().KeyChar;
        //Console.WriteLine(); // Move to the next line after reading the letter
        return letter;
    }

    private static string ChooseWord()
    {
        // Escolher uma palavra para o jogo da forca
        Console.WriteLine("Write a word for the hangman game:");
        string? word = Console.ReadLine();

        // Validate the input word
        if (word == null || word.Length == 0)
        {
            Console.WriteLine("Invalid word. Please try again.");
            return ChooseWord();
        }
        else
        {
            return word.ToLower();
        }
    }

    private static void PrintStateHangman(int Lenght, char[] correctLetters)
    {
        for (int i = 0; i < Lenght; i++)
        {
            if (i < correctLetters.Length && correctLetters[i] != '\0')
            {
                Console.Write(correctLetters[i] + " ");
            }
            else
            {
                Console.Write("_ ");
            }
        }
    }

    private static void PrintHangman(int stage)
    {
        // Part6
        if (stage < 6)
        {
            Console.WriteLine("  O");
        }
        // Part5
        if (stage < 5)
        {
            Console.Write(" /");
        }
        // Part4
        if (stage < 4)
        {
            Console.Write("|");
        }
        // Part3
        if (stage < 3)
        {
            Console.WriteLine("\\");
        }
        
        // Part2
        if (stage < 2)
        {
            Console.Write(" /");
        }
        
        // Part1
        if (stage < 1)
        {
            Console.WriteLine(" \\");   
        }
        Console.WriteLine(); // Move to the next line after printing the hangman
        
    }


    private static string RandomWord()
    {
        // Escolher uma palavra para o jogo da forca
        string[] words = { "banana", "abacaxi", "laranja", "morango", "uva" };
        Random random = new Random();
        int index = random.Next(words.Length);
        return words[index];
    }
}