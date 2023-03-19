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
    public void BreathInAndOut(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.Clear();
        Console.WriteLine("Get ready...");
        Activity activity = new Activity();
        activity.PausingSpinner(5);

        while(DateTime.Now < endTime)
        {
            Console.WriteLine("\r\n");
            Console.Write("Breath in...");
            activity.PausingCountDownTimer(4);
            Console.WriteLine("");
            Console.Write("Now breath out...");
            activity.PausingCountDownTimer(4);
        }

        activity.DisplayEndMessage();
        activity.PausingSpinner(4);

    }
}