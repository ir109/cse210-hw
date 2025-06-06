using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Guy Person", "Government");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("John Smith", "Mathematics", "4.1", "81-97");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Joe Dirt", "Science", "The Big Bang");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}