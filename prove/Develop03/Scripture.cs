public class Scripture 
{
    // Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    private string _scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    private Reference _reference;
    private List<Word> _wordsList = new List<Word>();


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

    private void FindRandomWord()
    {
        int i = 3;

        do 
        {
            Random rnd = new Random();
            int randNum = rnd.Next(_wordsList.Count);

            if (_wordsList[randNum]._isHidden == false)
            {
                Word isHidden = new Word(_wordsList[randNum]._wordText);
                isHidden.HideWord();
                i--;
            }
            
        }
        while (i >= 1);

    }

}
    
    
    
 
 