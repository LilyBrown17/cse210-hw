using System;

class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string date, string time, Address address, string rsvp) : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.ReturnAddress();
        _rsvp = rsvp;
    }

    public string FullDetails()
    {
        string full = $"{_title} (Reception)\n\n{_date} @ {_time}\n\n{_description}\n\n{_address}\n\nRSVP to {_rsvp}";
        return full;
    }  
}