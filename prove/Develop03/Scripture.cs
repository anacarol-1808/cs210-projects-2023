public class Scripture 
{
    // Scripture Class - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

    // attributes here
    private string _scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    private Reference _reference = new Reference();
    private List<Word> _wordsList = new List<Word>();


    // constructors here
    public Scripture()
    {
        
    }
    

    // methods here

    // Find the words that are in the scripture; Split into array of words; 
    // Creates Word objects and add them to the list of words
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

    // Get Random index to access a Word in the List; If the Word is not hidden, calls the HideWord method; 
    // It should do it 3 times at a time until all Words from the list are hidden
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

    // Display each Word in the list of Words content of the Scripture; And get the text rendered.
    public void DisplayScripture()
    {
        Console.Write($"{_reference.GetReference()} ");
        foreach (Word item in _wordsList)
        {
            Console.Write($"{item.GetWordText()} ");
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }

    // Creates a bool to find out if all Words in the list were already hidden; 
    // This logic is necessary to modulate the while loop used in Program to keep running the code until all words are hidden. 
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
    
    
    
 
 