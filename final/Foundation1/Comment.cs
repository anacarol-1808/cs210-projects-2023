public class Comment
{
    //attributes
    private string _commentAuthor;
    private string _text;

    //constrcutors

    public Comment()
    {

    }

    public Comment(string commentAuthor, string text)
    {
        _commentAuthor = commentAuthor;
        _text = text;
    }

    public string GetCommentAuthor()
    {
        return _commentAuthor;
    }

    public string GetText()
    {
        return _text;
    }

}