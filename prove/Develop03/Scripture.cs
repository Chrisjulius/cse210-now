using System;
using System.Collections.Generic;

public class Scripture
{
    private string _renderRef;
    private List<string> _passageList = new Word().Words();
    private List<int> _index = new List<int>();
    public Scripture()
    {
        
    }

    public string GetRenderRef()
    {
        Reference myRef = new Reference("Proverbs", 3, 5, 6);
        _renderRef = myRef.ScriptureReference();
        return _renderRef;
    }

    public string GetRenderPassage()
    {
        return String.Join(" ", _passageList);
    }
 
    public void clearWords(string key)
    {
        if (key == "")
        {
            Random rnd = new Random();
            int randomIndex;
            for (int x = 1; x < 4; x++)
            {
                int count = _index.Count;
                while (count == _index.Count)
                {
                    randomIndex = rnd.Next(0, _passageList.Count);
                    if (!(_index.Contains(randomIndex)))
                    {
                        _index.Add(randomIndex);
                        _passageList[randomIndex] = "______";
                    }
                }
            }
        }
        Console.Clear();
        Console.WriteLine(String.Join(" ", _passageList));
    }
}    