using System;

class Entry
{
    string newEntry;
    
    public string Write()
    {
        Prompt prompt = new Prompt();
        string result = prompt.Choose();
        Console.WriteLine(result);
        string response = Console.ReadLine();
        string date = Date();

        newEntry = $"Date: {date} - Prompt: {result}\n {response}\n";
        return newEntry;
    }

    public string Date()
    {
        DateTime current = DateTime.Now;
        string dateText = current.ToShortDateString();
        return dateText;
    }
}