using System;
class Rectangle : Shapes
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    public override double GetArea()
    {
        return _length * _width;
    }
    //     ////Rectangle Area: A (area) = L (length) x W (width)
    //     Console.Write("Please write the length of your rectangle: ");
    //     decimal length = decimal.Parse(Console.ReadLine());
    //     Console.Write("Please write the width of your rectangle: ");
    //     decimal width = decimal.Parse(Console.ReadLine());
    //     decimal area = length * width;
    //     Console.WriteLine("The area of your rectangle is: {0}", area);

    // }
}