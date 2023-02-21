using System;
using System.Diagnostics;
public class ListingActivity : Activity
{
    private List<string> _promptList;
    private int _counter;

    public ListingActivity(string activity, string description) : base(activity, description)
    {
        _promptList = new List<string>()
            {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
            };
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        // Create an index attribute (variable) to store the random int
        // Call the rnd.Next( _promptList.Count() ) method inside of the rnd object and store it inside of the index attribute
        int index = rnd.Next(_promptList.Count());
        return _promptList[index];
    }

    public void Listing()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"List as many responses you can to the following prompt:");
        Console.WriteLine($"--{prompt}--");
        Console.WriteLine("You may begin in: ");
        base.PausewithTimer(5);

        int duration = _duration;
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds / 1000 < duration)
        {
            CountItems();
        }
    }

    public void DisplayCounter()
    {
        Console.WriteLine($"You listed {_counter} items.\n\n");
    }
    public void CountItems()
    {
        Console.Write(">");
        Console.ReadLine();
        AddItemsListed();
    }

    public void AddItemsListed()
    {
        _counter++;
    }
}