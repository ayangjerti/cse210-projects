// Receptions.cs
using System;

public class Receptions : Event
{
    protected string _rsvpEmail; 
    protected string _eventType = "Reception";


   public Receptions(string title, string desc, string date, string time, Address address, string rsvpEmail) :base(title, desc, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    
     //didnt bother adding email there

    public string getEmail()
    {
        return _rsvpEmail;
    }

 

    // public override string GetStandardDetails()
    // {
    //     return $"{_title} \n{_description} \n{_date} \n{_time} \n{_address.DisplayAddress()} ";
    // }


    public override string GetFullDetails()
    {
        // return $"{_title} \n{_description} \n{_date} \n{_time} \n{_address.DisplayAddress()} \nrRSVP: {_rsvpEmail}";
        return $"{GetStandardDetails()} \nRSVP: {_rsvpEmail} ";

    }

    public override string ShortDescription()
    {
    string _shortDescription = $"Type of event: {_eventType}\nEvent title: {_title} \nDate of event: {_date}";
    return _shortDescription;
    }


















}