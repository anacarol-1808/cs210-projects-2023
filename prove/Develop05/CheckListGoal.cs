public class CheckListGoal : Goal
{
    protected int _numOfTimes;
    protected int _completedTimes = 0;
    protected int _bonus;
    public CheckListGoal()
    {

    }

    public CheckListGoal(string goalName, string description, int points, string goalType, bool isCompleted, int numbOfTimes, int completedTimes, int bonus) : base (goalName, description, points, goalType, isCompleted)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _goalType = goalType;
        _numOfTimes = numbOfTimes;
        _completedTimes = completedTimes;
        _bonus = bonus;
        _isCompleted = isCompleted;
    }

    public int GetNumOfTimes()
    {
        return _numOfTimes;
    }

    public int GetCompletedTimes()
    {
        return _completedTimes;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    

    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _numOfTimes = int.Parse(Console.ReadLine());
        Console.WriteLine("What  is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());

    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_goalName} ({_description} -- Currently completed: {_completedTimes}/{_numOfTimes})");
    }

    public override void WriteToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            
            outputFile.WriteLine($"{_goalName}, {_description}, {_points}, {_goalType}, {_isCompleted}, {_numOfTimes}, {_completedTimes}, {_bonus}");
            
        }
    }
    public override void LoadFromFile(string fileName, List<Goal> goals, string fileLine)
    {
        string[] parts = fileLine.Split(", ");
        CheckListGoal checkList = new CheckListGoal(parts[0], parts[1], int.Parse(parts[2]), parts[3], bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
        goals.Add(checkList);
        
    }
}

    