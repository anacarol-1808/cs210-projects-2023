using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        int _menuOption = 0;
        int _goalOption = 0;
        string fileName;
        List<Goal> goalList = new List<Goal>();       
          
        Console.Clear();
        while (_menuOption != 6)
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
            _menuOption = int.Parse(Console.ReadLine());

            if (_menuOption == 1)
            {
                Console.WriteLine("\r\nThe types of goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. CheckList Goal");
                Console.Write("Which type of goal would you like to create? ");
                _goalOption = int.Parse(Console.ReadLine());

                if (_goalOption == 1)
                {
                    SimpleGoal simple = new SimpleGoal();
                    simple.CreateGoal();
                    simple.SetGoalType("simple");
                    goalList.Add(simple);
                }
                else if (_goalOption == 2)
                {
                    EternalGoal eternal = new EternalGoal();
                    eternal.CreateGoal();
                    eternal.SetGoalType("eternal");
                    goalList.Add(eternal);
                }
                else if (_goalOption == 3)
                {
                    CheckListGoal checkList = new CheckListGoal();
                    checkList.CreateGoal();
                    checkList.SetGoalType("checkList");
                    goalList.Add(checkList);
                }

            }

            else if (_menuOption == 2)
            {
                int listNum = 1;
                foreach (Goal item in goalList)
                {   
                    Console.Write($"{listNum}. ");
                    item.DisplayGoal();
                    listNum++;  
                } 
            }

            else if (_menuOption == 3)
            {
                Console.WriteLine("What is the file name for the goal file? ");
                fileName = Console.ReadLine();
                File.Create(fileName).Close(); // clearing the file, because I am using append
                foreach (Goal item in goalList)
                {
                    item.WriteToFile(fileName);
                }
            }

            else if (_menuOption == 4)
            {
                Console.WriteLine("What is the file name for the goal file? ");
                fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(", ");

                    if (parts[3] == "simple")
                    {
                        SimpleGoal simpleG = new SimpleGoal();
                        simpleG.LoadFromFile(fileName, goalList, line);
                    }

                    else if (parts[3] == "eternal")
                    {
                        EternalGoal eternalG = new EternalGoal();
                        eternalG.LoadFromFile(fileName, goalList, line);
                    }

                    else if (parts[3] == "checkList")
                    {
                        CheckListGoal checkListG = new CheckListGoal();
                        checkListG.LoadFromFile(fileName, goalList, line);
                    }
                }
            }


        }
           
        
    }
}
