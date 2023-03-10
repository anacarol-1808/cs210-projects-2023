using System;

class Program
{
    static void Main(string[] args)
    {
        // create an instance for 1/1 (using the first constructor)
        var fraction = new Fraction();
        fraction.GetFraction();

        // for 6/1 (using the second constructor)
        var fraction1 = new Fraction(6);
        fraction1.GetFraction();

        // for 6/7 (using the third constructor)
        var fraction2 = new Fraction(6 , 7);
        fraction2.GetFraction();

        fraction.SetTop(8);
        Console.WriteLine(fraction.GetTop());

        fraction.SetBottom(10);
        fraction.GetFraction();
        Console.WriteLine(fraction.GetBottom());

        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}