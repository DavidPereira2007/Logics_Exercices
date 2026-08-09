////////////////////////////////////////
/// by: David de Sousa Pereira 09/08/2026
/// Code: Repository for use in the application
////////////////////////////////////////


namespace SignUp_Products.Repository;
using SignUp_Products.Models;
using System;
using System.Linq;

public static class ProductBank
{
    private static List<Product> products = new List<Product>();
    private static int nextId = 1;

    public static void AddProduct(string name, double price)
    {
        var product = new Product(nextId++, name, price);
        products.Add(product);
    }

    public static void RemoveProduct(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            throw new Exception($"Product with ID {id} not found.");
        }
        else
        {
            products.Remove(product);
        }
    }

    public static Product GetProduct(int id)
    {
        var product = products.FirstOrDefault(p => p.Id == id);

        if (product == null)
        {
            throw new Exception($"Product with ID {id} not found.");
        }
        else
        {
            return product;
        } 
    }

    public static List<Product> GetAllProducts()
    {
        return products;
    }
}