using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        Nullable<int> number = null;
        List<string> numbers = new List<string>();

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            numbers.Add($"{number}");
        }

        // Compute the sum, or total, of the numbers in the list.

        float sum = 0;
        float total = 0;

        foreach (string word in numbers)
        {
            float integer = float.Parse(word);
            sum += integer;
            total++;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list.

        float average = sum / (total - 1);

        Console.WriteLine($"The average  is: {average}");

        // Find the maximum, or largest, number in the list.
        int bigger = -99999999;
        int numberBefore = -999999999;


        for (int i = 0; i < numbers.Count; i++)
        {
            int actualNumber = int.Parse(numbers[i]);

            if (actualNumber > numberBefore)
            {
                bigger = actualNumber;
                numberBefore = actualNumber;
            }

        }

        Console.WriteLine($"The largest number is: {bigger}");

    }
}