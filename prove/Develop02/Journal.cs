class Journal
{
    List<Entry> _entries;
    
    //constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void CreateJournalEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomQuestion();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string answer = Console.ReadLine();
        DateTime now = DateTime.Now;
        string date = now.ToShortDateString(); 
        Entry entry = new Entry(date, prompt, answer);
        _entries.Add(entry);
    }

    public void SaveToFile(string _fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName/*, append:true*/))
        {   

            foreach(Entry item in _entries)
            {   
                outputFile.WriteLine($"Date: |{item._date}|Prompt: |{item._prompt}|Answer: |{item._answer}");
            }

        }
    }

    public void LoadFromFile(string _fileName)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        { 
            string[] parts = line.Split("|");
            if (parts[0] != "")
            {
                Entry entry = new Entry(parts[1], parts[3], parts[5]);
                _entries.Add(entry);
            }
            
        }

    }

    public void DisplayJournalEntries()
    {   
        foreach(Entry item in _entries)
        {   
            Console.WriteLine();
            Console.WriteLine("Date: {0} - Prompt: {1}", item._date, item._prompt);
            Console.WriteLine(item._answer);
        }
    }

}   
