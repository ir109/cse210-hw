using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquaredNumber(userNumber);
        DisplayResults(userName, squaredNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome.");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquaredNumber(int number)
        {
            int square = number * number;
            return square;
        }
        static void DisplayResults(string name, int square)
        {
            Console.WriteLine($"{name}, Your number squared is {square}.");
        }
    }
}