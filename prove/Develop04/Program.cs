using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        //activity.DisplayMenu();

        BreathingActivity breath = new BreathingActivity();
        breath.BreathInAndOut(8);
    }
}