using System;

class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.ReturnAddress();
    }

    public string StandardDetails()
    {
        string detailStandard = $"{_title}\n\n{_date} @ {_time}\n\n{_description}\n\n{_address}";	
        return detailStandard;
    }

    public string ShortDetails()
    {
	    string detailShort = $"{_title}\n\n{_date}\n\n{_description}";
	    return detailShort;
    }
}