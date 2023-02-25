using System;
class Square : Shapes
{
    private double _side;


    public Square(string color, double side) : base(color)
    {
        _side = side;

    }
    public override double GetArea()
    {
        return _side * _side;
    }
    //public override double GetArea(double side)
    // {
    //     double side, area;
    //     Console.WriteLine("Enter the Length of the Side: ");
    //     side = Convert.ToDouble(Console.ReadLine());
    //     area = side * side;
    //     Console.WriteLine("\nArea of Square: " + area);
    //     Console.ReadKey();}

}