////////////////////////////////////////
/// by: David de Sousa Pereira 24/07/2026
/// Code: Library Service
////////////////////////////////////////

namespace Library;

using System;
using System.Linq;


public static class LibraryService
{
    private static List<Book> books = new List<Book>();
    private static List<User> users = new List<User>();

    public static void Create_Books(string name, string desc, int page)
    {
        Book book = new Book();
        book.Create_Book(name, page, desc);

        Register_Book(book);
    }

    public static void Register_Book(Book book)
    {
        books.Add(book);
    }

    public static void List_Books()
    {
        foreach (var book in books)
        {
            Console.WriteLine("----------------------------------------");
            book.Write_Book();
            Console.WriteLine("----------------------------------------");
        }
    }

    public static void Register_User(User user, bool register)
    {
        if (register) // if true register user in library list
        {
            if (!users.Any(x => x.User_Id() == user.User_Id()))
            {
                users.Add(user);
            }
            
        }
        else // if false delete user register in library list
        {
            if (users.Any(x => x.User_Id() == user.User_Id()))
            {
                users.Remove(user);
            }
            
        }
    }

    public static void Get_Book(int bookId, User user)
    {
        var Book = books.FirstOrDefault(x => x.Book_Id() == bookId);

        if (Book != null)
        {
            if (Book.Book_available() == true)
            {
                // Book available
                Book.avaible_Book(false);
                user.receive_book(Book);
            }
            else
            {
                // Book in use
            }
        }
        else
        {
            // Book not found
        }
    }

    public static void Return_Book (int bookId, User user)
    {
        var Book_library = books.FirstOrDefault(x => x.Book_Id() == bookId);
        bool Book = user.Search_book(bookId);

        if (Book_library != null && Book)
        {
            user.return_book(Book_library);
            Book_library.avaible_Book(true);
        }
    }
}