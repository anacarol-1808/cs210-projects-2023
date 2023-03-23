public class BreathingActivity : Activity
{
    //attributes

    //construtor
    public BreathingActivity()
    {

    }

    public BreathingActivity(string activityName, string description, int duration, int activityLog) : base (activityName, description, duration, activityLog)
    {

    }

    //methods
    public void BreathInAndOut()
    {
        DisplayStartMessage(_activityName, _description);
        GetActvityDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        PausingSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write("\r\nBreath in...");
            PausingCountDownTimer(4);
            Console.Write("\r\nNow breath out...");
            PausingCountDownTimer(4);
        }
        Console.WriteLine();
        DisplayEndMessage();
    }
}