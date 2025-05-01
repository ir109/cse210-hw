using System;

class Program
{

    static double AddNumbers(double a, double b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        // int x = 10;
        // if (x == 10)
        // {
        //     Console.WriteLine("x is 10.");
        // }

        // Console.WriteLine("Hello, boyos.");

        // for(int i = 0; i < 20; i++)
        // {
        //     Console.WriteLine($"Hello, Joe. {i}");
        // }

        // int x = 0;
        // int y;
        // x++;
        // y = x;
        // Console.WriteLine(x);
        // Console.WriteLine(y);

        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(99);
        // myNumbers.Add(2);
        // myNumbers.Add(45);
        // myNumbers.Add(356);
        
        // foreach(int i in myNumbers)
        // {
        //     Console.WriteLine(i);

        double total = AddNumbers(123.98, 984.234);
        Console.WriteLine(total);
    }
}
