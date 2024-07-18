using System;

class Running: Activity
{
    public Running(double distance, int time, string date)
    {
        _title = "Running";
        _distance = distance;
        _time = time;
        _date = date;
        GetSpeed();
        GetPace();
    }

    public override void GetDistance()
    {
        throw new NotImplementedException();
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