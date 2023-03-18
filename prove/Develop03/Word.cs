public class Word
{   
    // Word - Keeps track of a single word and whether it is shown or hidden.
    // attributes
    public string _wordText;
    public bool _isHidden = false;

    // constructor
    public Word()
    {

    }
    
    public Word(string wordText)
    {
        _wordText = wordText;
    }

     public Word(string wordText, bool isHidden)
    {
        
    }

    // methods
    public void HideWord()
    {   
        _wordText = new String('_', _wordText.Length);
        _isHidden = true;
    }

    
}