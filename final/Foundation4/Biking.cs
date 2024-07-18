using System;

class Biking : Activity
{
    public Biking(double speed, int time, string date)
    {
        _title = "Biking";
        _speed = speed;
        _time = time;
        _date = date;
        GetDistance();
        GetPace();
    }

    public override void GetDistance()
    {
        _distance =  _speed * _time  / 60;
    }

    public override void GetSpeed()
    {
        throw new NotImplementedException();
    }

    public override void GetPace()
    {
        _pace = 60 / _speed;
    }
}