using System;
using System.Collections.Generic;

public class Scripture
{
    // All private attributes
    private string _renderRef;
    private List<string> _passageList = new Word().Words();
    private List<int> _index = new List<int>();
    private string _clear = "______";
    public Scripture()
    {
        
    }
    public void newLine()
    {
        Console.Clear();
        Console.WriteLine($"{GetRenderRef()} {String.Join(" ", _passageList)}");
        Console.WriteLine(@"
Please enter to continue or type 'quit' to finish:
");
    }

    //Gets value from private class attributes to be returned
    public string GetRenderRef()
    {
        Reference myRef = new Reference("Proverbs", 3, 5, 6);
        _renderRef = myRef.ScriptureReference();
        return _renderRef;
    }

    //Gets value from private class attributes to be returned
    public string GetClear()
    {
        return _clear;
    }

    //Gets value from private class attributes to be returned
    public List<string> GetPassageList()
    {
        return _passageList;
    }

    //Gets value from private class attributes to be returned
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
            //enables three random words to be omitted at a go
            for (int x = 1; x < 4; x++)
            {
                int count = _index.Count;
                while (count == _index.Count)
                {
                    randomIndex = rnd.Next(0, _passageList.Count);
                    //condition set to restrict multiple selection of a random word
                    if (!(_index.Contains(randomIndex)))
                    {
                        _index.Add(randomIndex);
                        _passageList[randomIndex] = _clear;
                    } 
                }
            }
        }

        newLine();

        List<string> result = new List<string>(Enumerable.Repeat(_clear, _passageList.Count));
        if (result.SequenceEqual(_passageList))
        {
            System.Environment.Exit(0); 
        }
    }
}    