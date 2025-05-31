using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm St", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Smartphone", "SP100", 799.99, 1));
        order1.AddProduct(new Product("Wireless Earbuds", "WE200", 129.99, 2));

        Address address2 = new Address("456 King St", "London", "Greater London", "UK");
        Customer customer2 = new Customer("Bob Williams", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop", "LT300", 1200.00, 1));
        order2.AddProduct(new Product("USB-C Dock", "UD400", 79.99, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
        


    }
}