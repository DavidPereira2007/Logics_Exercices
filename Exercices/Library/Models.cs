////////////////////////////////////////
/// by: David de Sousa Pereira 24/07/2026
/// Code: Models for use em Application
////////////////////////////////////////
namespace Library;

using System;
using System.Linq;
public class Book
{
    private int id;
    private string? name;
    private int Pages;
    private string? desc;
    private bool available;

    public void Create_Book(string NewName, int NewPages, string NewDesc)
    {
        id = IdGenerator.GerarProximoId();
        name = NewName;
        Pages = NewPages;
        desc = NewDesc;
        available = true;

    }

    public void avaible_Book(bool Newavaible)
    {
        available = Newavaible;
    }

    public void Write_Book()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Desciption: {desc}");
        Console.WriteLine($"Pages: {Pages}");
        Console.WriteLine($"Availabel: {available}");
    }

    public int Book_Id()
    {
        return id;
    }

    public bool Book_available()
    {
        return available;
    }
}

public class User
{
    private int id;
    private string? name;
    private List<Book> UserBooks = new List<Book>();

    public void Create_User(string new_name)
    {
        id = IdGenerator.GerarProximoId();
        name = new_name;
    }

    public int User_Id()
    {
        return id;
    }

    public void receive_book(Book book)
    {
        UserBooks.Add(book);
    }

    public void return_book(Book book)
    {
        UserBooks.Remove(book);
    }

    public bool Search_book(int bookid)
    {
        return UserBooks.Any(x => x.Book_Id() == bookid);
    }
}
