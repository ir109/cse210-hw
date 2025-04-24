using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your first name: ");
        string name_first = Console.ReadLine();
        Console.Write("Input your last name: ");
        string name_last = Console.ReadLine();
        Console.WriteLine($"Your name is {name_last}, {name_first} {name_last}.");

        int x = 10;
        if (x == 10)
        {
            Console.WriteLine("x is 10.");
        }
    }
}