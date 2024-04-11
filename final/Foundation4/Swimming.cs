// Swimming.cs
using System;

public class Swimming : Activity
{
    private int _numOfLaps;



    public Swimming(string date, double duration, int numOflaps) : base(date, duration)
    {
        _activityType = "Swimming";
        _numOfLaps = numOflaps;
    }


    public int GetLaps()
    {
        return _numOfLaps; 
    }


    public override double Distance()
    {
               
        const double metersPerLap = 50;
        const double metersToMilesConversion = 0.000621371; 

        double totalMeters = _numOfLaps * metersPerLap;
        return totalMeters * metersToMilesConversion;
    }

    public override double Speed()
    {
        return Distance() / _duration * 60;
    }

    public override double Pace()
    {
        return _duration/ Distance();
    }




}
