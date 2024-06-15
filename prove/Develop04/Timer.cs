using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;

class Timer
{
    private static DateTime _targetTime;
    private static List<string> _animation = ["/", "-", "\\", "|"];
    private static List<string> _counter = ["5", "4", "3", "2", "1"];

    public static void Set(int ms)
    {
        DateTime startTime = DateTime.Now;
        _targetTime = startTime.AddMilliseconds(ms);
    }

    public static bool IsExpired()
    {
        DateTime currentTime = DateTime.Now;
        return currentTime >= _targetTime;
    }

    public static void TimerAnimation(int ms)
    {
        DateTime startTime = DateTime.Now;
        DateTime _animationTime = startTime.AddMilliseconds(ms);
        
        int i = 0;
        while (DateTime.Now < _animationTime)
        {
            string s = _animation[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i++;
            if (i >= _animation.Count)
            {
                i = 0;
            }
        }
    }

    public static void CounterAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime _animationTime = startTime.AddMilliseconds(5000);
        
        int i = 0;
        while (DateTime.Now < _animationTime)
        {
            string s = _counter[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= _counter.Count)
            {
                i = 0;
            }
        }
    }
}