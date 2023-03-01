using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
        }

        else if (grade < 60)
        {
            letterGrade = "F";
        };

        Console.WriteLine($"Your grade is {letterGrade}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }

        else
        {
            Console.WriteLine("Sorry, you didn't pass the class this time, but keep up the good work.");
        };

        /*
        Ask the user for their grade percentage, then write a series of if-elif-else statements to print out the appropriate letter grade. 
        (At this point, you'll have a separate print statement for each grade letter in the appropriate block.)
        Assume that you must have at least a 70 to pass the class. After determining the letter grade and printing it out. 
        Add a separate if statement to determine if the user passed the course, and if so display a message to congratulate them. If not, display a different message to encourage them for next time.
        Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block, instead create a new variable called letter and then in each block, set this variable to the appropriate value. 
        Finally, after the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
        */

    }
}