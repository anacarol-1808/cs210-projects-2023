using System;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        string _menuOption = "0";
        Goal goal = new Goal();

        while (_menuOption != "6")
        { 
            Console.WriteLine($"\r\nYou have {_totalPoints} points.\r\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            _menuOption = Console.ReadLine();

            if (_menuOption == "1")
            {
                goal.CreateGoal();
            }
        }
            
    }
}