using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("2423", "Provo", "Utah", "USA");
        Address address2 = new Address("4322", "Sakai", "Osaka", "Japan");

        Customer customer1 = new Customer("Mike", address1);
        Customer customer2 = new Customer("Sakura", address2);

        Product product1 = new Product("apple", "1323", 1.2, 5);
        Product product2 = new Product("orange", "1262", 3.1, 2);
        Product product3 = new Product("Shoes", "5325", 50.24, 1);
        Product product4 = new Product("socks", "6194", 5.61, 5);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product3);

        order2.AddProduct(product2);
        order2.AddProduct(product4);

        Console.WriteLine($"order1");
        Console.WriteLine($"\t{order1.GetPackingLabel()}");
        Console.WriteLine($"\t{order1.GetShippingLabel()}");
        Console.WriteLine($"\tTotal Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        Console.WriteLine("order2");
        Console.WriteLine($"\t{order2.GetPackingLabel()}");
        Console.WriteLine($"\t{order2.GetShippingLabel()}");
        Console.WriteLine($"\tTotal Price: ${order2.GetTotalPrice():F2}");
    }
}