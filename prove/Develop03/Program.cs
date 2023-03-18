using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        
        
        scripture.CreateListOfWords();
        Console.Clear();
        scripture.DisplayScripture();

        string userInput = "";
    
        while (scripture.AreAllWordsHidden() == false && userInput != "quit")
        {
            userInput = Console.ReadLine();
            Console.Clear();        
            scripture.FindRandomWord();
            Console.Clear();
            scripture.DisplayScripture();
        }
        
    }
}