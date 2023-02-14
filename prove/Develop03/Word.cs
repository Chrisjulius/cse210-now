using System;
using System.Collections.Generic;

public class Word
{
    private string _verseLine;
    public Word()
    {
        _verseLine = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.";
    }

    public List<string> Words()
    {
        List<string> result = new List<string>(_verseLine.Split("[a-zA-Z] [a-zA-Z]"));
        return result;
    } 

}