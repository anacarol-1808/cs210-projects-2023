using System;

class Program
{
    static void Main(string[] args)
    {
        var assigment = new Assignment("Ana Faccinetto", "Math");
        Console.WriteLine(assigment.GetSummary());

        var mathAssignment = new MathAssignment("Guilherme Gato", "Fractionals", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        var WritingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(WritingAssignment.GetSummary());
        Console.WriteLine(WritingAssignment.GetWritingInformation());
    }
}