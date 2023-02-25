using System;
class Circle : Shapes
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius = _radius * Math.PI;
    }
    // public int GetArea(string color, double radius)
    // {
    //     //Area of circle  = pi * r * r   //where r is the radius of circle
    //     Console.Write("Enter Radius: ");
    //     double radius = Convert.ToDouble(Console.ReadLine());
    //     double area = Math.PI * radius * radius;
    //     Console.WriteLine("Area of circle is: " + area);
    // }
}