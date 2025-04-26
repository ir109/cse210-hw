using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradePercent = Console.ReadLine();

        int grade = int.Parse(gradePercent);
        
        if (grade >= 90)
        {
            Console.WriteLine("You got an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("You got a B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("You got a C. You passed the class!");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("You got a D. You did not pass the class. :(");
        }
        else
        {
            Console.WriteLine("You failed the class. :(");
        }
    }
}