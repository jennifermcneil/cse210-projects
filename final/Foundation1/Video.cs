public class Video
{
    private string _title;
    private string _author;
    private int _length;

    public List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

    }
    public void Write(string commenter, string text)
    {
        _commentList.Add(new Comment(commenter, text));
    }
    public void DisplayComments()
    {
        foreach (Comment comment in _commentList)
        {
            comment._printComment();
        }
    }
    public int CommentCount()
    {
        return _commentList.Count();
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"({_title}) by: {_author}, {_length} sec.");
        Console.WriteLine($"Number of Comments: {CommentCount()}");
        Console.WriteLine("Comments: ");

        DisplayComments();
    }
}

//responsiblity to track the title, author, and length(inseconds) of the video.
//method to return the number of comments.