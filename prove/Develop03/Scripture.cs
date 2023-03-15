public class Scripture
{
    
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    private string _scriptureText;

    // constructor here
    public Scripture()
    {

    }
    public Scripture(string scriptureText)
    {
        _scriptureText = scriptureText;
    }

    public Scripture(Reference reference)
    {
        _reference = reference;

    }

    // Methods here

    // Find the words that are in the scripture
    // Split into array of words
    // Create words objects and add them to the list of words
    public void CreateListOfWords()
    {
        string[] _splitedWords = _scriptureText.Split(" ");
        foreach (string item in _splitedWords)
        {   
            Word word = new Word(item);
            _words.Add(word);
        }            
    }

    // Loop trhough list of words and call Word.HideWords
    public void HideWords()
    {
        foreach (Word item in _words)
        {
            
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_scriptureText);
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /*// These are my attributes
    private List<Word> _words = new List<Word>();
    private Reference _reference = new Reference();

    private string _scripture = "Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding; in all thy ways acknowledge him, and he shall direct thy paths.";

    public Scripture()
    {
        // split into array of words
        // create words objects and add them to the list of words
    }

    // Method -- loop trhough list of words and call Word.Hide






    /*public List<Word> CreateListOfWords()
    {   
        string[] _splitedWords = _scriptureText.Split(" ");
        foreach (string item in _splitedWords)
        {
            _words.Add(item);
        }    
        
        return _words;
    }

    public string DisplayFullScripture()
    {   
        return ($"{_reference} {_scriptureText}");
    }

    public void DisplayMissingWordsScripture(List<string> newWords)
    {   
        Console.Write($"{_reference} ");
        int i = 0;
        foreach (string item in newWords)
        {
            Console.Write($"{newWords[i]} ");
            i++;
        }
        
    }*/




}