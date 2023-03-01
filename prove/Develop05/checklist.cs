using System;
public class Checklist : Goal
{
    private int _timesCompleted;
    private int _targetCompleted;

    public Checklist(string name, string description, int points, int check, int bonus) : base(name, description, points)
    {
        // targetCompleted = *target parameter*
    }

    public override void RecordEvent()
    {

    }

    public override void IsComplete()
    {

    }

    public override string GetTimesCompleted()
    {
        return $" -- Completed {_timesCompleted} / target ";
    }

}

