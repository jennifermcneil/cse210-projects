using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shapes> shapes = new List<Shapes>();

        Square shape1 = new Square("Red", 3);
        shapes.Add(shape1);

        Rectangle shape2 = new Rectangle("Blue", 4, 5);
        shapes.Add(shape2);

        Circle shape3 = new Circle("Green", 6);
        shapes.Add(shape3);

        foreach (Shapes shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea().ToString("0.00")}.");
        }
    }
}