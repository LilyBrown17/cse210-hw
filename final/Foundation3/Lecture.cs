using System;

class Lecture: Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address.ReturnAddress();
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails()
    {
        string full = $"{_title} (Lecture)\n\nSpeaker: {_speaker}\n\n{_date} @ {_time}\n\nCapacity: {_capacity} people\n\n{_description}\n\n{_address}";
        return full;
    }
}