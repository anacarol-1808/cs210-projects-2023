using System;

class Program
{
    static void Main(string[] args)
    {
        // Verify that you can call each constructor and that you can retrieve and display the different representations for a few different fractions. 
        // For example, you could try: 1, 5, 3/4, 1/3

        var fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());

        var fraction1 = new Fraction(5);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        var fraction2 = new Fraction(3, 4);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        var fraction3 = new Fraction(1, 3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());



    }
}