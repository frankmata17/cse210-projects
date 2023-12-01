using System;

class Program
{
    static void Main()
    {
        // Create products
        Product product1 = new Product("Laptop", "P001", 1000, 2);
        Product product2 = new Product("Mouse", "P002", 20, 3);
        Product product3 = new Product("Keyboard", "P003", 50, 1);

        // Create addresses
        Address address1 = new Address("123 Main St", "CityA", "StateA", "USA");
        Address address2 = new Address("456 Broad St", "CityB", "StateB", "Canada");

        // Create customers
        Customer customer1 = new Customer("Sara", address1);
        Customer customer2 = new Customer("Daniel", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product3);

        // Display order information
        DisplayOrderInformation(order1);
        Console.WriteLine();
        DisplayOrderInformation(order2);
    }

    static void DisplayOrderInformation(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine("\nTotal Price: $" + order.GetTotalPrice());
    }
}