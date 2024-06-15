using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;

class BreathingActivity : Activity
{
    public void InteractBreathing()
    {
        InteractPrologue();

        Timer.Set(1000 * GetDuration());

        while(!Timer.IsExpired())
        {
            Console.Write("\nBreathe in through your nose . . . ");
            Timer.CounterAnimation();
            Console.Write("\nAnd out through your mouth . . . ");
            Timer.CounterAnimation();
        }

        InteractEpilogue();
    }

    public BreathingActivity(string title, string desc) : base(title, desc)
    {
        _title = title;
        _desc = desc;
    }
}