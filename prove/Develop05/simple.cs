using System;
public class Simple : Goal
{
    public Simple(string name, string description, int points, string IsComplete) : base(name, description, points)
    {

    }

    public override int RecordEvent()
    {
        // add points to total points
        totalPoints += _pointsAwarded;
        // check for bonus requirments
        if (totalPoints >= 100)
        {
            totalPoints += 50; //Award bonus points
        }
        //      if met award bonus points
        // set to complete
        IsComplete = true;
        // display message
        Console.WriteLine($"Goal '{goalName}' is complete! You earned {totalPoints} points.");

        TotalPointsEarned = totalPoints;
    }

}