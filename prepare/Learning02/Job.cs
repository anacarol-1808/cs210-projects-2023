
/*
Create a new file for your job class. By convention this should be named Job.cs .
Create the class (Hint this is the public class Job syntax).
Create member variables in the class for each element that this class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle .
*/
public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;


    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}