////////////////////////////////////////
/// by: David de Sousa Pereira 08/08/2026
/// Code: Interface for consume aplication
////////////////////////////////////////

namespace LoginSystem;
using System;
using LoginSystem;


public static class LoginProgram
{
    public static void InitProgram()
    {
        Console.WriteLine("Welcome to the Login System!");
        Console.WriteLine("Please enter your username:");
        string username = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Please enter your password:");
        string password = Console.ReadLine() ?? string.Empty;

        try
        {
            User user = LoginService.Create_User(username, password);
            Console.WriteLine($"User '{user.Username()}' created successfully!");

            // Validate the user
            bool isValid = LoginService.Validade_User(user, password);
            if (isValid)
            {
                Console.WriteLine("User validated successfully!");
            }
            else
            {
                Console.WriteLine("Invalid password.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}