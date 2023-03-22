using System;
public class Simple : Goal
{
    private bool _completed;
    public Simple()
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

    public override void SerializeGoal(string filename)
    {
        string goal = $"Simple|{_name}|{_description}|{_pointsAwarded}|{_completed}";
        using (StreamWriter streamWriter = new StreamWriter(filename, true))
        {
            streamWriter.WriteLine(goal);
        }
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override char GetIsComplete()
    {
        if (_completed)
            return 'X';
        else
            return ' ';
    }

    public override void GetGoalInfo(int i)
    {
        Console.WriteLine($"{i + 1}) [{GetIsComplete()}] {_name} ({_description})");
    }

}