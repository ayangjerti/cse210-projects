// Address.cs
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    private bool IsUSA;

    





    public Address(string adres, string city, string province, string country)
    {
        _streetAddress = adres;
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

    public bool  IFusa()
    {
        if (_country == "USA")
        {
            IsUSA = true;;
        }
        else {
            IsUSA = false;
        }
    return IsUSA;
    }


}