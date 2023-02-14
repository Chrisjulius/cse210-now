using System;
using System.Collections.Generic;

public class Scripture
{
    private string _renderRef;
    private List<string> _passageList = new Word().Words();
    public Scripture()
    {
        
    }

    public string SetRenderRef()
    {
        Reference myRef = new Reference("Proverbs", 3, 5, 6);
        _renderRef = myRef.ScriptureReference();
        return _renderRef;
    }

    public void clearWords(string key)
    {
        Random rnd = new Random();

    }
}    