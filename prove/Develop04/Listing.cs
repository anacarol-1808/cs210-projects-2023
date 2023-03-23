public class ListingActivity : Activity
{
    //attributes
    List<string> _prompts = new List<string> {"Who are people that you appreciate?",
                                              "What are personal strengths of yours?",
                                              "Who are people that you have helped this week?",
                                              "When have you felt the Holy Ghost this month?",
                                              "Who are some of your personal heroes?"};

    //constructors
    public ListingActivity()
    {

    }

    public ListingActivity(string activityName, string description, int duration, int activityLog) : base (activityName, description, duration, activityLog)
    {

    }

    Random rnd = new Random();
    public void GetRandomPrompt()
    {
        DisplayStartMessage(_activityName, _description);
        GetActvityDuration();

        int randNum1 = rnd.Next(_prompts.Count);

        Console.Clear();
        Console.WriteLine("Get ready...");
        PausingSpinner(5);
        Console.WriteLine("\r\nList as many responses you can to the following prompt:");

        Console.WriteLine($"\r\n    --- {_prompts[randNum1]} ---\r\n");
        Console.Write($"You may begin in: ");
        PausingCountDownTimer(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int listingNumber = 0;
        Console.WriteLine("\r\n");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            listingNumber ++;
        }

        DisplayListingNumber(listingNumber);

    }

    public void DisplayListingNumber(int listingNumber)
    {   
        Console.WriteLine($"\r\nYou listed {listingNumber} items!\r\n");
        DisplayEndMessage();
    }

}