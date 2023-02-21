public class Activity
{
    protected string _startMessage;
    protected string _endMessage;
    protected string _activity;
    protected string _description;
    protected int _duration;
    private DateTime _startTime;
    protected DateTime _futureTime;

    public Activity(string activity, string description)
    {
        _activity = activity;
        _description = description;
        _startMessage = $"Welcome to the {activity} Activity. {description}";
        //// can't get the correct duration to show up
        SetStartTime();
        SetFutureTime();

    }

    public void ShowStartMessage()
    {
        Console.WriteLine(_startMessage);
        Console.WriteLine($"Get ready...");
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
        _endMessage = $"Great Job! \nYou have completed {_duration} seconds of the {_activity}.\n";
    }
    public void ShowEndMessage()
    {
        Console.WriteLine($"{_endMessage}\n");
    }


    public DateTime GetStartTime()
    {
        return _startTime;
    }

    public void SetStartTime()
    {
        _startTime = DateTime.Now;
    }

    public DateTime GetFuturetime()
    {
        return _futureTime;
    }

    public void SetFutureTime()
    {
        _futureTime = _startTime.AddSeconds(5000);
    }

    public void PauseWithSpinner(int spins)
    {
        //List<char> spinner = new List<char>();
        for (int i = 0; i < spins; i++)
        {
            Console.Write(">");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }
        Console.WriteLine();

    }
    public void PausewithTimer(int timer)
    {
        while (timer > 0)
        {
            Console.Write(timer);
            timer = timer - 1;
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character

        }
        Console.WriteLine();
    }
}
