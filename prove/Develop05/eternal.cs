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
    public Eternal(string name, string description, int points, int bonus, int target, int timesCompleted, bool isComplete) : base(name, description, points)
    {

        _timesCompleted = timesCompleted;
        _bonus = bonus;

    }
    public override int RecordEvent()
    {
        Console.WriteLine($"How many timed did you complete {_name}?");
        int completed = int.Parse(Console.ReadLine());
        _timesCompleted += completed;

        // if they met the target amount award bonus other wise award points based off times completed
        if (_timesCompleted % _targetCompleted == 0)
        {
            // add points to total points
            _pointsAwarded += _bonus;
            Console.WriteLine($"Congratulations! You earned {_pointsAwarded * _timesCompleted + _bonus} points for completing {_name} {_targetCompleted} times.");
        }
        else
        {
            Console.WriteLine($"You completed {_name} {completed} times and earned {_pointsAwarded * completed} points.");

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