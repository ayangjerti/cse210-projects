// Address.cs
using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

      





    public Address(string streetaddress, string city, string province, string country)
    {
        _streetAddress = streetaddress;
        _city = city;
        _state = province;
        _country = country;
    }


    public string GetCountry()
    {
        return _country;
    }
    
    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }




    public string DisplayAddress()
    {
        return $"{_streetAddress} \n{_city} \n{_state} \n{_country}.";
    }

  

}