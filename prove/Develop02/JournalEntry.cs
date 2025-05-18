using System;

// Data: date, prompt, response, methods to create and display

public class JournalEntry
{

    public string _date;
    public string _prompt;
    public string _response;

    public JournalEntry(string prompt, string response) // Makes strings available for other classes 
    {
        _date = DateTime.Now.ToShortDateString();
        _prompt = prompt;
        _response = response;
    }
    public override string ToString() // Format when dislaying all entries
    {
        string outputString;
        outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }
}
