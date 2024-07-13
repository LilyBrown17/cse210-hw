using System;

class Product
{
    private string _productName;
    private double _productPrice;
    private double _productQuantity;
    private string _iD;

    public Product (string productName, double productPrice, int productQuantity, string iD)
    {
        _productName = productName;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
        _iD = iD;
    }

    public string ReturnProduct()
    {
        string productString = $"{_productName}: {_iD} (Qnty: {_productQuantity})";
        return productString;
    }

    public double ReturnPrice()
    {
        double price = _productPrice * _productQuantity;
        return price;
    }
}