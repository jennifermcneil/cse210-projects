using System;
using System.Collections.Generic;

public abstract class Activity
{
    protected DateTime _date;
    protected int _durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_durationInMinutes} min)";
    }
}

