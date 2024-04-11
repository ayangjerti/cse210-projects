// Order.cs

public class Order
{
    private List<Product> _productList;
    private Customer _customer;
    private double _shippingCost; //aux????

    public Order(Customer customer){
        _customer = customer;
        _productList = new List<Product>();
    }


    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }
    


    public string PackingLabel()
    {
       string packingLabel = "Packing Label:\n";
        foreach (Product product in _productList)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
 
    }

    public string ShippingLabel()
    {
        // return $"{name}\n{address}";
       return $"Shipping Label:\nCustomer: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
    }

     public double CalculateTotalCost()
    {
        double totalCost = _productList.Sum(product => product.TotalCost());
        return totalCost + (_customer.IFusa() ? 5 : 35); // Shipping cost based on location
    }
   



}