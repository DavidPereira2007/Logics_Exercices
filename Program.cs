using System;
using Bank_account;
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

    private static void Vowel_counterExerice()
    {
        string word = "Aladin";
        int Vowels = VowelCounter.CountVowels(word);

        Console.WriteLine(Vowels);
    }

    private static void Bank_Account()
    {
        Bank bank = new Bank();

        User user1 = Bank_Service.Create_User(bank,"David", 15000);

        bank.InfoAccounts();

        // depois fazer um loop simples pra:
        // Adicionar user, depositar, transferir, sacar
    }
    
    static void Main()
    {
        Console.WriteLine("Run program");
        //averageExercice();
        Bank_Account();
    }
}
        