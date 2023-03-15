public class WritingAssignment : Assignment
{
    private string _title;

    // constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return ($"{_title} by {_studentName}");
    }
    
}