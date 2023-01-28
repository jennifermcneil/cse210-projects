public class Entry
{
    public string _date;
    public PromptGenerator _promptGenerator = new PromptGenerator();
    public string _userInput = "";
    public string _prompt;

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
    public void ShowPrompt()
    {
        _prompt = _promptGenerator.GeneratePrompt();
        Console.WriteLine(_prompt);
    }
    public void UserWritesInput()
    {
        _userInput = Console.ReadLine();
    }
    public void _printEntry()
    {
        Console.WriteLine($"{_date} | {_prompt} | {_userInput}");
    }
}