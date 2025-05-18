using System;
using System.ComponentModel.Design;
using System.IO;

class Program
{
    private static void Main(string[] args) // Starts program
    {
        Journal myJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        Menu mainMenu = new Menu(myJournal, generator);

        mainMenu.Run();
    }
}