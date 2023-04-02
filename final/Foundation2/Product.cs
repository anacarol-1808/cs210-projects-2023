public class Product
{
    //attibutes
    private string _name;
    private string _productID;
    private double _price;
    private int _quanitity = 1;

    //constrcutors
    public Product()
    {

    }

    public Product(string name, string productID, double price, int quanitity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quanitity = quanitity;
    }

    //methods

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quanitity;
    }

    public double GetPriceTimesQuantity()
    {
        return _price * _quanitity;
    }
}