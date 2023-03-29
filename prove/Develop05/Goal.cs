public class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    public string _goalType;

    public Goal()
    {
        
    }

    public Goal(string goalName, string description, int points, string goalType)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _goalType = goalType;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public virtual void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    //goodbye

    






}