public class Address
{
    //attibutes
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _IsInUSA;

    //constrcutors
    public Address()
    {
        
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //methods
    public bool IsInUSA()
    {
        if (_country == "United States" | _country == "USA" | _country == "U.S.A." | _country == "United States Of America" | _country == "United States of America" | _country == "usa" | _country == "us" | _country == "US" | _country == "united states" | _country == "united states of america")
        {
            _IsInUSA = true;
        }
        else
        {
            _IsInUSA = false;
        }

        return _IsInUSA;
    }

    public string GetFullAddress()
    {
        return $"{_street} \r\n{_city}, {_state} \r\n{_country}";
    }
}   