public class Swimming : Activity
{
    //attributes
    private double _laps;
    //constrcutors
    public Swimming()
    {

    }

    public Swimming(string date, double minutes, string type, double laps) : base (date, minutes, type)
    {
        _laps = laps;
    }
    //methods

    public override double GetDistance()
    {
        return (_laps * 50) / 1000; 
    }
}