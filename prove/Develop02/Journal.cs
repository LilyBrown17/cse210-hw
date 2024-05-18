using System;
using System.IO;

class Journal
{
    List<string> _entries = new List<string>();
        
    public void Save()
    {
        string _newJournal = ToNewString("");

        Console.WriteLine("What would you like to name the file?");
        string _filename = Console.ReadLine();

        using (StreamWriter _outputFile = new StreamWriter(_filename))
        {
            _outputFile.WriteLine(_newJournal);
        } 
    }

    public void AddEntry(string _entry)
    {
        _entries.Add(_entry);
    }

    public string ToNewString(string _journal)
    {
        List<string> _entryList = ReturnEntries();
        foreach(string _entry in _entryList)
        {
            _journal = $"{_journal} \n \n {_entry}";
        }
        return _journal;
    }

    public List<string> ReturnEntries()
    {
        return _entries;
    }
}