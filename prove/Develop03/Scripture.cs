public class Scripture 
{
    // Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    private string _scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    private Reference _reference = new Reference();
    public List<Word> _wordsList = new List<Word>();


    // constructor here
    public Scripture()
    {
        
    }
    

    // Methods here

    // Find the words that are in the scripture
    // Split into array of words
    // Create words objects and add them to the list of words
    public List<Word> CreateListOfWords()
    {
        string[] _splitedWords = _scriptureText.Split(" ");
        foreach (string item in _splitedWords)
        {   
            Word word = new Word(item);
            _wordsList.Add(word);
        } 

        return _wordsList;           
    }

    public List<Word> FindRandomWord()
    {
        int i = 3;

        do 
        {
            Random rnd = new Random();
            int randNum = rnd.Next(_wordsList.Count);

            if (_wordsList[randNum]._isHidden == false)
            {
                _wordsList[randNum].HideWord();
                i--;
            
            }
            
        }
        while (AreAllWordsHidden() == false && i >= 1);

        return _wordsList;

    }

    
    public void DisplayScripture()
    {
        Console.Write($"{_reference._book} {_reference._chapter}:{_reference._startVerse}-{_reference._endVerse} ");
        foreach (Word item in _wordsList)
        {
            Console.Write($"{item._wordText} ");
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press ENTER to continue or type 'quit' to finish:");
    }

    public bool AreAllWordsHidden()
    {
        int i = 0;
        int totalWords = _wordsList.Count;

        foreach (Word item in _wordsList)
        {
            if (item._isHidden == true)
            {
                i++;
            }
        }

        if (i == totalWords)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
    
    
    
 
 