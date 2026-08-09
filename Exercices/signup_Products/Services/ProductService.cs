////////////////////////////////////////
/// by: David de Sousa Pereira 09/08/2026
/// Code: Service for use in the application
////////////////////////////////////////


namespace SignUp_Products.Services;
using SignUp_Products.Models;
using SignUp_Products.Repository;


public static class ProductService
{
    public static void CreateProduct(string name, double price)
    {
        ProductBank.AddProduct(name, price);
    }

    public static void EditProduct(int id, string name, double price)
    {
        var product = ProductBank.GetProduct(id);
        product.EditProduct(name, price);
    }

    public static void DeleteProduct(int id)
    {
        ProductBank.RemoveProduct(id);
    }

    public static Product GetProduct(int id)
    {
        return ProductBank.GetProduct(id);
    }

    public static List<Product> GetAllProducts()
    {
        return ProductBank.GetAllProducts();
    }
}