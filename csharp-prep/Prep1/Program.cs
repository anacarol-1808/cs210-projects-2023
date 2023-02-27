using System;

class Program
{
    static void Main(string[] args)
    {

        // Getting First Name
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        // Getting Last Name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Printing it to the terminal
        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");


    }
}