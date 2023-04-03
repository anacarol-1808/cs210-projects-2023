public class SimpleGoal : Goal
{
    public SimpleGoal()
    {
        _goalType = "simple";
        CreateGoal();
    }

    public SimpleGoal(string goalName, string description, int points, string goalType, bool isCompleted) : base (goalName, description, points, goalType, isCompleted)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _goalType = goalType;
        _isCompleted = isCompleted;
    }

    public override void DisplayGoal()
    {
        if (_isCompleted == false)
        {
            Console.WriteLine($"[ ] {_goalName} ({_description})");
        }
        else if (_isCompleted == true)
        {
            Console.WriteLine($"[X] {_goalName} ({_description})");
        }
        
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
        _isCompleted = true;
        _totalPoints += _points;
        _totalGoalsCompleted += 1;

        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }
    

}