using System;
//Ordering system with encapsulation
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 E St", "Ricksburg", "Blidaho", "USA");
        Customer customer1 = new Customer("Ian", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("MacGuffin", "A54321", 401.56, 2));
        order1.AddProduct(new Product("Goober", "B789", 0.62, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Address address2 = new Address("123 E St", "Ricksburg", "Blidaho", "not USA");
        Customer customer2 = new Customer("Ian", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("MacGuffin", "A54321", 401.56, 2));
        order2.AddProduct(new Product("Goober", "B789", 0.62, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");
    }

}