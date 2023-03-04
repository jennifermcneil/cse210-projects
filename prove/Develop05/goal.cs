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

    public char GetIsComplete()
    {
        if (_completed)
            return 'X';
        else
            return ' ';
    }
    public virtual int GetBonus()
    {
        return 0;

    }
    public virtual int GetTargetCompleted()
    {
        return 0;
    }

    public virtual int GetTimesCompleted()
    {
        return 0;
    }

    public List<string> GetgoalInfo()
    {
        return new List<string>() { _name, _description, _pointsAwarded.ToString() };
    }
}