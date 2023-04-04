using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        //Running
        activities.Add(new Running("03 Apr 2023", 15, "Running", 3));

        //Cycling
        activities.Add(new Cycling("02 Apr 2023", 30, "Cycling", 20));

        // Swimming
        activities.Add(new Swimming("01 Apr 2023", 30, "Swimming", 20));

        foreach (Activity item in activities)
        {
            item.GetSummary();
        }

    }
}