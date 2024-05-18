using System;

class Prompt
{
    public string Choose()
    {
        Random _randomGenerator = new Random();
        int _choice = _randomGenerator.Next(0, 7);

        List<string> _prompts = 
        ["Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the hardest thing I did today?",
        "What did I learn that I can use for tomorrow?",
        "How happy am I with how today went?"];

        string _promptChoice = _prompts[_choice];
        return _promptChoice;
    }
}