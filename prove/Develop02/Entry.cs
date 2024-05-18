using System;

class Entry
{
    string _newEntry;
    
    public string Write()
    {
        Prompt _prompt = new Prompt();
        string _result = _prompt.Choose();
        Console.WriteLine(_result);
        string _response = Console.ReadLine();
        string _date = Date();

        _newEntry = $"Date: {_date} - Prompt: {_result}\n {_response}\n";
        return _newEntry;
    }

    public string Date()
    {
        DateTime _current = DateTime.Now;
        string _dateText = _current.ToShortDateString();
        return _dateText;
    }
}