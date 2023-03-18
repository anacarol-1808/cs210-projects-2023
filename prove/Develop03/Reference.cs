public class Reference
{   
    // Reference - Keeps track of the book, chapter, and verse information.
    private string _book = "Proverbs";
    private string _chapter = "3";
    private string _startVerse = "5";
    private string _endVerse = "6";

    //constructor
    public Reference()
    {

    }

    public string GetReference()
    {
        return ($"{_book} {_chapter}:{_startVerse}-{_endVerse}"); 
    }

}