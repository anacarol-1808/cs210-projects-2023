public class Word
{   
    // Class Word - Keeps track of a single word and whether it is shown or hidden. 
    // It hides words by replacing them with "_" and changing the boolean _isHidden from false to true.

    // attributes
    private string _wordText;
    public bool _isHidden = false;

    // constructor
    public Word()
    {

    }
    
    public Word(string wordText)
    {
        _wordText = wordText;
    }

    // methods
    public void HideWord()
    {   
        _wordText = new String('_', _wordText.Length);
        _isHidden = true;
    }

    public string GetWordText()
    {
        return _wordText;
    }

    
}