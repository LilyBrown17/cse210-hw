using System;

class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public string GetTotalPrice()
    {
        double price = 0.0;

        foreach (Product currentProduct in _products)
        {
            price += currentProduct.ReturnPrice();
        }

        if (_customer.IsFromUSA() == true)
        {
            price += 5.0;
        }
        else
        {
            price += 35.0;
        }

        string priceString = price.ToString("F");

        return priceString;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Product currentProduct in _products)
        {
            label = $"{label} \n {currentProduct.ReturnProduct()}";
        }
        return label;
    }


    public string ShippingLabel()
    {
        string customer = _customer.ReturnCustomer();
        string address = _customer.ReturnCustomerAddress();
        return $"{customer} \n {address}";
    }

    public void AddProduct(string productName, double productPrice, int productQuantity, string iD)
    {
        Product newProduct = new Product(productName, productPrice, productQuantity, iD);
        _products.Add(newProduct);
    }
}