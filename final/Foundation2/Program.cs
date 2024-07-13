using System;

class Program
{
    static void Main(string[] args)
    {
        Address _userAddress = new Address("12503 Mount Belford Way", "Peyton", "CO", "USA");
        Customer _userCustomer = new Customer("Lily Brown", _userAddress);
        Order _order1 = new Order(_userCustomer);
        Order _order2 = new Order(_userCustomer);

        _order1.AddProduct("T-Shirt", 6.49, 2, "16502");
        _order1.AddProduct("Jeans", 10.69, 3, "17804");
        _order1.AddProduct("Notebook", 7.50, 1, "21303");

        _order2.AddProduct("Backpack", 11.35, 1, "14067");
        _order2.AddProduct("Socks", 4.99, 5, "13409");

        string _price1 = _order1.GetTotalPrice();
        string _price2 = _order2.GetTotalPrice();

        string _shipping1 = _order1.ShippingLabel();
        string _shipping2 = _order2.ShippingLabel();

        string _packing1 = _order1.PackingLabel();
        string _packing2 = _order2.PackingLabel();

        Console.WriteLine($"Order 1 \n \n {_shipping1} \n {_packing1} \n \n Total Price: ${_price1} \n \n");
        Console.WriteLine($"Order 2 \n \n {_shipping2} \n {_packing2} \n \n Total Price: ${_price2} \n \n");
    }
}