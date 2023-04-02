public class Order
{
    //attibutes
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    private double _totalCost;
    private string _packingLabel;
    private string _shippingLabel;
    private double _shippingCost;

    //constrcutors
    public Order()
    {
        
    }

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    //methods
    public double ComputeTotalCost()
    {
        foreach (Product item in _products)
        {
            _totalCost += item.GetPriceTimesQuantity();
        }

        return _totalCost;
    }
    public double ComputeTotalCostWithShippingCost()
    {
        foreach (Product item in _products)
        {
            _totalCost += item.GetPriceTimesQuantity();
        }

        if (_customer.LivesInUSA() == true)
        {
            _shippingCost = 5;
        }
        else if (_customer.LivesInUSA() == false)
        {
            _shippingCost = 35;
        }

        return _totalCost + _shippingCost;
    }

    public void GetPackingLabel()
    {
        foreach (Product item in _products)
        {
            Console.WriteLine($"{item.GetName()} - {item.GetProductID()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("Shipping to:");
        Console.WriteLine($"{_customer.GetCustomerName()}");
        Console.WriteLine($"{_customer.GetCustomerAddress().GetFullAddress()}\r\n");
    }
}