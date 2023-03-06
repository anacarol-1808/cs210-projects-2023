class Entry 
{
    public string _date;
    public string _prompt;
    public string _answer;

    //constructor
    public Entry(string aDate, string aPrompt, string aAnswer)
    {
        _date = aDate;
        _prompt = aPrompt;
        _answer = aAnswer; 
    }

    public void DisplayEntry(string _date, string _prompt, string _answer)
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_answer}");
        Console.WriteLine();
    }

    public string GetEntryAsFile()
    {
        return "";
    }


    
}