using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int _run = 0;
        Scripture _defaultScripture = new Scripture("Adam fell that men might be; and men are, that they might have joy.");
        Reference _defaultReference = new Reference("2 Nephi", "2", "25");
        string _fullReference = _defaultReference.ReturnReference();
        int _countMain = _defaultScripture.GetWordCount();
        int _countRemoved = 0;

        _defaultScripture.DisplayScripture(_defaultScripture.ReturnScriptureList(0), _fullReference);

        while (_run == 0)
        {
            Console.WriteLine($"\nPress 'Enter' to continue, Type 'Quit' to quit.");

            string _check = Console.ReadLine();

            if (_check == "")
            {
                _defaultScripture.CheckAccuracy(_countMain, _fullReference);
            }
            else if (_check == "quit" || _check == "Quit")
            {
                _run = 1;
            }
            else
            {
                Console.WriteLine("Invalid Option. Please try again.");
            }    

            List<string> _defaultList = _defaultScripture.ReturnScriptureList(1);

            foreach(string _defaultWord in _defaultList)
            {
                if (_defaultWord == "_")
                {
                    _countRemoved++;
                }
            }

            if (_countMain == _countRemoved)
            {
                _run = 1;
            }
        }
    }
}