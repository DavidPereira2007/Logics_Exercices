////////////////////////////////////////
/// by: David de Sousa Pereira 08/08/2026
/// Code: Services for aplication in LoginSystem
////////////////////////////////////////

namespace LoginSystem;
using System;


public static class LoginService
{
    public static User Create_User(string username, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Username and password cannot be empty.");
        }


        User user = new User();
        user.Create_User(username, password);
        return user;
    }

    public static bool Validade_User(User user, string password)
    {
        if (user == null)
        {
            throw new ArgumentNullException(nameof(user), "User cannot be null.");
        }

        return user.Password() == password;
    }
}