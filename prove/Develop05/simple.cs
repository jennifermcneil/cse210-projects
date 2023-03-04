using System;
public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points)
    {

    }

    public Simple(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _completed = isComplete;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Goal '{_name}' is complete! You earned {_pointsAwarded} points.");
        _completed = true;
        return _pointsAwarded;
    }

}