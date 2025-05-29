using System;
// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        WordCounter wordCounter = new WordCounter("This is a test sentence");
        wordCounter.DisplayWords();

        int count = wordCounter.CountSingleWord("is");
        Console.WriteLine(count);
    }
}
    
