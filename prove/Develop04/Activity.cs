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

        if (_menuChoice == "1")
        {
            _activityName = "Breathing";
            _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            BreathingActivity breath = new BreathingActivity(_activityName, _description, _duration);
            breath.BreathInAndOut();
        }
        else if (_menuChoice == "2")
        {
            _activityName = "Reflection";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        }
        else if (_menuChoice == "3")
        {
            _activityName = "Listing";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }
    }


    public void DisplayStartMessage(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        Console.WriteLine($"\r\nWelcome to the {_activityName} Activity.");
        Console.WriteLine($"\r\n{_description}"); 
    }

    public void DisplayEndMessage()
    {   
        Console.WriteLine("\r\nWell done!!");
        Console.WriteLine($"\r\nYou have completed another {_duration} seconds of the {_activityName} Activity.");
        PausingSpinner(5);
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

    public int GetActvityDuration()
    {
        Console.Write("\r\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }




}