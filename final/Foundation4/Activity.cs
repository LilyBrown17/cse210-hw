using System;

abstract class Activity
{
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected int _time;
    protected string _date;
    protected string _title;

    public abstract void GetDistance();
    public abstract void GetSpeed();
    public abstract void GetPace();

    public string GetSummary()
    {
        string summary = $"{_date} {_title} ({_time} min)- Distance: {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km";
        return summary;
    }
}