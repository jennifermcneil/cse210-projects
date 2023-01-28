public class Journal
{
    public List<Entry> _entryList = new List<Entry>();
    public PromptGenerator _promptGenerator = new PromptGenerator();
    //journal access Entry methods
    public void Write()
    {
        Entry entry = new Entry();
        entry.ShowPrompt();
        entry.UserWritesInput();
        _entryList.Add(entry);

    }
    public void Display()
    {
        foreach (Entry entry in _entryList)
        {
            entry._printEntry();
        }

    }

}