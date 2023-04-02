using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int _totalPoints = 0;
        int _totalGoalsCompleted = 0;
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
            Console.WriteLine("");

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
                    SimpleGoal simpleG = new SimpleGoal();
                    simpleG.CreateGoal();
                    simpleG.SetGoalType("simple");
                    goalList.Add(simpleG);
                }
                else if (_goalOption == 2)
                {
                    EternalGoal eternalG = new EternalGoal();
                    eternalG.CreateGoal();
                    eternalG.SetGoalType("eternal");
                    goalList.Add(eternalG);
                }
                else if (_goalOption == 3)
                {
                    CheckListGoal checkListG = new CheckListGoal();
                    checkListG.CreateGoal();
                    checkListG.SetGoalType("checkList");
                    goalList.Add(checkListG);
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
                using (StreamWriter outputFile = new StreamWriter(fileName, true))
                {
                    outputFile.WriteLine($"{_totalPoints}");
                    outputFile.WriteLine($"{_totalGoalsCompleted}");
                }
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
                int i = 0;
                foreach (string line in lines)
                {
                    string[] parts = line.Split(", ");
                    
                    if (parts.Count() <= 1)
                    {
                        if (i == 0)
                        {
                            _totalPoints = int.Parse(parts[0]);
                            i++;
                        }
                        else if (i == 1)
                        {
                            _totalGoalsCompleted = int.Parse(parts[0]);
                        }

                    }
                    else if (parts.Count() > 1)
                    {
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

            else if (_menuOption == 5)
            {   
                int accomplishedGoal;
                int listNum = 1;
                Console.WriteLine("The goals are: ");
                foreach (Goal item in goalList)
                {   
                    Console.WriteLine($"{listNum}. {item.GetGoalName()}");
                    listNum++;
                }
                Console.WriteLine("Which goal did you accomplish? ");
                accomplishedGoal = int.Parse(Console.ReadLine());
                goalList[accomplishedGoal - 1].RecordEvent(); 

                _totalPoints += goalList[accomplishedGoal - 1].GetTotalPoints(); 
                goalList[accomplishedGoal - 1].SetTotalPoints(0);

                _totalGoalsCompleted += goalList[accomplishedGoal - 1].GetTotalGoalsCompleted();
                goalList[accomplishedGoal - 1].SetGoalsCompleted(0);

                Console.WriteLine($"\r\nYou now have {_totalPoints} points."); 
            
            }

            else if (_menuOption == 6)
            {
                Console.WriteLine($"Congratulations! You have completed a total of {_totalGoalsCompleted} so far!\r\n");
            }

            


        }
           
        
    }
}
