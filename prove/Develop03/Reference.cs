using System;
using System.Linq;

public class Reference
{
    //data for scripture verse(s)
    private string _book;
    private int _chapter;
    private int[] _verse;
    
    public Reference(string name, int chapter, int verse) //for scriptures with one verse
    {
        _book = name;
        _chapter = chapter;
        _verse = [verse]; 
    }
    public Reference(string name, int chapter, int startVerse, int endVerse) //for scriptures with multiple verses
    {
        _book = name;
        _chapter = chapter;
        _verse = Enumerable.Range(startVerse, endVerse - startVerse + 1).ToArray();
    }
    
    public void ShowReference() //display the scripture reference
    {
        Console.WriteLine(GetReferenceString());
    }
    public string GetReference() //allows external use of the reference string
    {
        return GetReferenceString();
    }
    private string GetReferenceString() //formats reference string
    {
        string verseString;
        if (_verse.Length == 1)
        {
            verseString = _verse[0].ToString(); //for single verses
        }
        else
        {
            verseString = $"{_verse.First()}-{_verse.Last()}"; //for multiple verses
        }
        return $"{_book} {_chapter}:{verseString}";
    }
}
