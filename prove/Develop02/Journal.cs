using System;
using System.IO;

class Journal
{
    List<string> _entries = new List<string>();
        
    public void Save()
    {
        string newJournal = ToNewString("");

        Console.WriteLine("What would you like to name the file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(newJournal);
        } 
    }

    public void AddEntry(string entry)
    {
        entries.Add(entry);
    }

    public string ToNewString(string journal)
    {
        List<string> entryList = ReturnEntries();
        foreach(string entry in entryList)
        {
            journal = $"{journal} \n \n {entry}";
        }
        return journal;
    }

    public List<string> ReturnEntries()
    {
        return _entries;
    }
}