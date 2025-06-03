using System;

public class Word
{
    //private attributes only accessible with public methods
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false; //word is not hidden by default
    }
    public bool CheckIfHidden() //Check if a word is hidden
    {
        return _hidden;
    }
    public void SetIsHidden(bool hidden) //set a word to be hidden
    {
        _hidden = hidden;
    }
    public string GetWordString() //gets the string of the now-hidden word
    {
        return _word;
    }

    public void DisplayWord() //output of hidden word string
    {
        if (_hidden)
        {
            Console.Write(new string('_', GetWordLength()));
        }
        else
        {
            Console.Write(_word);
        }
    }
    private int GetWordLength() //get number of letters in a word; not used outside of class
    {
        return _word.Length;
    }
}