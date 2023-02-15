using System;
using System.Collections.Generic;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd = 0;

    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd) // Constructor to accomodate multiple verse scripture passage
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

// public method to render scripture references according to verse type (single or multiple)
    public string ScriptureReference()
    {
        string reference = "";

        if (_verseEnd == 0)
        {
            reference = $"{_book} {_chapter}:{_verseStart}";
            return reference;
        }
        else
        {
            reference = $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
            return reference;    
        }
    }
}