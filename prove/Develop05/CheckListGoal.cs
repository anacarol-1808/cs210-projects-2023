public class CheckListGoal : Goal
{
    protected int _numOfTimes;
    protected int _completedTimes = 0;
    protected int _bonus;
    public CheckListGoal()
    {
        _goalType = "checkList";
        CreateGoal();
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
        if (_isCompleted == false)
        {
            Console.WriteLine($"[ ] {_goalName} ({_description} -- Currently completed: {_completedTimes}/{_numOfTimes})");
        }
        else if (_isCompleted == true)
        {
            Console.WriteLine($"[X] {_goalName} ({_description} -- Currently completed: {_completedTimes}/{_numOfTimes})");
        }
    }

    public override void WriteToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            
            outputFile.WriteLine($"{_goalName}, {_description}, {_points}, {_goalType}, {_isCompleted}, {_numOfTimes}, {_completedTimes}, {_bonus}");
            
        }
    }

    public override void RecordEvent()
    {
        _totalGoalsCompleted += 1;
        _completedTimes += 1;

        if (_numOfTimes == _completedTimes)
        {
            _totalPoints = + _bonus + _points;
            Console.WriteLine($"Congratulations! You have earned {_bonus} bonus points! You earned a total of {_bonus + _points} points! ");
            _isCompleted = true;
        }
        else
        {
            _totalPoints += _points;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }
}

    