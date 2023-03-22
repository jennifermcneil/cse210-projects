using System;
public class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointsAwarded;


    public Goal()
    {
        Console.Write("What is the name of your Goal?\n");
        _name = Console.ReadLine();
        Console.Write("Write a short description of your goal.\n");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?\n");
        _pointsAwarded = int.Parse(Console.ReadLine());
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _pointsAwarded = points;
    }

    public virtual int RecordEvent()
    {
        return _pointsAwarded;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual char GetIsComplete()
    {
        return ' ';
    }

    public virtual int GetBonus()
    {
        return 0;

    }
    public virtual int GetTargetCompleted()
    {
        return 0;
    }

    public virtual int GetTimesCompleted()
    {
        return 0;
    }

    public virtual void SerializeGoal(string filename)
    {

    }

    public virtual void GetGoalInfo(int i)
    {

    }
}