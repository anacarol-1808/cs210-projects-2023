public class Word
{

    public Word()
    {

    }

    Scripture listOfWords = new Scripture();
    List<string> words = new List<string>();
    List<string> newWords = new List<string>();

    private int rand_num1;
    private int rand_num2;
    private int rand_num3;
    static  Random rnd = new Random();
    public void EraseRandomWords()
    {
        words = listOfWords.CreateListOfWords();
            
            rand_num1 = rnd.Next(words.Count);
            rand_num2 = rnd.Next(words.Count);
            rand_num3 = rnd.Next(words.Count);

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
        
        foreach (string item in words)
        {
            newWords.Add(item);
        }    

        listOfWords.DisplayMissingWordsScripture(newWords);
        words = newWords;

    }
}