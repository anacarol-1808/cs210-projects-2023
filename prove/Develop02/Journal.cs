class Journal
{
    List<Entry> _entries;
    
    //constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void CreateJournalEntry(Entry entry)
    {
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
        foreach(var item in _entries)
        {   
            Console.WriteLine();
            Console.WriteLine($"Date: {item._date} - Prompt: {item._prompt}");
            Console.WriteLine(item._answer);
        }
    }

}   
