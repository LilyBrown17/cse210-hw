using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string ReturnAddress()
    {
        string addressString = $"{_streetAddress} \n {_city}, {_state} \n {_country}";
        return addressString;
    }

    public bool IsUSA()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}