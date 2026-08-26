////////////////////////////////////////
/// by: David de Sousa Pereira 08/08/2026
/// Code: Models for aplication in Services
////////////////////////////////////////

namespace LoginSystem;
using System;

public class User
{
    private int id;
    private string? username;
    private string? password;

    public void Create_User(string username, string password)
    {
        this.id = IdGenerator.GerarProximoId();
        this.username = username;
        this.password = password;
    }

    public int Id()
    {
        return id;
    }

    public string? Username()
    {
        return username;
    }

    public string? Password()
    {
        return password;
    }
}

