using System;

public class Filehandling
{
    private string _fileName; public Filehandling(string filename) { _fileName = filename; }

    public List<Goal> LoadFile()
    {
        List<Goal> loadedGoals = new List<Goal>();
        string[] goalStrings = System.IO.File.ReadAllLines(_fileName);
        int index = 0;
        foreach (string line in goalStrings)
        {
            if (index != 0)
            {
                loadedGoals.Add(GetStringData(line));
            }

        }
        return loadedGoals;
    }
    //0
    // Simple:Give a talk,Speak in Sacrament meeting when asked,100,false
    // Eternal:Study the scriptures,Study for at least 10 minutes,50
    // Checklist:Attend the temple,Attend and perform any ordinance,50,500,3,0
    public void SaveGoals(List<Goal> userGoals, int totalPoints)
    {
        List<string> goalStrings = new List<string>();
        int index = 0;
        foreach (Goal goal in userGoals)
        {
            if (index == 0)
            {
                goalStrings.Add($"{totalPoints}");
            }
            string type = goal.GetType().ToString();
            List<string> goalInfo = goal.GetgoalInfo();

            if (type == "Simple")
            {
                goalStrings.Add($"{type}:{goalInfo[0]},{goalInfo[1]},{goalInfo[2]},{goal.IsComplete()}");
            }
            else if (type == "Eternal")
            {
                goalStrings.Add($"{type}:{goalInfo[0]},{goalInfo[1]},{goalInfo[2]},{goal.GetBonus()},{goal.GetTargetCompleted()},{goal.GetTimesCompleted()}");
            }
            else
            {
                goalStrings.Add($"{type}:{goalInfo[0]},{goalInfo[1]},{goalInfo[2]},{goal.GetBonus()},{goal.GetTargetCompleted()},{goal.GetTimesCompleted()},{goal.IsComplete()}");
            }
            index++;
        }
        System.IO.File.WriteAllLines(_fileName, goalStrings);
    }

    public Goal GetStringData(string goal)
    {
        string[] parts = goal.Split(":");
        string goalType = parts[0];

        parts = parts[1].Split(",");
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        int bonus = int.Parse(parts[3]);
        int target = int.Parse(parts[4]);
        int timesCompleted = int.Parse(parts[5]);
        bool isComplete = bool.Parse(parts[6]);

        if (goalType == "Simple")
        {
            string IsComplete = parts[3];
            Simple simple = new Simple(name, description, points, isComplete);
            return simple;

        }
        else if (goalType == "EternalGoal")
        {
            Eternal eternal = new Eternal(name, description, points, bonus, target, timesCompleted, isComplete);
            return eternal;
        }

        else
        {
            Checklist checklist = new Checklist(name, description, points, bonus, target, timesCompleted, isComplete);
            return checklist;
        }

    }

}