public class Running : Activity
{
    //attributes
    private double _distance; // km
    //constrcutors
    public Running()
    {

    }

    public Running(string date, double minutes, string type, double distance) : base (date, minutes, type)
    {
        _distance = distance;
    }
    //methods
    public override double GetDistance()
    {
        return _distance;
    }
}