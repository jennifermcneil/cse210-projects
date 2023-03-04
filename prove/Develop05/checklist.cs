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

        _timesCompleted = timesCompleted;
        _bonus = bonus;

    }

    public override int RecordEvent()
    {

        Console.WriteLine($"How many times did you complete {_name}?");
        int completed = int.Parse(Console.ReadLine());
        _timesCompleted += completed;

        // if they met the target amount award bonus other wise award points based off times completed
        if (_timesCompleted >= _targetCompleted)
        {
            // add points to total points
            _pointsAwarded += _bonus;
            Console.WriteLine($"Congratulations! You completed {_name} and earned {_pointsAwarded * _timesCompleted} points.");
            _completed = true;
        }
        else
        {
            Console.WriteLine($"You completed {_name} {_timesCompleted} times and earned {_pointsAwarded * _timesCompleted} points.");

        }

        return _pointsAwarded * completed;
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

