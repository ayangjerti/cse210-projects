// Customer.cs

public class Customer
{
    private string _name;

    private Address _address;



    public Customer(string name, Address address)
    {
        _address = address;
        _name = name;
    }


    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.DisplayAddress();
    }

    public bool IFusa()
    {
        return _address.IFusa();

    }


}