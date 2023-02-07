public class Reference
{
    public string _book;
    public string _chapter;
    public string _verseText;
    public List<string> _listVerse = new List<string>();

    //constructors (no void, int, or bool)
    public Reference()
    {

    }
    public Reference(string book, string chapter, string verse1, List<string> verseText)
    {

    }

    public Reference(string book, string chapter, string verse1, string verse2, List<string> verseText)
    {

    }

    public string GetBook()
    {
        return "John";
    }

    public string GetChapter()
    {
        return "16";
    }
    public string GetVerseText()
    {
        return "asdgadfg";
    }
    public void SetVerseText(int index)
    {

    }

}