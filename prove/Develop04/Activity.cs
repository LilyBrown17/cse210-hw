using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;

class Activity
{
    protected string _title;
    protected string _desc;
    protected int _duration;

    public Activity(string title, string desc)
    {
        _title = title;
        _desc = desc;
    }
    
    public int GetDuration()
    {
        return _duration;
    }

    public void InteractPrologue()
    {
        Timer.TimerAnimation(5000);

        Console.Clear();

        Console.WriteLine($"Welcome to the {_title} Activity!");
        Console.WriteLine($"\n{_desc}");
        Console.WriteLine("\nHow long, in seconds, would you like your session to be?");
        string _check = Console.ReadLine();

        if (int.TryParse(_check, out int _result))
        {
            _duration = _result;
        }
        else
        {
            Console.WriteLine("Invalid Input.");
            _duration = 0;
        }

        Timer.TimerAnimation(3000);

        Console.Clear();
    }

    public void InteractEpilogue()
    {
        Console.WriteLine("\n \nWell Done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_title} Activity!");

        Timer.TimerAnimation(5000);
    }
}