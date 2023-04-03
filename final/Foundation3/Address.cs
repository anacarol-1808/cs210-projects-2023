public class Address
{
    //attributes
    private string _street;
    private string _city;
    private string _state;
    private string _building;

    //constructors
    public Address(string street, string city, string state, string building)
    {
        _street = street;
        _city = city;
        _state = state;
        _building = building;
    }

    //methods
    public string DisplayAddress()
    {
        return $"{_street}, {_city} - {_state} ({_building})";
    }
}

    