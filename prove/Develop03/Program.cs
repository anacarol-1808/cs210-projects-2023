using System;

class Program
{
    static void Main(string[] args)
    {
        

        var scriptureText = new Scripture("Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        scriptureText.CreateListOfWords();



























        /*Scripture scripture = new Scripture();
        Console.WriteLine(scripture.DisplayFullScripture());
        scripture.CreateListOfWords(); 

        Word word = new Word();

        string input = Console.ReadLine();
        do
        {   
            word.EraseRandomWords();
            input = Console.ReadLine();
            Console.Clear();
        }
        while (input != "quit");*/

        

    }
}