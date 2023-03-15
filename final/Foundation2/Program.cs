using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create some customers  
        Address address1 = new Address("3402 Todd St", "Madera", "CA", "USA");
        Customer customer1 = new Customer("Troy McNeil", address1);

        Address address2 = new Address("17 Cherry Tree Lane", "Beverly", "Yorkshire", "UK");
        Customer customer2 = new Customer("Mary Poppins", address2);

        //create a few products
        Product product1 = new Product("Gizmo", "JAM123", 9.99, 3);
        Product product2 = new Product("Gadget", "JAM456", 19.99, 2);
        Product product3 = new Product("Spoonful of Sugar", "JAM789", 5.99, 1);

        //create some orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);


        //Display packing and shipping labels and total cost for each order

        Console.WriteLine("Order 1:");
        Console.WriteLine("PackingLabel:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("ShippingLabel:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.ComputeCost()}\n");


        Console.WriteLine("Order 2:");
        Console.WriteLine("PackingLabel:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("ShippingLabel:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.ComputeCost()}\n");

    }
}

//Make sure that all member variables are private and getters, setters, and constructors are created as needed.

//Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results of these methods.