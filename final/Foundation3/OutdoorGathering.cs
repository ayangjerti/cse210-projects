// OutdoorGathering.cs
using System;

public class OutdoorGathering : Event
{
    private string _weatherStatement;

    private string _eventType = "OutdoorGathering";


    public OutdoorGathering(string title, string desc, string date, string time, Address address, string weatherStatement) :base(title, desc, date, time, address)
    {
        _weatherStatement = weatherStatement;
    } //might have to remove the weatherStatement from heere since i've declareda setter


    // public static void SetweatherStatement()
    // {
    //     _weatherStatement = Console.ReadLine();
    // }

    public string GetweatherStatement ()
    {
        return _weatherStatement;
    } 

    // public override string GetStandardDetails()
    // {
    //     return $"{_title} \n{_description} \n{_date} \n{_time} \n{_address.DisplayAddress()} ";
    // }


    public override string GetFullDetails()
    {
        // return $"{_title} \n{_description} \n{_date} \n{_time} \nCapacity: Unlimited \n{_address.DisplayAddress()} \\nWeather statement: {_weatherStatement} ";
        return $"{GetStandardDetails()} \nWeather statement: {_weatherStatement} ";

    }

    
    public override string ShortDescription()
{
    string _shortDescription = $"Type of event: {_eventType}\nEvent title: {_title} \nDate of event: {_date}";
    return _shortDescription;
}






















}