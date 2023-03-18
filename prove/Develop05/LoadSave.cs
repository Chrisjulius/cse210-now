using System;
using System.Collections.Generic;
using System.IO;

public class LoadSave
{
    private int _totalScore;
    private string _fileName;

    public LoadSave()
    {
        _totalScore = 0;
        _fileName = "";
    }

    public void AddScore(int score)
    {
        _totalScore += score;
    }
    public int GetTotalScore()
    {
        return _totalScore;
    }

    public void WriteGoal(List<string> listGoal)
    {
        Console.Write("What is the filename for the goal file (.txt)? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{_totalScore}");
            
            foreach (string goal in listGoal)
            {
                outputFile.WriteLine("");
            }
        }
    }
}