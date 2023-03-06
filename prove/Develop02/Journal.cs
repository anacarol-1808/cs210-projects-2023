class Journal
{
    List<Entry> entries;

    
    //constructor
    public Journal()
    {
        entries = new List<Entry>();
    }

    public void CreateJournalEntry(string date, string prompt, string answer)
    {
        Entry entry = new Entry(date, prompt, answer); 
        entries.Add(entry);
    }

    public void SaveToFile()
    {

    }

    public void LoadFromFile()
    {

    }

    public void DisplayJournalEntries()
    {
        foreach(var item in entries)
        {   
            Console.WriteLine();
            Console.WriteLine(item._date);
            Console.WriteLine(item._prompt);
            Console.WriteLine(item._answer);
        }
    }

}   
