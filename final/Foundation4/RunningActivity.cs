class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _durationInMinutes * 60;
    }

    public override double GetPace()
    {
        return _durationInMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance {_distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}

