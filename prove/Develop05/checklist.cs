using System;
public class Checklist : Goal
{
    private int _timesCompleted;
    private int _targetCompleted;
    // bonus
    private int _bonus;

    public Checklist(string name, string description, int points, int target, int bonus, int frequency) : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCompleted = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {

        Console.WriteLine($"How many timed did you complete {_name}?");
        int completed = int.Parse(Console.ReadLine());
        _timesCompleted += completed;

        // if they met the target amount award bonus other wise award points based off times completed
        if (_timesCompleted >= _targetCompleted)
        {
            // add points to total points
            _pointsAwarded += _bonus;
            Console.WriteLine($"Congratulations! You completed {_name} and earned {_pointsAwarded * _timesCompleted + _bonus} points.");
            _completed = true;
        }
        else
        {
            Console.WriteLine($"You completed {_name} {_timesCompleted} times and earned {_pointsAwarded * _timesCompleted} points.");

        }

        return _pointsAwarded * completed;
    }

    public override string GetTimesCompleted()
    {
        return $" -- Completed {_timesCompleted} / target ";
    }

}

