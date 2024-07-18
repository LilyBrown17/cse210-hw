using System;

class Outdoor: Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.ReturnAddress();
        _weather = weather;
    }

    public string FullDetails()
    {
        string full = $"{_title} (Outdoor Gathering)\n\n{_date} @ {_time}\n\nPredicted Weather: {_weather}\n\n{_description}\n\n{_address}";
        return full;
    }
}