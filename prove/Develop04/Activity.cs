public class Activity
{
    // attributes
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected List<string> _spinner = new List<string> {"|", "/", "-", "\\", "|", "/", "-", "\\"};
    protected string _menuChoice;

    protected int _activityLog = 0;

    // constructors
    public Activity()
    {

    }

    public Activity(string activityName, string description, int duration, int activityLog)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
        _activityLog = activityLog;
    }

    // methods
    public void DisplayMenu()
    {   
        while (_menuChoice != "4")
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
                BreathingActivity breath = new BreathingActivity(_activityName, _description, _duration, _activityLog);
                breath.BreathInAndOut();
                _activityLog++;
            }
            else if (_menuChoice == "2")
            {
                _activityName = "Reflecting";
                _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflecting = new ReflectingActivity(_activityName, _description, _duration, _activityLog);
                reflecting.GetRandomPrompt();
                _activityLog++;
            }
            else if (_menuChoice == "3")
            {
                _activityName = "Listing";
                _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listing = new ListingActivity(_activityName, _description, _duration, _activityLog);
                listing.GetRandomPrompt();
                _activityLog++;
            }
            else if (_menuChoice == "4")
            {
                Console.WriteLine($"\r\nAwesome! Today you have completed a total of {_activityLog} mindful activities.");
                PausingDots();
                Console.WriteLine("\r\n");
            }
        }
    
    }

    public int GetActvityDuration()
    {
        Console.Write("\r\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }


    public void DisplayStartMessage(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        Console.Clear();
        Console.WriteLine($"\r\nWelcome to the {_activityName} Activity.");
        Console.WriteLine($"\r\n{_description}"); 
    }

    public void PausingSpinner(int duration)
    {   
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {        
            Console.Write(_spinner[i]);
            Thread.Sleep(500);
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

    public void DisplayEndMessage()
    {   
        Console.WriteLine("\r\nWell done!!");
        Console.WriteLine($"\r\nYou have completed another {_duration} seconds of the {_activityName} Activity.");
        PausingSpinner(5);
    }

}