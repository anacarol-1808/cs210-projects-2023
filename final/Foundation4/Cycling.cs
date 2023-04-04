public class Cycling : Activity
{
    //attributes
    private double _speed;
    //constrcutors
    public Cycling()
    {

    }

    public Cycling(string date, double minutes, string type, double speed) : base (date, minutes, type)
    {
        _speed = speed;
    }
    //methods
    public override double GetDistance()
    {
        return (_speed * _minutes) / 60;
    }
}