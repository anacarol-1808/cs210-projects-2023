public class Word
{
    // attributes
    private string _wordText;
    private bool _isHidden = false;

    // constructor
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

    public string getWord()
    {
        return _wordText;
    }

    public void displayWord()
    {
        Console.WriteLine(_wordText);
    }

    /*pulbic void isHidden()
    {

    }*/



















    /*public void EraseRandomWords()
    {
        //words = listOfWords.CreateListOfWords();
            Random rnd = new Random();
            int rand_num1 = rnd.Next(words.Count);
            int rand_num2 = rnd.Next(words.Count);
            int rand_num3 = rnd.Next(words.Count);

        if (words[rand_num1] == "_____" || words[rand_num2] == "_____" || words[rand_num3] == "_____")
        {
            do
            {
                rand_num1 = rnd.Next(words.Count);
                rand_num2 = rnd.Next(words.Count);
                rand_num3 = rnd.Next(words.Count);
            }
            while (words[rand_num1] == "_____" || words[rand_num2] == "_____" || words[rand_num3] == "_____");
        }
        
        words[rand_num1] = "_____";
        words[rand_num2] = "_____";
        words[rand_num3] = "_____";
        
        listOfWords.DisplayMissingWordsScripture(words);

    }*/
}