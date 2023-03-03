using System;

public class Filehandling
{
    private string _fileName;
    public Filehandling(string fileName)
    {
        _fileName = fileName;
    }

    public List<Goal> LoadFile()
    {

        List<Goal> loadedGoals = new List<Goal>();
        string[] goalStrings = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in goalStrings)
        {
            loadedGoals.Add(GetStringData(line));
        }
        return loadedGoals;


    }
    public void SaveGoals(List<Goal> userGoals)
    {
        foreach
    }
    public string GoaltoString(Goal goal)
    {

    }
    public Goal GetStringData(string goal)
    {
        string[] parts = goal.Split(":");
        string goalType = parts[0];
        parts = parts[1].Split(",");
        string name = parts[0];
        string description = parts[1];
        string points = parts[2];
        if (goalType == "SimpleGoal")
        {
            string IsComplete = parts[3];
            Simple simple = new Simple(name, description, int.Parse(points), IsComplete);
            return simple;

        }
        else if (goalType == "EternalGoal")
        {
            Eternal eternal = new Eternal(name, description, int.Parse(points));
            return eternal;
        }

        else
        {
            string bonus = parts[3];
            string completed = parts[4];
            string frequency = parts[5];
            Checklist checklist = new Checklist(name, description, int.Parse(points), int.Parse(bonus), int.Parse(completed), int.Parse(frequency));
            return checklist;
        }

    }

}