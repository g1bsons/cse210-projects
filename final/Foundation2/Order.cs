using System;
using System.Collections.Generic;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product p in _products)
        {
            total = total + p.GetTotalCost();
        }

        if(_customer.LivesInUSA())
        {
            total = total +5;
        }
        else
        {
            total = total + 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";

        foreach( Product p in _products)
        {
            label = p.GetProductInfo() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:" + "\n" + _customer.ShippingInfo();
    }

    public void ShowOrderDetails()
    {
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine($"Total Price: ${GetTotalCost():F2}");
    }
}