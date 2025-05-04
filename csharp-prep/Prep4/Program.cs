using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while(userNumber != 0)
        {
            Console.Write("Enter a number (press 0 to end): ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        
        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"\nSum: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Average: {average}");

        int max = numbers[0];
        foreach(int number in numbers)
        {
            if(number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Largest number: {max}");

        //Stretch Challenges

        int min = numbers[0];
        foreach(int number in numbers)
        {
            if(number < min && number > 0)
            {
                min = number;
            }
        }
        Console.WriteLine($"Smallest positive number: {min}");

        numbers.Sort();

        Console.WriteLine("Sorted numbers: ");
        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}