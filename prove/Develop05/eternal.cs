using System;
public class Eternal : Goal
{
    private int _timesCompleted;
    private int _bonus;
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override int RecordEvent()
    {
        Console.WriteLine($"How many timed did you complete {_name}?");
        int completed = int.Parse(Console.ReadLine());
        _timesCompleted += completed;

        // if they met the target amount award bonus other wise award points based off times completed
        if (_timesCompleted % 10 == 0)
        {
            // add points to total points
            _pointsAwarded += _bonus;
            Console.WriteLine($"Congratulations! You earned {_pointsAwarded * _timesCompleted + _bonus} points for completing {_name} 10 times.");
        }
        else
        {
            Console.WriteLine($"You completed {_name} {completed} times and earned {_pointsAwarded * completed} points.");

        }
        return _pointsAwarded * completed;
    }

}