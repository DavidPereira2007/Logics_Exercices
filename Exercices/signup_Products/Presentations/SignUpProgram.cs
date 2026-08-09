////////////////////////////////////////
/// by: David de Sousa Pereira 09/08/2026
/// Code: Interface for consume in the application
////////////////////////////////////////


namespace SignUp_Products.Presentations;
using SignUp_Products.Models;
using SignUp_Products.Services;

public static class SigUpProgram
{

    private static void Clear_Console()
    {
        Console.Clear();

        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Create Product");
        Console.WriteLine("2. Edit Product");
        Console.WriteLine("3. Delete Product");
        Console.WriteLine("4. View Product");
        Console.WriteLine("5. View All Products");
        Console.WriteLine("6. Exit");
    }

    private static void CreateProduct()
    {
        Clear_Console();
        Console.Write("Enter product name: ");
        var name = Console.ReadLine();

        Console.Write("Enter product price: ");
        var price = Console.ReadLine();

        if (!double.TryParse(price, out double priceValue))
        {
            Console.WriteLine("Invalid price. Please enter a valid number.");
            return;
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Product name cannot be empty.");
            return;
        }

        ProductService.CreateProduct(name, priceValue);
        Console.WriteLine($"Product created successfully | Name: {name}, Price: {priceValue}");
    }

    private static void EditProduct()
    {
        Clear_Console();
        Console.Write("Enter product ID to edit: ");
        var idInput = Console.ReadLine();

        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid ID. Please enter a valid number.");
            return;
        }

        try
        {
            var product = ProductService.GetProduct(id);

            Console.Write($"Enter new name for product (current: {product.Name}): ");
            var newName = Console.ReadLine();

            Console.Write($"Enter new price for product (current: {product.Price}): ");
            var newPriceInput = Console.ReadLine();

            if (!double.TryParse(newPriceInput, out double newPrice))
            {
                Console.WriteLine("Invalid price. Please enter a valid number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("Product name cannot be empty.");
                return;
            }

            ProductService.EditProduct(id, newName, newPrice);
            Console.WriteLine($"Product updated successfully | ID: {id}, New Name: {newName}, New Price: {newPrice}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void DeleteProduct()
    {
        Clear_Console();
        Console.Write("Enter product ID to delete: ");
        var idInput = Console.ReadLine();

        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid ID. Please enter a valid number.");
            return;
        }

        try
        {
            ProductService.DeleteProduct(id);
            Console.WriteLine($"Product with ID {id} deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void ViewProduct()
    {
        Clear_Console();
        Console.Write("Enter product ID to view: ");
        var idInput = Console.ReadLine();

        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid ID. Please enter a valid number.");
            return;
        }

        try
        {
            var product = ProductService.GetProduct(id);
            Console.WriteLine($"Product Details | ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void ViewAllProducts()
    {
        Clear_Console();
        var products = ProductService.GetAllProducts();

        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        Console.WriteLine("All Products:");
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
        }
    }


    public static void init()
    {
        Console.WriteLine("Welcome to the Product Management System");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Create Product");
        Console.WriteLine("2. Edit Product");
        Console.WriteLine("3. Delete Product");
        Console.WriteLine("4. View Product");
        Console.WriteLine("5. View All Products");
        Console.WriteLine("6. Exit");

        while (true)
        {
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateProduct();
                    break;
                case "2":
                    EditProduct();
                    break;
                case "3":
                    DeleteProduct();
                    break;
                case "4":
                    ViewProduct();
                    break;
                case "5":
                    ViewAllProducts();
                    break;
                case "6":
                    Console.WriteLine("Exiting the application. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}