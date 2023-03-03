using System;
public class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointsAwarded;
    protected bool _completed;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _pointsAwarded = points;
        _completed = false;
    }

    public virtual int RecordEvent()
    {
        return _pointsAwarded;
    }

    public bool IsComplete()
    {
        return _completed;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public char GetIsComplete()
    {
        if (_completed)
            return 'X';
        else
            return ' ';
    }

    public virtual string GetTimesCompleted() { return null; }
}