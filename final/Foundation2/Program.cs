using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("9076 E 29th St", "Tulsa", "OK", "USA");
        Customer customer1 = new Customer("Gregory Smith", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Phone", "P100", 699.99, 4));
        order1.AddProduct(new Product("Tablet", "T200", 399.99, 8));

        Address address2 = new Address("2730 W Tibbets Blvd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jame Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Earbuds", "B300", 249.99, 60));
        order2.AddProduct(new Product("Speaker", "S400", 79.99, 10));

        Console.WriteLine("Order 1 ");
        order1.ShowOrderDetails();
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Order 2 ");
        order2.ShowOrderDetails();
    }
}
