using System;

public class Menu
{
    private Journal journal;
    private PromptGenerator promptGenerator;

    public Menu(Journal journal, PromptGenerator promptGenerator)
    {
        this.journal = journal;
        this.promptGenerator = promptGenerator;
    }
    public void Run()
    {
        string userChoice;
        do
        {
            string menu = 
$@"---- Journal Menu ----
1. Write a new entry
2. Display all entries
3. Save journal
4. Load journal
5. Clear saved journal
6. Exit
Select your choice: ";
            Console.Write(menu);
            userChoice = Console.ReadLine();
switch (userChoice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    journal.ClearJournal();
                    break;
                case "6":
                    Console.WriteLine("Closing journal. Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        } while (userChoice != "6");
    }
    private void WriteNewEntry()
    {
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Enter your thoughts: ");
        string response = Console.ReadLine();

        JournalEntry newEntry = new JournalEntry(prompt, response);
        journal.AddEntry(newEntry);
    }

}
