// Lectures.cs
using System;
using System.Dynamic;

public class Lectures : Event
{

    private string _eventType = "Lecture";
    private string _speaker;
    private string _capacity; // limited. but how????

   public Lectures(string title, string desc, string speaker, string date, string capacity, string time, Address address) :base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        //might have to remove speaker and capacity from heere since i've declareda setter
    }
    


    public void SetCapacity()
    {
        _capacity = Console.ReadLine();
    }

    public void SetSpeaker()
    {
        _speaker = Console.ReadLine();
    }




    public string GetEventtype()
    {
        return _eventType;
    }
    

    public string GetSpeaker()
    {
        return _speaker;
    }

    public string GetCapacity()
    {
        return _capacity;
    }

    public override string GetFullDetails()
    {
        // return $"{_title} \n{_description} \n{_speaker} \n{_date} \n{_time} \n{_capacity} \n{_address.DisplayAddress()} ";
        return $"{GetStandardDetails()} \n{_capacity} ";

    }

    
    public override string ShortDescription()
    {
    string _shortDescription = $"Type of event: {_eventType}\nEvent title: {_title} \nDate of event: {_date}";
    return _shortDescription;
    }
































}