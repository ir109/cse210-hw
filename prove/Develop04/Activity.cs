using System;
//all common code will be in this class
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _endTime;

    public Activity(string name, string description, int seconds)
    {
        _name = name;
        _description = description;
        _duration = seconds;
    }
    public void DisplayGreeting()
    {
        Console.WriteLine($"{_name}");
    }
    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
    public void DisplayEnding()
    {
        Console.WriteLine($"You completed the {_name} in {_duration} seconds.");
        DisplaySpinner("", 3);
    }
    public void RunCountDown(string message, int seconds)
    {
        Console.WriteLine(message);
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b");
            if (i > 10) Console.Write("\b\b");
        }
        Console.WriteLine();
    }
    public void DisplaySpinner(string message, int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }
    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }
    public bool TimerExpired()
    {
        return DateTime.Now >= _endTime;
    }
    public void ObtainDuration()
    {
        Console.Write("How many seconds do you want with this activity? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public string GetPromptString(List<FlaggedString> list)
    {
        foreach (var prompt in list)
        {
            if (!prompt.GetHasBeenUsed())
            {
                return prompt.SetHasBeenUsed();
            }
        }
        return "No new prompts.";
    }
}
