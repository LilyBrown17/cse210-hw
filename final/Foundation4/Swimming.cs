using System;

class Swimming: Activity
{
    private double _laps;

    public Swimming(double laps, int time, string date)
    {
        _title = "Swimming";
        _time = time;
        _date = date;
        _laps = laps;
        GetDistance();
        GetSpeed();
        GetPace();
    }

    public override void GetDistance()
    {
        _distance =  _laps * 50  / 1000;
    }

    public override void GetSpeed()
    {
        _speed =  _distance / _time  * 60;
    }

    public override void GetPace()
    {
        _pace = _time / _distance;
    }
}