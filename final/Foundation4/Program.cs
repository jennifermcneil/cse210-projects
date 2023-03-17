using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new CyclingActivity(new DateTime(2022, 11, 3), 60, 15.0));
        activities.Add(new SwimmingActivity(new DateTime(2022, 11, 3), 45, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}