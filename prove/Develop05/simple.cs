using System;
public class Simple : Goal
{
    public Simple(string name, string description, int points, string IsComplete) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Goal '{_name}' is complete! You earned {_pointsAwarded} points.");
        _completed = true;
        return _pointsAwarded;
    }

}