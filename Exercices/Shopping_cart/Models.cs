////////////////////////////////////////
/// by: David de Sousa Pereira 24/07/2026
/// Code: Models for use em Application
////////////////////////////////////////

namespace shopping_cart;

using System;

public class Product
{
    private int id;
    private string? name;
    private double price;

    public void Create_Product(string NewName, double NewPrice)
    {
        id = IdGenerator.GerarProximoId();
        name = NewName;
        price = NewPrice;
    }

    public void Write_Product()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Price: {price}");
    }

    public int Product_Id()
    {
        return id;
    }

    public double Product_Price()
    {
        return price;
    }
}

public class Cart
{
    private int id;
    private List<Product> CartProducts = new List<Product>();

    public void Create_Cart()
    {
        id = IdGenerator.GerarProximoId();
    }

    public void Add_Product(Product product)
    {
        CartProducts.Add(product);
    }

    public void Remove_Product(Product product)
    {
        CartProducts.Remove(product);
    }

    public void Write_Cart()
    {
        Console.WriteLine($"Cart ID: {id}");
        Console.WriteLine("Products in the cart:");
        foreach (var product in CartProducts)
        {
            product.Write_Product();
            Console.WriteLine("--------------------");
        }
    }

    public double Calculate_Total()
    {
        double total = 0;
        foreach (var product in CartProducts)
        {
            total += product.Product_Price();
        }
        return total;
    }

    public int Cart_Id()
    {
        return id;
    }
}