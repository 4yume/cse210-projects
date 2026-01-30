using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}