public class Scripture
{

    List<string> _words;
    private string _reference = "Proverbs 3:5-6";
    private string _scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding; in all thy ways acknowledge him, and he shall direct thy paths.";

    public Scripture()
    {

    }

    public List<string> CreateListOfWords()
    {   
        List <string> words = new List<string>();
        string[] _splitedWords = _scriptureText.Split(" ");
        foreach (string item in _splitedWords)
        {
            words.Add(item);
        }    
        
        return words;
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
        
    }




}