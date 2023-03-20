public class ReflectingActivity : Activity
{
    //attributes
    List<string> _prompts;
    List<string> _questions;
    
    //constructor
    ReflectingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {

    }
}