using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
// Has data attibutes -entries, has actions: save, load, display
public class Journal
{
    public List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("\nThere are currently no entries to display\n");
            return;
        }
        foreach (JournalEntry entry in entries)
            {
                Console.WriteLine(entry); // from JournalEntry; ToString()
                Console.WriteLine("#");
            }
        Console.WriteLine("End of journal\n");
    }
    public void SaveToFile(string filename = "journal.txt")
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in entries)
                //defines format for entries
                outputFile.WriteLine(entry.ToString());
        }
        Console.WriteLine($"\nJournal has been saved to {filename}\n");
    }
    public void LoadFromFile(string filename = "journal.txt")
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('#');
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    JournalEntry entry = new JournalEntry(prompt, response) { _date = date };
                    entries.Add(entry);
                }
                else
                {
                    Console.WriteLine($"\nSkipping invalid line in file: {line}\n");
                }
            }
            Console.WriteLine($"\nJournal loaded from {filename}\n");
        }
        else
        {
            Console.WriteLine($"\nFile '{filename}' not found\n");
        }
    }
    public void ClearJournal()
    {
        Console.WriteLine("Are you sure you want to clear this journal? \n1. Yes. Clear the journal \n2. No. Go back to the main menu ");
        string confirm = Console.ReadLine();
        {
            if (confirm == "1")
            {
                entries.Clear();
                Console.WriteLine("Journal has been cleared");
            }
            else if (confirm == "2")
            {
                Console.WriteLine("Returning to menu");
            }
            else
            {
                Console.WriteLine("Unknown input. Returning to menu");
            }
        } 
    }   
}    