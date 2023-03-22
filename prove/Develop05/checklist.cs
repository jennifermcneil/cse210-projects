using System;
public class Checklist : Goal
{
    private bool _completed;
    private int _timesCompleted;
    private int _targetCompleted;
    private int _bonus;
    public Checklist()
    {
        Console.Write("How many times does this goal need to be accomplished for the goal to be completed?\n");
        _timesCompleted = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bonus for completing the goal?\n");
        _targetCompleted = Convert.ToInt32(Console.ReadLine());
    }
    public Checklist(string name, string description, int points, bool completed, int timesCompleted, int target, int bonus) : base(name, description, points)
    {

        _targetCompleted = target;
        _timesCompleted = timesCompleted;
        _bonus = bonus;
        _completed = completed;

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

    public override bool IsComplete()
    {
        return _completed;
    }

    public override char GetIsComplete()
    {
        if (_completed)
            return 'X';
        else
            return ' ';
    }
    public override void GetGoalInfo(int i)
    {

        Console.WriteLine($"{i + 1}) [{GetIsComplete()}] {_name} ({_description} {_pointsAwarded}) - Currently completed: {_timesCompleted}/{_targetCompleted}");
    }

    public override void SerializeGoal(string filename)
    {
        string goal = $"Checklist|{_name}|{_description}|{_pointsAwarded}|{_completed}|{_timesCompleted}|{_targetCompleted}|{_bonus}";
        using (StreamWriter streamWriter = new StreamWriter(filename, true))
        {
            streamWriter.WriteLine(goal);
        }
    }


}

