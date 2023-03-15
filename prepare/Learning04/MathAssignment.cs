public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // constructor
    public MathAssignment(string studentName, string topic, string textbookSction, string problems) : base(studentName, topic)
    {
        
        _textbookSection = textbookSction;
        _problems = problems;
    }

    // methods
    public string GetHomeworkList()
    {
        return ($"Section {_textbookSection} Problems {_problems}");
    }
}   