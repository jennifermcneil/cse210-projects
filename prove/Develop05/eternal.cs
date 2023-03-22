using System;
public class Eternal : Goal
{
    private int _timesCompleted;
    private int _targetCompleted;
    private int _bonus;
    public Eternal()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus?\n");
        _targetCompleted = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times?\n");
        _bonus = Convert.ToInt32(Console.ReadLine());

    }
    public Eternal(string name, string description, int points, int timesCompleted, int target, int bonus) : base(name, description, points)
    {

        _timesCompleted = timesCompleted;
        _targetCompleted = target;
        _bonus = bonus;

    }
    public override int RecordEvent()
    {
        int pointsAwarded = _pointsAwarded;
        Console.WriteLine($"How many timed did you accomplish {_name}?");
        int completed = int.Parse(Console.ReadLine());
        _timesCompleted += completed;

        // if they met the target amount award bonus other wise award points based off times completed
        if (_timesCompleted >= _targetCompleted)
        {
            // add points to total points
            pointsAwarded = (pointsAwarded * _timesCompleted) + _bonus;
            Console.WriteLine($"Congratulations! You have accomplished {_name} {_timesCompleted} times total and earned {pointsAwarded} points.");
        }
        else
        {
            pointsAwarded = pointsAwarded * completed;
            Console.WriteLine($"You have accomplished {_name} and earned {pointsAwarded} points.");


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
    public override void GetGoalInfo(int i)
    {

        Console.WriteLine($"{i + 1}) [{GetIsComplete()}] {_name} ({_description} {_pointsAwarded}) - Currently accomplished: {_timesCompleted} times.");
    }

    public override void SerializeGoal(string filename)
    {
        string goal = $"Eternal|{_name}|{_description}|{_pointsAwarded}|{_timesCompleted}|{_targetCompleted}|{_bonus}";
        using (StreamWriter streamWriter = new StreamWriter(filename, true))
        {
            streamWriter.WriteLine(goal);
        }
    }

}