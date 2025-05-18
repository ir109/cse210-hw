using System;
// Selects random prompt from array
public class PromptGenerator
{
    private string[] _prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private static Random random = new Random();

    public string GetPrompt()
    {
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}
        