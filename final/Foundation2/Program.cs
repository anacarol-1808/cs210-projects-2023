using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Once you have created these classes, 
        write a program that creates at least two orders with a 2-3 products each. 
        Call the methods to get the packing label, the shipping label, 
        and the total price of the order, and display the results of these methods.
        */


        Console.Clear();
        //First Order
        List<Product> products1 = new List<Product>();
        Customer customer1 = new Customer("John Lennon", new Address("1940 Scotland Road", "Liverpool", "United Kingdom", "England"));
        products1.Add(new Product("Strawberry Fields History Book", "ABC123456", 19.95, 1));
        products1.Add(new Product("Black Acustic Guitar", "DEF789456", 79.95, 4));
        products1.Add(new Product("Acustic Microphone", "JKL789456", 20.95, 3));
        Order order1 = new Order(customer1, products1);
        Console.WriteLine($"First Order:\r\n");
        Console.WriteLine($"Packing Label");
        order1.GetPackingLabel();
        Console.WriteLine($"**********");
        Console.WriteLine($"Shipping Label");
        order1.GetShippingLabel();
        Console.WriteLine($"**********");
        Console.WriteLine($"Order Total");
        Console.WriteLine($"${order1.ComputeTotalCostWithShippingCost()}");
        Console.WriteLine($"**********\r\n");

        //Second Order
        List<Product> products2 = new List<Product>();
        Customer customer2 = new Customer("Russel M. Nelson", new Address("47 E. South Temple St.", "Salt Lake City", "Utah", "United States Of America"));
        products2.Add(new Product("The Book of Mormon", "ABC654321", 5.00, 1));
        products2.Add(new Product("The Holy Bible", "DEF123456", 5.00, 4));
        products2.Add(new Product("White Dress Shirt", "GHI654321", 7.00, 2));
        products2.Add(new Product("Sacred Oil Dispenser", "JKL654987", 12.00, 1));
        Order order2 = new Order(customer2, products2);
        Console.WriteLine($"Second Order:\r\n");
        Console.WriteLine($"Packing Label");
        order2.GetPackingLabel();
        Console.WriteLine($"**********");
        Console.WriteLine($"Shipping Label");
        order2.GetShippingLabel();
        Console.WriteLine($"**********");
        Console.WriteLine($"Order Total");
        Console.WriteLine($"${order2.ComputeTotalCostWithShippingCost()}");
        Console.WriteLine($"**********\r\n");

    }
}