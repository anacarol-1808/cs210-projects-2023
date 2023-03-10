using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        // Journal Menu
        
        Journal journal = new Journal();
        string option = "";
        string fileName = "";

        do
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();
            
            if (option == "1")
            {    
                journal.CreateJournalEntry();    
            }

            else if (option == "2")
            {
                journal.DisplayJournalEntries();
            }

            else if (option == "3")
            {
                Console.WriteLine("What is the filename? ");
                fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }

            else if (option == "4")
            {
                Console.WriteLine("What is the filename? ");
                fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            
            }

            
        }

        while (option != "5");

    }
}
