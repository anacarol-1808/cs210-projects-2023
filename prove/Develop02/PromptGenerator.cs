class PromptGenerator 
{   
    List<string> prompts = new List<string>()
    {
      "Who was the most interesting person I interacted with today?",
      "What was the best part of my day?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?",
      "What was something I accomplished today?",
      "What am I grateful for today?",
      "What negative thought I had today and how could I turned it to be more positive?",
      "Did I served someone today?"
    };
    
    // constructor
    public PromptGenerator()
    {

    }
       
    public string GetRandomQuestion() 
    {  
        Random rd = new Random();
        int rand_num =  rd.Next(prompts.Count());
        return prompts[rand_num];
        
    }


}