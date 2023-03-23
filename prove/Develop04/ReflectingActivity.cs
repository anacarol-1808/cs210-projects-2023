public class ReflectingActivity : Activity
{
    //attributes
    List<string> _prompts = new List<string> {"Think of a time when you stood up for someone else.", 
                                             "Think of a time when you did something really difficult.", 
                                             "Think of a time when you helped someone in need.", 
                                             "Think of a time when you did something truly selfless."};
                          
    List<string> _questions = new List<string> {"Why was this experience meaningful to you?",
                                                "Have you ever done anything like this before?",
                                                "How did you get started?",
                                                "How did you feel when it was complete?",
                                                "What made this time different than other times when you were not as successful?",
                                                "What is your favorite thing about this experience?",
                                                "What could you learn from this experience that applies to other situations?",
                                                "What did you learn about yourself through this experience?",
                                                "How can you keep this experience in mind in the future?"};
    
    //constructor
    public ReflectingActivity()
    {

    }
    public ReflectingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }

    //methods
    Random rnd = new Random();
    public void GetRandomPrompt()
    {
        DisplayStartMessage(_activityName, _description);
        GetActvityDuration();

        int randNum1 = rnd.Next(_prompts.Count);

        Console.Clear();
        Console.WriteLine("Get ready...");
        PausingSpinner(5);
        Console.WriteLine("\r\nConsider the following prompt:");

        Console.WriteLine($"\r\n    --- {_prompts[randNum1]} ---\r\n");
        Console.WriteLine("\r\nWhen you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        PausingCountDownTimer(5);
        Console.Clear();
        GetRandomQuestion();
    }

    public void GetRandomQuestion()
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int randNum2 = rnd.Next(_questions.Count);

        int i = randNum2;

        foreach (string item in _questions)
        {
            while (DateTime.Now < endTime)
            {
                Console.Write($"> {_questions[i]} ");
                PausingSpinner(10);
                Console.WriteLine("");
                i++;

                if (i >= _questions.Count)
                {
                    i = 0;
                }
            }
            
        }

        DisplayEndMessage();
    }
}