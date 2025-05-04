using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        string replay = "y";

        while(replay == "y")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guessCount = 0;
            int guess = -1;
            while(guess != number)
            {
                Console.Write("Guess the number: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You got it in {guessCount} guesses!");
                }
            }
            Console.Write("Do you want to play again? y/n: ");
            replay = Console.ReadLine();  
        }
        Console.WriteLine("Thanks for playing! Here's a cookie! (There are no cookies)");
    }
}