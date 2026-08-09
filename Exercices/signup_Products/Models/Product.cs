////////////////////////////////////////
/// by: David de Sousa Pereira 09/08/2026
/// Code: Model for use in the application
////////////////////////////////////////


namespace SignUp_Products.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public void EditProduct(string name, double price)
    {
        Name = name;
        Price = price;
    }
}