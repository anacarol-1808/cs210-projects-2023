public class EternalGoal : Goal
{
    public EternalGoal()
    {
        _goalType = "eternal";
        CreateGoal();
    }

    public EternalGoal(string goalName, string description, int points, string goalType, bool isCompleted) : base (goalName, description, points, goalType, isCompleted)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _goalType = goalType;
        _isCompleted = isCompleted;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"{_goalName} ({_description})");
    }

    public override void WriteToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            
            outputFile.WriteLine($"{_goalName}, {_description}, {_points}, {_goalType}, {_isCompleted}");
            
        }
    }

    public override void RecordEvent()
    {
        _totalPoints += _points;
        _totalGoalsCompleted += 1;

        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
}