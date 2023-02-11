public class Reference
{
    public string _book;
    public string _chapter;
    public string _startVerse;
    public string _endVerse;
    public string _referenceText;



    //constructors (no void, int, or bool)
    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;
        _referenceText = ($"{book} {chapter}:{startVerse}");
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _referenceText = ($"{book} {chapter}:{startVerse}-{endVerse}");
    }

    public string GetReferenceText()
    {
        return _referenceText;
    }

}