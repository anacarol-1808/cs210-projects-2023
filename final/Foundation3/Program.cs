using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture
        Address addressLec = new Address("1234 Main St", "Rexburg", "ID", "Romance Theater"); 
        Lecture lecture = new Lecture("Emotional Management in the 21st century", 
                                      "In addition to talking about how to make the human mind slow down thinking and how to control anxiety to restore quality of life, the renowned psychiatrist, author of the Theory of Multifocal Intelligence, will also address the change in behavior that technology is causing, such as the Accelerated Thinking Syndrome (PAS).",
                                      "April 25th, 2023", "8 PM", addressLec, "Lecture", "Augusto Cury", 400);

        Console.WriteLine("\r\n**********************************");
        Console.WriteLine("FIRST EVENT");
        Console.WriteLine("\r\nStandard Details:\r\n");
        lecture.DisplayStandardDetails();
        Console.WriteLine("\r\nFull Details:\r\n");
        lecture.DisplayFullDetails();
        Console.WriteLine("\r\nShort Description:\r\n");
        lecture.DisplayShortDescription();
        Console.WriteLine("**********************************");

        //Reception
        Address addressRec = new Address("1234 University Blv", "Rexburg", "ID", "Manwaring Center");
        Reception reception = new Reception("5th Celebrate Hapiness", "Come enjoy our 5th Hapiness Celebration as a community. We will have a talk by Augusto Cury on the 10 steps for hapiness, while we enjoy a delicious dinner.",
                                            "May 5th, 2023", "6 PM", addressRec, "Reception", "happiness.cury@gmail.com");

        Console.WriteLine("SECOND EVENT");
        Console.WriteLine("\r\nStandard Details:\r\n");
        reception.DisplayStandardDetails();
        Console.WriteLine("\r\nFull Details:\r\n");
        reception.DisplayFullDetails();
        Console.WriteLine("\r\nShort Description:\r\n");
        reception.DisplayShortDescription();
        Console.WriteLine("**********************************");

        //Outdoor
        Address addressOut = new Address("750 W 7 E", "Rexburg", "ID", "Rexburg Rapids");
        Outdoor outdoor = new Outdoor("Beehive Summer Splash", "Enjoy the community water park to celebrate another great year as our Beehive customer. Refreshments will be provided",
                                      "Jun 10th, 2023", "4 PM", addressOut, "Outdoor", "Sunny");

        Console.WriteLine("THIRD EVENT");
        Console.WriteLine("\r\nStandard Details:\r\n");
        outdoor.DisplayStandardDetails();
        Console.WriteLine("\r\nFull Details:\r\n");
        outdoor.DisplayFullDetails();
        Console.WriteLine("\r\nShort Description:\r\n");
        outdoor.DisplayShortDescription();
        Console.WriteLine("**********************************");

    }   
}