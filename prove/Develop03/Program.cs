using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //data for scripture list
        List<Scripture> scriptures = new List<Scripture>(); 
        Scripture sr1 = new Scripture("John", 3, 17, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture sr2 = new Scripture("Ether", 12, 27, "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        Scripture sr3 = new Scripture("Proverbs", 3, 5, 6, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        scriptures.Add(sr1);
        scriptures.Add(sr2);
        scriptures.Add(sr3);

        int count = 1;
        Console.Clear();
        foreach (Scripture scripture in scriptures)
        {
            Console.WriteLine($"{count} : {scripture.GetReference()}"); //creates a numbered list of scriptures in data
            count++;
        }
        Console.WriteLine("Choose a scripture to work with: ");
        int selectedScripture = int.Parse(Console.ReadLine()) - 1;
        //check if the 'selectedScripture' index is in valid range of the 'scriptures' list
        Debug.Assert(selectedScripture >= 0);
        Debug.Assert(selectedScripture < scriptures.Count);

        string input = "a";
        bool finished = false;
        while (input != "q" && !finished) //program continues to run until no more words can be hidden or when user enters 'q'
        {
            Console.Clear();
            Console.WriteLine("Press 'ENTER' to hide words. Enter 'q' to quit: ");
            scriptures[selectedScripture].ShowScripture();
            finished = scriptures[selectedScripture].Hide_words();
            if (!finished)
            {
                input = Console.ReadLine();
            }
        }
    }
}