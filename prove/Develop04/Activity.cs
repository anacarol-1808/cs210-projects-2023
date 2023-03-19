public class Activity
{
    // attributes
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected List<string> _spinner = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
    protected string _menuChoice;

    // constructors
    public Activity()
    {

    }

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    // methods
    public void DisplayMenu()
    {   
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from menu: ");
        _menuChoice = Console.ReadLine();
    }


    protected void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndMessage()
    {   
        Console.WriteLine("\r\n");
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} of the {_activityName}.");
    }

    public void PausingSpinner(int duration)
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {        
            Console.Write(_spinner[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= _spinner.Count)
            {
                i = 0;
            }
        }
        
    }

    public void PausingCountDownTimer(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PausingDots()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void GetActvityDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }




}