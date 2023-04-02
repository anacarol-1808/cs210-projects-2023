public class Video
{
    //attributes
    private string _title;
    private string _videoAuthor;
    private int _length;
    private int _numOfComments;
    List<Comment> _comments = new List<Comment>();

    //constrcutors
    public Video()
    {

    }

    public Video(string title, string videoAuthor, int lenght, List<Comment> comments)
    {
        _title = title;
        _videoAuthor = videoAuthor;
        _length = lenght;
        _comments = comments;
    }

    //methods     

    public string GetTitle()
    {
        return _title;
    }      

    public string GetAuthor()
    {
        return _videoAuthor;
    }

    public int GetLenght()
    {
        return _length;
    }

    public int GetNumOfComments()
    {
        return _comments.Count();
    }

    public List<Comment> GetCommentsList()
    {
        return _comments;
    }
}