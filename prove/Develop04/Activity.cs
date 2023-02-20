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
        _endMessage = "Great Job!";
        SetStartTime();
        SetFutureTime();

    }

    public void ShowStartMessage()
    {
        Console.WriteLine(_startMessage);
        Console.WriteLine($"Get ready...");
    }

    public void ShowEndMessage()
    {
        Console.WriteLine($"{_endMessage}\n");
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
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

    public void PauseWithSpinner()
    {
        List<char> spinner = new List<char>();
        for (int i = 0; i < 5; i++)
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



// it should tell the user to prepare to begin and pause for several seconds. Get ready.. animation..well done!! You've completed another __ seconds of the ___ Activity.
//should end with a common ending message that tells the user they have done a good job and pause and then tell them the activity they have completed and the length of time and pauses for several seconds before finishing
// when it pauses it should show some kind of animation to the user, such as a spinner, a countdown timer or periods being displayed to the screen
//In the demo video, you can see the program pausing for a certain period of time. This can be done with the Thread.Sleep() method which takes an integer as the number of milliseconds for the current "thread of execution" to sleep or pause.The following example shows how to make the computer to wait for 1 second (1000 milliseconds):
// Console.WriteLine("Going to sleep for a second...");
// Thread.Sleep(1000);
// Console.WriteLine("I'm back!!");

// **   Display Animations
// To display an animation, such as the spinner or the countdown timer, you need to have the computer pause for a period of time, and then replace the previous character with a new one. This can be done by writing the backspace character "\b" and which works like pushing the left arrow. Then, you can write a new character over the top of it.
// Because the backspace character works like pressing the left arrow, instead of a backspace, it does not delete the character on the screen. With this in mind, it is common to write "\b \b" which moves left, writes a blank space over the previous character and then moves left again so it is ready for your new character.
// The following example shows how to overwrite a character after half a second:
// Console.Write("+");
// Thread.Sleep(500);
// Console.Write("\b \b"); // Erase the + character
// Console.Write("-"); // Replace it with the - character
// If this code were in a loop it would continue displaying and replacing characters.
// **  Working with Time
// The C# language has a powerful Date and Time library. You might find it useful to get the current time, add a number of seconds to it, and then check if the current time is less than the new time.
// This can be accomplished with the DateTime class. An object with the current time can be obtained withe DateTime.Now . Then, it has methods such as .AddSeconds(numberOfSeconds), and it works with the less than < operator as you would expect.
// The following code snippet shows an example:
// DateTime startTime = DateTime.Now;
// DateTime futureTime = startTime.AddSeconds(5000);
// Thread.Sleep(3000);
// DateTime currentTime = DateTime.Now;
// if (currentTime < futureTime)
// {
//     Console.WriteLine("We have not arrived at our future time yet...")
// }
