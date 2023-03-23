public class Rectangle : Shape 
{
    protected double _lenght;
    protected double _width;

    public Rectangle(string color, double lenght, double width) : base (color)
    {
        _lenght = lenght;
        _width = width;
    }

    public override double GetArea()
    {
        return _lenght * _width;
    }

}