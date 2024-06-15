using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;

class ListingActivity : Activity
{
    private static List<string> _userList = [""];
    private static List<string> _listPrompts =
    [
        "Who are people that you appreciate?", 
		"What are personal strengths of yours?", 
		"Who are people that you have helped this week?", 
		"When have you felt the Holy Ghost this month?", 
		"Who are some of your personal heroes?"
    ];

    public void InteractListing()
    {
        InteractPrologue();

        Random _randomGenerator = new Random();
        int _promptSelect = _randomGenerator.Next(0, _listPrompts.Count() - 1);
        Console.WriteLine(_listPrompts[_promptSelect]);

        Timer.CounterAnimation();

        Timer.Set(1000 * GetDuration());

        while(!Timer.IsExpired())
        {
            string _userAdd = Console.ReadLine();
            _userList.Add(_userAdd);
        }

         Console.WriteLine($"\nYou listed {_userList.Count()} things.");

        InteractEpilogue();
    }

    public ListingActivity(string title, string desc) : base(title, desc)
    {
        _title = title;
        _desc = desc;
    }
}