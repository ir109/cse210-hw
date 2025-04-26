using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string gradePercent = Console.ReadLine();

        string gradeLetter = "";

        int grade = int.Parse(gradePercent);
        
        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        // stretch challenge
        if (gradeLetter != "F")
        {
            int gradeModifier = grade % 10;

            if (gradeLetter == "A")
            {
                if (gradeModifier <= 2)
                {
                    gradeLetter += "-";
                }
            }
            else
            {
                if (gradeModifier >= 7)
                {
                    gradeLetter += "+";
                }
                else if (gradeModifier <=2)
                {
                    gradeLetter += "-";
                }
            }
        }

        Console.WriteLine($"\nYour grade is {gradeLetter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class :(");
        }
    }
}