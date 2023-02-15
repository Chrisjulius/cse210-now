using System;
using System.Collections.Generic;

public class Scripture
{
    private string _renderRef;
    private List<string> _passageList = new Word().Words();
    private List<int> _index = new List<int>();
    private string _clear = "______";
    public Scripture()
    {
        
    }

    public string GetRenderRef()
    {
        Reference myRef = new Reference("Proverbs", 3, 5, 6);
        _renderRef = myRef.ScriptureReference();
        return _renderRef;
    }

    public string GetClear()
    {
        return _clear;
    }

    public List<string> GetPassageList()
    {
        return _passageList;
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
                        _passageList[randomIndex] = _clear;
                    }
                }
            }
        }

        var result = new List<string>(Enumerable.Repeat(_clear, _passageList.Count));
        if (result == _passageList)
        {
            System.Environment.Exit(0); 
        }

        newLine();
    }

    private void newLine()
    {
        Console.Clear();
        Console.WriteLine($"{_renderRef} {String.Join(" ", _passageList)}");
        Console.WriteLine(@"
Please enter to continue or type 'quit' to finish:
");
    }
}    