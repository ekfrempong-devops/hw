using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1

        Address address1 = new Address(
            "123 Main Street",
            "Provo",
            "Utah",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Product product1 = new Product(
            "Laptop",
            "L001",
            800.00,
            1);

        Product product2 = new Product(
            "Wireless Mouse",
            "M002",
            25.00,
            2);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);


        // ORDER 2

        Address address2 = new Address(
            "15 Independence Avenue",
            "Accra",
            "Greater Accra",
            "Ghana");

        Customer customer2 = new Customer(
            "Kwame Mensah",
            address2);

        Product product3 = new Product(
            "Keyboard",
            "K003",
            45.00,
            1);

        Product product4 = new Product(
            "Monitor",
            "M004",
            250.00,
            2);

        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);


        // DISPLAY ORDER 1

        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine();

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine();


        // DISPLAY ORDER 2

        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}