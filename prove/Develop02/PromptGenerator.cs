class PromptGenerator 
{   
    List<string> prompts;
    // constructor
    public PromptGenerator()
    {

    }
       
    public string GetRandomQuestion() 
    {  
        Random rd = new Random();
        int rand_num =  rd.Next(0, 4);
        // Testing if getting random number
        //Console.WriteLine($"This is my random number: {rand_num}");

        switch (rand_num)
        {
            case 0:
                //Console.WriteLine("Who was the most interesting person I interacted with today?");
                return "Who was the most interesting person I interacted with today?";
            case 1:
               //Console.WriteLine("What was the best part of my day?");
                return "What was the best part of my day?";
            case 2:
              //Console.WriteLine("How did I see the hand of the Lord in my life today?");
                return "How did I see the hand of the Lord in my life today?";
            case 3:
              //Console.WriteLine("What was the strongest emotion I felt today?");
                return "What was the strongest emotion I felt today?";
            case 4:
              //Console.WriteLine("If I had one thing I could do over today, what would it be?");
                return "If I had one thing I could do over today, what would it be?";
        }

        return "";
        
    }


}