public class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;

    }
    public void _printComment()
    {
        Console.WriteLine($"{_commenter}: \n{_text} ");
    }
}
//a comment should be defined by the comment class which has the reponsibility for tracking both the name of the person who make the comment and the text of the comment.