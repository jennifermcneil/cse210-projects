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
        return "";
    }

    public void Listing()
    {
        Console.Write("List as many responses you can to the follwing prompt: --{prompt}--\n You may begin:\n >()seconds");

    }
    // The activity should begin with the standard starting message and prompt for the duration that is used by all activities.
    // The description of this activity should be something like: "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." List as many responses you can to the following prompt.
    // After the starting message, select a random prompt to show the user such as:

    // Who are people that you appreciate?
    // What are personal strengths of yours?
    // Who are people that you have helped this week?
    // When have you felt the Holy Ghost this month?
    // Who are some of your personal heroes?
    // After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
    // The user lists as many items as they can until they they reach the duration specified by the user at the beginning. You've listed __ items!
    // The activity them displays back the number of items that were entered.
    // The activity should conclude with the standard finishing message for all activities.

}