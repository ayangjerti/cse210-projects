// Running.cs
using System;

public class Running : Activity
{

    private double _distance;

    public Running(string date, double duration, double distance) : base(date, duration)
    {
        _activityType = "Running";
        _distance = distance;
    }
    

     public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return _distance/ _duration;
    }

    public override double Pace()
    {
        return _duration/ _distance;
    }
    




}