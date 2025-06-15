using System;

public class ListingActivity : Activity
{
    private List<FlaggedString> _prompts;

    public ListingActivity(string name, string description, int seconds)
    : base(name, description, seconds)
    {
        _prompts = new List<FlaggedString>();
        SetPrompts();
    }
    public void RunActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        DisplaySpinner("", 5);
        StartTime();

        Console.WriteLine("Write as many responses as you can to the following prompt:");
        string prompt = GetPromptString(_prompts);
        Console.WriteLine(prompt);
        RunCountDown("Starting in ", 5);

        List<string> responses = new List<string>();
        while (!TimerExpired())
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"You wrote {responses.Count} responses.");
        DisplayEnding();
        ResetPromptsUsage();
    }
    // Private Methods
    private void SetPrompts()
    {
        {
            _prompts.Add(new FlaggedString("Who are people that you appreciate?", false));
            _prompts.Add(new FlaggedString("What are personal strengths of yours?", false));
            _prompts.Add(new FlaggedString("Who are people that you have helped this week?", false));
            _prompts.Add(new FlaggedString("When have you felt the Holy Ghost this month?", false));
            _prompts.Add(new FlaggedString("Who are some of your personal heroes?", false));
        }
    }
    private void ResetPromptsUsage()
    {
        foreach (var prompt in _prompts)
        {
            prompt.SetHasBeenUsed();
        }
    }
}
