public class Activity
{
    //attributes
    private string _date;
    protected double _minutes;
    private string _type;
    //constrcutors
    public Activity()
    {

    }

    public Activity(string date, double minutes, string type)
    {
        _date = date;
        _minutes = minutes;
        _type = type;
    }
    //methods

    public virtual double GetDistance() // The distance
    {
        return -1;
    }
    public double GetSpeed() // The speed (miles per hour or kilometers per hour)
    {
        return ((GetDistance() / _minutes) * 60);
    }
    public double GetPace() // The pace (minutes per mile or minutes per kilometer)
    {
        return (_minutes / GetDistance());
    }

    // Summary format: 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_minutes} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }

}