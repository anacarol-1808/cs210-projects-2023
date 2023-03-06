class Journal
{
    List<Entry> entries;

    
    //constructor
    public Journal()
    {
        entries = new List<Entry>();
    }

    public void CreateJournalEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName, append:true))
        {   

            foreach(Entry item in entries)
            {   
                outputFile.WriteLine($"Date: |{item._date}|Prompt: |{item._prompt}|Answer: |{item._answer}");
            }

        }
    }

    public void LoadFromFile(string fileName)
    {
        //entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        { 
            string[] parts = line.Split("|");
            Entry entry = new Entry(parts[1], parts[3], parts[5]);
            entries.Add(entry);
        }

    }

    public void DisplayJournalEntries()
    {
        foreach(Entry item in entries)
        {   
            Console.WriteLine();
            Console.WriteLine($"Date: {item._date} - Prompt: {item._prompt}");
            Console.WriteLine(item._answer);
        }
    }

}   
