using System;
public class Checklist : Goal
{
    private int _timesCompleted;
    private int _targetCompleted;
    // bonus
    private int _bonus;
    public Checklist(string name, string description, int points, int target, int bonus, int timesCompleted) : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCompleted = target;
        _bonus = bonus;
    }
    public Checklist(string name, string description, int points, int bonus, int target, int timesCompleted, bool isComplete) : base(name, description, points)
    {

        _timesCompleted = target;
        _timesCompleted = timesCompleted;
        _bonus = bonus;

    }

    public override int RecordEvent()
    {
        int pointsAwarded = _pointsAwarded;
        Console.WriteLine($"How many times did you complete {_name}?");
        int completed = int.Parse(Console.ReadLine());
        _timesCompleted += completed;

        // if they met the target amount award bonus other wise award points based off times completed
        if (_timesCompleted >= _targetCompleted)
        {
            // add points to total points
            pointsAwarded = (pointsAwarded * _timesCompleted) + _bonus;
            Console.WriteLine($"Congratulations! You have completed {_name} and earned {pointsAwarded} points.");
            _completed = true;
        }
        else
        {
            Console.WriteLine($"You have completed {_name} {_timesCompleted} times total and earned {pointsAwarded * _timesCompleted} points.");
            pointsAwarded = pointsAwarded * completed;

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

