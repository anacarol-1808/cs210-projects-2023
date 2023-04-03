public class Reception : Event
{
    // Receptions, which require people to RSVP, or register, beforehand.

    //attributes
    private string _registrationEmail;

    //constructors
    public Reception()
    {
        
    }

    public Reception(string title, string description, string date, string time, Address address, string type, string registrationEmail) : base (title, description, date, time, address, type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
        _registrationEmail = registrationEmail;
    }

    //methods

    // Full details - Lists all of the above, plus type of event and information specific to that event type. 
    //For lectures, this includes the speaker name and capacity. 
    //For receptions this includes an email for RSVP. 
    //For outdoor gatherings, this includes a statement of the weather.
    public override void DisplayFullDetails()
    {
        Console.WriteLine($"Event: {_type} - {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"RSVP: {_registrationEmail}");
        Console.WriteLine($"When: {_date} - {_time}");
        Console.WriteLine($"Where: {_address.DisplayAddress()}");
    }

}