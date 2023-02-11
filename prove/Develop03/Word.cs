public class Word
{
    private string _word;
    private bool _visible;


    //constructor
    public Word(string text)
    {
        _word = text;
        _visible = true;
    }
    public void Show()
    {
        Console.WriteLine(_word);
    }
    public void Hide()
    {
        foreach (char _letter in _word)
        {
            Console.WriteLine("_");
        }
    }

    public string GetWord()
    {
        return _word;
    }

    public bool GetVisible()
    {
        return _visible;
    }

    public void SetVisible(bool visible)
    {
        _visible = visible;
    }
}