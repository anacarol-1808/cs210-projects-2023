public class Customer
{
    //attibutes
    private string _customerName;
    private Address _address;

    Address address = new Address();

    //constrcutors
    public Customer()
    {
        
    }

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
        
    }

    //methods

    public string GetCustomerName()
    {
        return _customerName;
    }

    public Address GetCustomerAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }
}