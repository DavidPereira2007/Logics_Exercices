////////////////////////////////////////
/// by: David de Sousa Pereira 24/07/2026
/// Code: Service Application
////////////////////////////////////////

namespace shopping_cart;

using System;

public static class Shopping_cartService
{
    private static List<Product> Products = new List<Product>();
    private static List<Cart> Carts = new List<Cart>();

    public static void Create_Product(string name, double price)
    {
        Product product = new Product();
        product.Create_Product(name, price);
        Products.Add(product);
    }

    public static void Create_Cart()
    {
        Cart cart = new Cart();
        cart.Create_Cart();
        Carts.Add(cart);
    }

    public static void Add_Product_To_Cart(int cartId, int productId)
    {
        Cart? cart = Carts.Find(c => c.Cart_Id() == cartId);
        Product? product = Products.Find(p => p.Product_Id() == productId);

        if (cart != null && product != null)
        {
            cart.Add_Product(product);
            Console.WriteLine($"Product {productId} added to Cart {cartId}.");
        }
        else
        {
            Console.WriteLine("Cart or Product not found.");
            List_Products();
            List_Carts();
        }
    }

    public static void Remove_Product_From_Cart(int cartId, int productId)
    {
        Cart? cart = Carts.Find(c => c.Cart_Id() == cartId);
        Product? product = Products.Find(p => p.Product_Id() == productId);

        if (cart != null && product != null)
        {
            cart.Remove_Product(product);
            Console.WriteLine($"Product {productId} removed from Cart {cartId}.");
        }
        else
        {
            Console.WriteLine("Cart or Product not found.");
        }
    }

    public static void Calculate_Cart_Total(int cartId)
    {
        Cart? cart = Carts.Find(cart => cart.Cart_Id() == cartId);
        
        if (cart == null)
        {
            Console.WriteLine("Cart not found.");
            return;
        }
        double total = cart.Calculate_Total();
        Console.WriteLine($"Total for Cart {cartId}: {total}");
    }

    public static void List_Products()
    {
        Console.WriteLine("Available Products:");
        foreach (var product in Products)
        {
            product.Write_Product();
            Console.WriteLine("--------------------");
        }
    }

    public static void List_Carts()
    {
        Console.WriteLine("Available Carts:");
        foreach (var cart in Carts)
        {
            cart.Write_Cart();
            Console.WriteLine("--------------------");
        }
    }
}