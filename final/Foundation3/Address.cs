using System;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zip;

    public Address(string streetAddress, string city, string state, string zip)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zip = zip;
    }

    public string ReturnAddress()
    {
        string addressString = $"{_streetAddress} \n {_city}, {_state} {_zip}";
        return addressString;
    }
}