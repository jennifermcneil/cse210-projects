using System;
public class Eternal : Goal
{
    private int _timesCompleted;
    private int _targetCompleted;
    private int _bonus;
    public Eternal(string name, string description, int points, int bonus, int targetCompleted) : base(name, description, points)
    {
        _targetCompleted = targetCompleted;
        _timesCompleted = 0;
        _bonus = bonus;

    }
    public Eternal(string name, string description, int points, int bonus, int target, int timesCompleted) : base(name, description, points)
    {

        _timesCompleted = timesCompleted;
        _targetCompleted = target;
        _bonus = bonus;

    }
    public override int RecordEvent()
    {
        int pointsAwarded = _pointsAwarded;
        Console.WriteLine($"How many timed did you complete {_name}?");
        int completed = int.Parse(Console.ReadLine());
        _timesCompleted += completed;

        // if they met the target amount award bonus other wise award points based off times completed
        if (_timesCompleted >= _targetCompleted)
        {
            // add points to total points
            pointsAwarded = (pointsAwarded * _timesCompleted) + _bonus;
            Console.WriteLine($"Congratulations! You have completed {_name} {_timesCompleted} times total and earned {pointsAwarded} points total.");
        }
        else
        {
            pointsAwarded = pointsAwarded * completed;
            Console.WriteLine($"You have completed {_name} and earned {pointsAwarded} points.");


        }
        return pointsAwarded;
    }
    public override int GetBonus()
    {
        return _bonus;

    }
    public override int GetTargetCompleted()
    {
        return _targetCompleted;
    }

    public override int GetTimesCompleted()
    {
        return _timesCompleted;
    }

}