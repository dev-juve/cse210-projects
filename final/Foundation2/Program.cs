using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("Laptop", "P001", 800.00, 2);
        Product product2 = new Product("Printer", "P002", 150.00, 1);
        Product product3 = new Product("Headphones", "P003", 50.00, 3);

        // Create customers with addresses
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Oak St", "Another Town", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);   
        order1.AddProduct(product2);
        order1.AddProduct(product3); 

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product3);
        // Display results
        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nOrder 2 - Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("\nOrder 1 - Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nOrder 2 - Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nOrder 1 - Total Price: $" + order1.CalculateTotalPrice());
        Console.WriteLine("Order 2 - Total Price: $" + order2.CalculateTotalPrice());
    }
}

