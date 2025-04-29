using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        if (x == 10)
        {
            Console.WriteLine("x is 10.");
        }

        Console.WriteLine("Hello, boyos.");

        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Hello, Joe. {i}");
        }
    }
}