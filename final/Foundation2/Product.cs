// Product.cs

using System.Security.Cryptography.X509Certificates;

public class Product
{
    private string _name;
    private int _productId;
    private double _pricePerUnit;
    private int _qty;

    public Product(string name, double price, int productId, int qty)
    {
        _name = name;
        _productId = productId;
        _qty = qty;
        _pricePerUnit = price;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }

    // public int GetQty()
    // {
    //     return _qty;
    // }

    public double TotalCost()
    {
        return _pricePerUnit * _qty;
    }





}