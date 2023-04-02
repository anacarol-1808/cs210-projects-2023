public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    protected string _goalType;
    protected int _totalPoints;
    protected int _totalGoalsCompleted;

    public Goal()
    {
        
    }

    public Goal(string goalName, string description, int points, string goalType, bool isCompleted)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _goalType = goalType;
        _isCompleted = isCompleted;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }
    public bool GetIsCompleted()
    {
        return _isCompleted;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public int GetTotalGoalsCompleted()
    {
        return _totalGoalsCompleted;
    }

    public void SetGoalsCompleted(int totalGoalsCompleted)
    {
        _totalGoalsCompleted = totalGoalsCompleted;
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

    public abstract void DisplayGoal();

    public abstract void WriteToFile(string fileName);
   
    public abstract void LoadFromFile(string fileName, List<Goal> goals, string fileLine);

    public abstract void RecordEvent();

}