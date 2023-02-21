public class BreathingActivity : Activity
{
    // constructor
    public BreathingActivity(string activity, string description) : base(activity, description) { }

    //Method (Access Type) (Return Type) (Name)
    public void Breathe()
    {
        int duration = _duration;
        Console.Write("Breath in...");
        PausewithTimer(2);
        Console.Write("Breath out...");
        PausewithTimer(3);
        Console.WriteLine();
        duration -= 5;

        while (duration > 0)
        {
            Console.Write("Breath in...");
            PausewithTimer(4);
            Console.Write("Breath out...");
            PausewithTimer(6);
            Console.WriteLine();
            duration -= 10;
        }
    }
}