public abstract class Event
{
    //attributes
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;


    //constructors
    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type =type;
    }
    public Event()
    {

    }

    //methods

    // Standard details - Lists the title, description, date, time, and address.
    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Event: {_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"When: {_date} - {_time}");
        Console.WriteLine($"Where: {_address.DisplayAddress()}");
    }

    // Full details - Lists all of the above, plus type of event and information specific to that event type. 
    //For lectures, this includes the speaker name and capacity. 
    //For receptions this includes an email for RSVP. 
    //For outdoor gatherings, this includes a statement of the weather.
    public abstract void DisplayFullDetails();

    // Short description - Lists the type of event, title, and the date.
    public void DisplayShortDescription()
    {
        Console.WriteLine($"Event: {_type} - {_title}");
        Console.WriteLine($"When: {_date}");
    }
}