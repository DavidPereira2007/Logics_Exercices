using System;
using Bank_account;
using Exercice;
using Library;
using shopping_cart;
using GerencerEmployee;
using Universal_converter;
using Calculator;
using LoginSystem;
using SignUp_Products.Presentations;
using Grading.Presentation;
using Operator;
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

        Bank_account.User user1 = Bank_Service.Create_User(bank,"David", 15000);

        bank.InfoAccounts();

        // depois fazer um loop simples pra:
        // Adicionar user, depositar, transferir, sacar
    }

    private static void LibraryExercice()
    {
        Library.User user1 = new Library.User();
        user1.Create_User("David");

        Library.User user2 = new Library.User();
        user1.Create_User("Breno");

        // Books
        LibraryService.Create_Books("Teoria dos mares", "Um livro sobre os mares", 350);
        LibraryService.Create_Books("As aventuras do doutor pinto", "Um livro que conta as maravilhosas aventuras do doutor pinto um grande cientista", 400);
        LibraryService.Create_Books("Em Busca do castelo encantado", "A historia mais encantada de todos os tempos porém trágica", 2500);
        LibraryService.Create_Books("Comidas de teodoro", "Descubra as incriveis receitas do maior cozinheiro teodoro", 200);
        LibraryService.Create_Books("Grite", "Mergulhe nesse livro cheio de suspense e terror", 625);
        LibraryService.Create_Books("Uma lição de vida", "Leia sobre uma historia que você pode levar para toda a vida", 400);

        LibraryService.Get_Book(5, user1);

        LibraryService.List_Books();

    }

    private static void Shopping_cartsExercice()
    {
        Shopping_cartService.Create_Product("Laptop", 1500.0);
        Shopping_cartService.Create_Product("Mouse", 25.0);
        Shopping_cartService.Create_Cart();
        Shopping_cartService.Add_Product_To_Cart(3, 1);
        Shopping_cartService.Add_Product_To_Cart(3, 2);
        Shopping_cartService.Calculate_Cart_Total(3);
    }

    private static void GerencerEmployeeExercice()
    {
        GerencerEmployeeService.Create_Employee("David", 5000);
        GerencerEmployeeService.Create_Employee("Breno", 6000);
        GerencerEmployeeService.List_Employees();
        //GerencerEmployeeService.Increase_Salary(1, 10);
        //GerencerEmployeeService.Deduct_Salary(2, 5);
        //GerencerEmployeeService.List_Employees();

        GerencerEmployeeService.Calculate_NetPay(1);
        GerencerEmployeeService.Calculate_NetPay(2);
    }

    private static void ConvertorExercice()
    {
        // celsius to fahrenheit
        //double celsius = 25.0; // Celsius example for testing
        //double fahrenheit = ConverterService.CelsiusToFahrenheit(celsius);
        //Console.WriteLine($"{celsius} °C is equal to {fahrenheit:F2} °F.");

        // kilometer to mile
        //decimal kilometers = 10.0m; // Kilometers example for testing
        //decimal miles = ConverterService.KilometerToMile(kilometers);
        //Console.WriteLine($"{kilometers} kilometers is equal to {miles:F2} miles.");

        // hours to minutes
        //int hours = 2; // Hours example for testing
        //int minutes = ConverterService.HoursToMinutes(hours);
        //Console.WriteLine($"{hours} hours is equal to {minutes} minutes.");

        // real to dollar
        //double reais = 100.0; // Reais example for testing
        //double exchangeRate = 5.09; // Exchange rate example for testing
        //double dollars = ConverterService.RealToDollar(reais, exchangeRate);
        //Console.WriteLine($"{reais} reais is equal to {dollars:F2} dollars.");

    }

    private static void CalculatorExercice()
    {
        Calculator.CalculatorProgram.InitProgram();
    }    

    private static void LoginSystemExercice()
    {
        LoginSystem.LoginProgram.InitProgram();
    }
    static void Main()
    {
        Console.WriteLine("Run program");
        //averageExercice();
       //LibraryExercice();
        //CalculatorExercice();
        //LoginSystemExercice();
        //SigUpProgram.init();317
        //GradingProgram.init();
       Console.Write(RomanNumeral.ConvertoNumeralRoman("VI"));
    }
}
        