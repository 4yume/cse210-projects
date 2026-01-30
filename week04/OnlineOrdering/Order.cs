using System;
using System.Collections.Generic;

public class Order
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

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: ";

        for (int i = 0; i < _products.Count; i++)
        {
            label += $"{_products[i].GetName()} - {_products[i].GetProductId()}";
            if (i < _products.Count - 1)
            {
                label += ",";
            }
        }
        return label;
    }
    
    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetCustomerName()} - {_customer.GetAddress()}";
    }
}