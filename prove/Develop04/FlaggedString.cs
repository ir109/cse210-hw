using System;

public class FlaggedString 
{
    private string _prompt;
    private bool _hasBeenUsed;

    public FlaggedString(string prompt, bool hidden)
    {
        _prompt = prompt;
        _hasBeenUsed = hidden;
    }
    public string GetPrompt()
    {
        return _prompt;
    }
    public string SetHasBeenUsed()
    {
        _hasBeenUsed = true;
        return _prompt;
    }
    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }
}
