using System;
public class Checklist : Goal
{
    private int _timesCompleted;
    private int _targetCompleted;
    // bonus
    private int _bonus;

    public Checklist(string name, string description, int points, int target, int bonus, int frequency) : base(name, description, points)
    {
        // targetCompleted = *target parameter*
        _targetCompleted = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {

        Console.WriteLine($"How many timed did you complete {base._name}?");
        int completed = int.Parse(Console.ReadLine());

        // if they met the target amount award bonus other wise award points based off times completed
        if (completed >= _targetCompleted)
        {
            // add points to total points
            _pointsAwarded += _bonus;
            Console.WriteLine($"Congratulations! You completed {base._name} and earned {base._pointsAwarded} points.");
        }
        else
        {
            Console.WriteLine($"You completed {base._name} {completed} times and earned {base._pointsAwarded * completed} points.");

        }



        // // check for milestone requirments
        // CheckMilestone(totalPoints);

        // if (completed >= _targetCompleted)
        // {
        //     SetComplete();
        // }

        // //      if met award bonus points
        // // if they met target
        // //      set to complete
        // // display message
        return _pointsAwarded;
    }

    public override string GetTimesCompleted()
    {
        return $" -- Completed {_timesCompleted} / target ";
    }

}

