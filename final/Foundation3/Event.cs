// Event.cs
using System;

public class Event
{

    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

public Event(string title, string desc, string date, string time, Address address)
{
    _title = title;
    _description = desc; 
    _address = address;
    _time = time;
    _date = date;
  
}

public virtual string GetStandardDetails()
{
    return $"Event title: {_title} \nDescription: {_description} \nDate of event: {_date} \nTime: {_time} \nAddress:\n{_address.DisplayAddress()} ";
}

public virtual string GetFullDetails()
{
    return $"{_title} \n{_description} \n{_date} \n{_time} \n{_address.DisplayAddress()} ";
    // yet to add the remaining attributes like type of event and specifiic info
}

public virtual string ShortDescription()
{
    string _shortDescription = $"Type of event: ------\nEvent title: {_title} \nDate of event: {_date}";
    return _shortDescription;
}












}