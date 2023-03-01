using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        string firstAnswer = Console.ReadLine();
        int magicNumber = int.Parse(firstAnswer); */

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Nullable<int> guess = null;

        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            string secondAnswer = Console.ReadLine();
            guess = int.Parse(secondAnswer);

            if (magicNumber > guess)
            {
            Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else if (magicNumber == guess)
            {
                Console.WriteLine("You guessed it!");
            }

        }


    }
}