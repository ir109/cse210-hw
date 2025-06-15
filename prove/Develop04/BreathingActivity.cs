using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int seconds)
    : base(name, description, seconds){}

    public void RunActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        ObtainDuration();
        DisplaySpinner("", 5);
        StartTime();

        while (!TimerExpired())
        {
            RunCountDown("Breathe in...", 4);
            RunCountDown("Breathe out...", 6);
        }

        DisplayEnding();
    }
}
