using System;
using System.IO;

class Scripture
{
    private string _scripture;
    private string _scriptureBase;
    private List<string> _scriptureText = new List<string>();
    private List<string> _scriptureNew = new List<string>();
    private List<string> _removedWords = new List<string>();
    private List<int> _wordPosition = new List<int>();


    public Scripture(string _newScripture)
    {
        _scriptureBase = _newScripture;
        _scripture = _newScripture;
        _scriptureText = _scriptureBase.Split(" ").ToList();
    }

    public List<string> ReturnScriptureList(int _input)
    {
        if (_input == 1)
        {
            return _scriptureNew;
        }
        else
        {
            return _scriptureText;
        }
    }

    public string ReturnScripture(List<string> _scriptureList)
    {
        _scripture = "";

        foreach(string _scriptureWord in _scriptureList)
        {
            _scripture = $"{_scripture} {_scriptureWord}";
        }
        return _scripture;
    }

    public void DisplayScripture(List<string> _scriptureList, string _reference)
    {
        ReturnScripture(_scriptureList);
        Console.WriteLine($"{_reference}\n{_scripture}");
    }

    public int GetWordCount()
    {
        int _wordCount = 0;

        foreach(string _scriptureWord in _scriptureText)
        {
            _wordCount++;
        }

        return _wordCount;
    }

    public void ChooseWord(int _wordCount)
    {
        Random _randomGenerator = new Random();
        int _choice = _randomGenerator.Next(0, _wordCount - 1);

        _wordPosition.Add(_choice);
    }

    public void RemoveWords(int _wordCount)
    {
        _removedWords.Clear();

        _scriptureNew.Clear();

        ChooseWord(_wordCount);

        int _position = 0;

        foreach(string _scriptureWord in _scriptureText)
        {
            foreach(int _wordChoice in _wordPosition)
            {
                if (_position == _wordChoice)
                {
                    _removedWords.Add(_scriptureWord);
                    _scriptureNew.Add("_");
                }
                else 
                {
                    _scriptureNew.Add(_scriptureWord);
                }
            }
            _position++;
        }

        // for (int _iterate = 0; _iterate < _wordCount; _iterate++)
        // {
        //     string _wordFlag = _scriptureText[_iterate];

        //     foreach(int _wordChoice in _wordPosition)
        //     {
        //         if (_iterate == _wordChoice)
        //         {
        //             _removedWords.Add(_wordFlag);
        //             _scriptureText[_iterate] = "_";
        //         }
        //     }
        // }
    }

    public void CheckAccuracy(int _wordCount, string _reference)
    {
        RemoveWords(_wordCount);

        DisplayScripture(_scriptureNew, _reference);

        int _count = 1;
        int _correct = 1;

        foreach (string _removed in _removedWords)
        {
            string _correctWord = _removed;

            var _punctuation = new string[] { "!", "?", ".", ";", ":" };
            foreach (var _char in _punctuation)
            {
                _correctWord = _correctWord.Replace(_char, string.Empty);
            }

            string _correctCopy = _correctWord;

            if (_count % 10 == 1)
            {
                Console.WriteLine($"What is the {_count}st missing word?");
            }
            else if (_count % 10 == 2)
            {
                Console.WriteLine($"What is the {_count}nd missing word?");
            }
            else if (_count % 10 == 3)
            {
                Console.WriteLine($"What is the {_count}rd missing word?");
            }
            else
            {
                Console.WriteLine($"What is the {_count}th missing word?");
            }

            string _checkedWord = Console.ReadLine();

            _correctWord.ToLower();
            _checkedWord.ToLower();

            if (_correctWord == _checkedWord)
            {
                _correct++;
            }
            else
            {
                Console.WriteLine($"Sorry, the correct word was '{_correctCopy}'.");
            }

            _count++;
        }

        if (_count == _correct)
        {
            Console.WriteLine("You got every word correct.");
        }
        else
        {
            int _wrong = _count - _correct;
            _wrong.ToString();
            Console.WriteLine($"You got {_wrong} words incorrect.");
        }
    }
}