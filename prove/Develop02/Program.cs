using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int _runProgram = 0;
        Journal _newJournal = new Journal();
        Entry _addedEntry = new Entry();

        string _currentJournal = "";

        Console.WriteLine("Welcome to the Journal!");

        while (_runProgram == 0)
        {
            Console.WriteLine("\n Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            string _selection = Console.ReadLine();

            if (_selection == "1")
            {
                string _myEntry = _addedEntry.Write();
                _newJournal.AddEntry(_myEntry);
            }
            else if (_selection == "2")
            {
                DisplayJournal(_currentJournal, _newJournal);
            }
            else if (_selection == "3")
            {
                _newJournal = new Journal();
                Console.WriteLine("What is the name of the file?");
                string _filename = Console.ReadLine();
                _currentJournal = Load(_filename);
            }
            else if (_selection == "4")
            {
                _newJournal.Save();
            }
            else if (_selection == "5")
            {
                _runProgram = 1;
            }
            else
            {
                Console.WriteLine("I'm sorry, that's not a valid input.");
            }

        }  
    }


    public static string Load(string _filename)
    {
        string[] _lines = System.IO.File.ReadAllLines(_filename);
        string _returnJournal = "";

        foreach (string _line in _lines)
        {
            _returnJournal = $"{_returnJournal}\n{_line}";
        }
        return _returnJournal;
    }

    public static void DisplayJournal(string _myJournal, Journal _journal)
    {
        string _showJournal = _journal.ToNewString(_myJournal);
        Console.WriteLine(_showJournal);
    }

}