public class Assignment
{
    // attributes
    protected string _studentName;
    private string _topic;
    // constructors
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // methods

    public string GetSummary()
    {
        return ($"{_studentName} - {_topic}");
    }

}