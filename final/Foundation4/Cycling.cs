// Cycling.cs
using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double duration, double speed) : base(date, duration)
    {
        _activityType = "Cycling";
        _speed = speed;
    }




    public override double Distance()
    {
        return Speed()  * _duration;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return _duration/ Distance();
    }



}