public class Menu
{
    int _totalPoints = 0;
    int _menuOption = 0;
    int _goalOption = 0;
    List<Goal> goalList = new List<Goal>();
    


    public Menu()
    {

    }

    public List<Goal> GetGoalList()
    {
        return goalList;
    }

    
    
    public void DisplayMenu()
    {   
        Console.Clear();
        while (_menuOption != 6)
        { 
            Goal goal = new Goal();
            CheckListGoal checkListGoal = new CheckListGoal();
    
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
                    goal.CreateGoal();
                    goal._goalType = "simple";
                    goalList.Add(goal);
                }
                else if (_goalOption == 2)
                {
                    goal.CreateGoal();
                    goal._goalType = "eternal";
                    goalList.Add(goal);
                }
                else if (_goalOption == 3)
                {
                    checkListGoal.CreateGoal();
                    checkListGoal._goalType = "checkList";
                    goalList.Add(checkListGoal);
                }

            }

            else if (_menuOption == 2)
            {
                int i = 0;
                int listNum = 1;
                foreach (Goal item in goalList)
                {   
                    string goalType = goalList[i]._goalType;
                    string goalName = goalList[i].GetGoalName();
                    string goalDescription = goalList[i].GetGoalDescription();

                    if (goalType == "simple")
                    {
                        Console.WriteLine($"{listNum}. [ ] {goalName} ({goalDescription})");
                    }
                    else if (goalType == "eternal")
                    {
                        Console.WriteLine($"{listNum}. {goalName} ({goalDescription})");
                    }
                    else if (goalType == "checkList")
                    {
                        //string goalName = checkListGoal.
                        int numOfTimes = checkListGoal.GetNumOfTimes();
                        int completedTimes = checkListGoal.GetCompletedTimes();
                        Console.WriteLine($"{listNum}. [ ] {goalName} ({goalDescription} -- Currently completed: {completedTimes}/{numOfTimes})");
                    }
                    i++;
                    listNum++;
                    
                }
            }

            

        }
    }
            
    
}