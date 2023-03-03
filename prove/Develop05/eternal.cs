using System;
public class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points)
    {

    }
    public override int RecordEvent()
    {
        // Ask if the user completed the goal
        // Award points
        // Check if they met milestone
        // display message
        return _pointsAwarded;
    }

}