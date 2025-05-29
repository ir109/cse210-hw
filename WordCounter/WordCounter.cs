class WordCounter
{
    private List<string> _words;

    public WordCounter(string text)
    {
        _words = new List<string>();
        SplitTextIntoWords(text);
    }
    private SplitTextIntoWords(string text)
    {
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(word);
        }
    }
    public void DisplayWords()
    {
        foreach (string word in _words)
        {
            Console.Writeline(word);
        }

    }
}