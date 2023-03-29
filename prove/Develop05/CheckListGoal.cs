public class CheckListGoal : Goal
{
    protected int _numOfTimes;
    protected int _completedTimes = 0;
    protected int _bonus;
    public CheckListGoal()
    {

    }

    public CheckListGoal(string goalName, string description, int points, string goalType) : base (goalName, description, points, goalType)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _goalType = goalType;
    }

    public int GetNumOfTimes()
    {
        return _numOfTimes;
    }

    public int GetCompletedTimes()
    {
        return _completedTimes;
    }

    

    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _numOfTimes = int.Parse(Console.ReadLine());
        Console.WriteLine("What  is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());

    } //goodbye
}

    