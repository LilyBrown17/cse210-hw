using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;

class ReflectingActivity : Activity
{
    private static List<string> _reflectingPrompts = 
    [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    private static List<string> _questions = 
    [
        "Why was this experience meaningful to you?", 
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?", 
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?", 
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"
    ];

    public void InteractReflecting()
    {
        InteractPrologue();

        Random _randomGenerator = new Random();
        int _promptSelect = _randomGenerator.Next(0, _reflectingPrompts.Count() - 1);
        Console.WriteLine(_reflectingPrompts[_promptSelect]);

        Timer.CounterAnimation();

        Timer.Set(1000 * GetDuration());

        while(!Timer.IsExpired())
        {
            int _questionSelect = _randomGenerator.Next(0, _questions.Count() - 1);
            Console.Write($"\n{_questions[_questionSelect]}");
            Timer.CounterAnimation();
        }

        InteractEpilogue();
    }

    public ReflectingActivity(string title, string desc) : base(title, desc)
    {
        _title = title;
        _desc = desc;
    }
}