using System;
class Shapes
{
    protected string _color;

    public Shapes(string color)
    {
        _color = color;
    }
    // returns the value of what we want it to return. so returns color
    // (access type) (return type) (name)
    public string GetColor()
    {
        return _color;
    }
    // setter takes outside data as a parameter and sets an attribute = to that parameter
    public void SetColor(string color)
    {
        _color = color;

    }

    // public virtual double GetArea()
    // {
    //     double _area = 0;
    //     return _area;
    // }
    public abstract double GetArea();
}
