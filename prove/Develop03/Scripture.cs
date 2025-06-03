using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;    
    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new Reference(name, chapter, verse);
        _words = ConvertToWords(text);
    }
    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(name, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = ConvertToWords(text);
    }
    public bool Hide_words()
    {
        Random random = new Random();
        List<Word> unhiddenWords = _words.Where(w => !w.CheckIfHidden()).ToList();

        if (unhiddenWords.Count == 0) //If all words are hidden, program is finished
        {
            return true;
        }
        int wordsToHideCount = random.Next(4, Math.Min(6, unhiddenWords.Count + 1)); //3 to 5 words are hidden at a time
        for (int i = 0; i < wordsToHideCount; i++)
        {
            if (unhiddenWords.Count == 0) break; //no words left to hide from the unhidden list

            int indexToHide = random.Next(unhiddenWords.Count);
            unhiddenWords[indexToHide].SetIsHidden(true);
            unhiddenWords.RemoveAt(indexToHide); //prevents hidden words from being re-selected
        }
        return _words.All(w => w.CheckIfHidden());
    }
    public void ShowScripture() //shows the full scripture
    {
        Console.WriteLine(GetReference());
        foreach (Word word in _words)
        {
            word.DisplayWord();
            Console.Write(" "); //space in between words
        }
        Console.WriteLine();
    }
    public string GetReference() //uses the scripture reference string without exposing its object
    {
        return _reference.GetReference();
    }
    private List<Word> ConvertToWords(string text) //turns each word into an object
    {
        List<Word> wordList = new List<Word>();
        string[] splitWords = text.Split([' '], StringSplitOptions.RemoveEmptyEntries); 
        foreach (string s in splitWords)
        {
            wordList.Add(new Word(s));
        }
        return wordList;
    }
}