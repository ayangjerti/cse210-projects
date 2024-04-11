// Activity.cs
using System;
using System.Reflection.Metadata;

public abstract class Activity
{
    protected string _date;
    protected double _duration;
    protected  string _activityType;



    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }




    public virtual void SetDate( string date)
    {
        _date = date;
    }

    public virtual void SetDuration( double duration)
    {
        _duration = duration;
    }





    public double GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        return _date;
    }





    public abstract double Speed();
   
    public abstract double Distance();
   

    public abstract double Pace();
   

    public virtual string GetSummary()
    {
        string summary = $"{_date} {_activityType} ({_duration} min) - Distance {Distance().ToString("N2")} miles, Speed {Speed().ToString("N2")} mph. \nPace: {Pace().ToString("N2")} min per mile";
        
        return summary;
    }

}

