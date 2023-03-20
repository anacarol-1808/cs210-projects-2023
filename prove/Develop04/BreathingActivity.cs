public class BreathingActivity : Activity
{
    //attributes

    //construtor
    public BreathingActivity()
    {

    }

    public BreathingActivity(string activityName, string description, int duration) : base (activityName, description, duration)
    {

    }

    //methods
    public void BreathInAndOut()
    {
        Activity activity = new Activity();
        activity.DisplayStartMessage(_activityName, _description);
        int duration = activity.GetActvityDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        activity.PausingSpinner(5);

        while(DateTime.Now < endTime)
        {
            Console.Write("\r\nBreath in...");
            activity.PausingCountDownTimer(4);
            Console.Write("\r\nNow breath out...");
            activity.PausingCountDownTimer(4);
        }

        activity.DisplayEndMessage();
    }
}