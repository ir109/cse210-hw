using System;

public class ReflectingActivity : Activity
{
    private List<FlaggedString> _prompts;
    private List<FlaggedString> _questions;

    public ReflectingActivity(string name, string description, int seconds)
    : base(name, description, seconds)
    {
        _prompts = new List<FlaggedString>();
        _questions = new List<FlaggedString>();
        SetPromptsAndQuestions();
    }
    public void RunActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        StartTime();

        Console.WriteLine("\nReflect on this prompt:");
        Console.WriteLine(GetPromptString(_prompts));
        DisplaySpinner("", 3);
        RunCountDown("Starting in ", 5);

        List<string> responses = new List<string>();
        while (!TimerExpired())
        {
            Console.WriteLine(GetPromptString(_questions));
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"You wrote {responses.Count} responses.");
        DisplayEnding();
        ResetPromptsUsage();
    }
    // Private methods
    private void SetPromptsAndQuestions()
    {
        _prompts.Add(new FlaggedString("Think of a time when you stood up for someone else.", false));
        _prompts.Add(new FlaggedString("Think of a time when you did something really difficult.", false));
        _prompts.Add(new FlaggedString("Think of a time when you helped someone in need.", false));
        _prompts.Add(new FlaggedString("Think of a time when you did something truly selfless.", false));

        _questions.Add(new FlaggedString("Why was this experience meaningful to you?", false));
        _questions.Add(new FlaggedString("Have you ever done anything like this before?", false));
        _questions.Add(new FlaggedString("How did you get started?", false));
        _questions.Add(new FlaggedString("How did you feel when it was complete?", false));
        _questions.Add(new FlaggedString("What made this time different than other times when you were not as successful?", false));
        _questions.Add(new FlaggedString("What is your favorite thing about this experience?", false));
        _questions.Add(new FlaggedString("What could you learn from this experience that applies to other situations?", false));
        _questions.Add(new FlaggedString("What did you learn about yourself through this experience?", false));
        _questions.Add(new FlaggedString("How can you keep this experience in mind in the future?", false));
    }
    private void ResetPromptsUsage()
    {
        foreach (var prompt in _prompts)
        {
            prompt.SetHasBeenUsed();
        }
        foreach (var question in _questions)
        {
            question.SetHasBeenUsed();
        }

    }
}
