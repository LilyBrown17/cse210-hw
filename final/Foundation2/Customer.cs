using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string ReturnCustomer()
    {
        return _name;
    }

    public string ReturnCustomerAddress()
    {
        return _address.ReturnAddress();
    }

    public bool IsFromUSA()
    {
        if (_address.IsUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}