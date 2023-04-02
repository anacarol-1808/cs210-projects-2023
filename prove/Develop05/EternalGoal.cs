public class EternalGoal : Goal
{
    public EternalGoal()
    {

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

    public override void LoadFromFile(string fileName, List<Goal> goals, string fileLine)
    {
        string[] parts = fileLine.Split(", ");
        EternalGoal eternal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]), parts[3], bool.Parse(parts[4]));
        goals.Add(eternal);
        
    }

    public override void RecordEvent()
    {
        _totalPoints += _points;
        _totalGoalsCompleted += 1;

        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
}