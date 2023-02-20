public class BreathingActivity : Activity
{
    // constructor
    public BreathingActivity(string activity, string description) : base(activity, description) { }

    //Method (Access Type) (Return Type) (Name)
    public void Breathe()
    {

        Console.Write("Breath in...");
        PausewithTimer(2);
        Console.Write("Breath out...");
        PausewithTimer(3);
        Console.WriteLine();
        _duration -= 5;

        while (_duration > 0)
        {
            Console.Write("Breath in...");
            PausewithTimer(4);
            Console.Write("Breath out...");
            PausewithTimer(6);
            Console.WriteLine();
            _duration -= 10;
        }
    }

    //The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
    //The description of this activity should be something like: "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
    //After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
    //After each message, the program should pause for several seconds and show a countdown.
    //It should continue until it has reached the number of seconds the user specified for the duration.
    //The activity should conclude with the standard finishing message for all activities.
}