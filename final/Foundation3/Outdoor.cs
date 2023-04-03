public class Outdoor : Event
{
    // Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.

    //attributes
    private string _weather;

    //constructors
    public Outdoor()
    {
        
    }

    public Outdoor(string title, string description, string date, string time, Address address, string type, string weather) : base (title, description, date, time, address, type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
        _weather = weather;
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
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine($"When: {_date} - {_time}");
        Console.WriteLine($"Where: {_address.DisplayAddress()}");
    }

}