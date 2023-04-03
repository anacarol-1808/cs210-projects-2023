public class Lecture : Event
{
    // Lectures, which have a speaker and have a limited capacity.

    //attributes
    private string _speaker;
    private int _capacity;

    //constructors
    public Lecture()
    {
        
    }

    public Lecture(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base (title, description, date, time, address, type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
        _speaker = speaker;
        _capacity = capacity;
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
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Limited to {_capacity} people");
        Console.WriteLine($"When: {_date} - {_time}");
        Console.WriteLine($"Where: {_address.DisplayAddress()}");
    }
    
}