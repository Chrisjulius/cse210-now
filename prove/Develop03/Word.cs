using System;
using System.Collections.Generic;

//Holds my scripture passage to memorize
public class Word
{
    private string _verseLine;
    private List<string> _listVerseLine;
    public Word()
    {
        _verseLine = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.";
        _listVerseLine = Words();
    }

    public List<string> Words() //convert scripture verse to a list (used by Scripture class)
    {
        List<string> result = new List<string>(_verseLine.Split(" "));
        return result;
    } 

}