using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Square square = new Square("red", 2);
        Rectangle rectangle = new Rectangle("blue", 4, 2);
        Circle circle = new Circle("yellow", 2);

        List<Shape> shapeList = new List<Shape> {square, rectangle, circle};
        string color;
        double area;


        foreach (var item in shapeList)
        {
            color = item.GetColor();
            area = item.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.\r\n");
        }
        
    }
}