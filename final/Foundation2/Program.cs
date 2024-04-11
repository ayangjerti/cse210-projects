using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Console.WriteLine("Encapsulation with Online Ordering");
        Console.WriteLine();

        // Create first order of the day
        Address address1 = new Address("11 Nsefik eyo layout","Calabar", "Cross River State", "Nigeria");
        Customer customer = new Customer("Fred Offiong", address1 );
        Order order1 = new Order(customer);

        // new product
        Product product1 = new Product("Selfie ring light", 350, 0001, 3);
        Product product2 = new Product("Black adidas sneaker", 15700, 0099, 2);
        Product product3 = new Product("Oraimo 10000mAH power bank ", 14500, 0083, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);


        Console.WriteLine("-----First Order of the day:-----");
        Console.WriteLine();
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.PackingLabel());

        
        Console.WriteLine($"Total cost of order:  ${order1.CalculateTotalCost()}\n");



        // Create second order of the day
        Console.WriteLine("Encapsulation with Online Ordering");
        Console.WriteLine();


        Address address2 = new Address("11 Melborne drive","Los angeles", "California", "USA");
        Customer customer2 = new Customer("Gina Ann", address1 );
        Order order2 = new Order(customer2);

        // new product
        Product productX = new Product("Iphone 15 Pro Max", 35000, 0091, 8);
        Product productY = new Product("Coca Cola midi size", 100, 0029, 11);
        Product productZ = new Product("Casio water resistant men's watch ", 1800, 0023, 14);

        order2.AddProduct(productX);
        order2.AddProduct(productY);
        order2.AddProduct(productZ);


        Console.WriteLine("-----Second Order of the day:-----");
        Console.WriteLine();
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.PackingLabel());

        
        Console.WriteLine($"Total cost of order:  ${order2.CalculateTotalCost()}\n");
        Console.WriteLine("------THANKS FOR SHOPPING WITH US------");








    }
}