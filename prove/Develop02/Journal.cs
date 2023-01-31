using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Journal
{
    public Journal()
    {
         
    }

    public string _saveFile = "";
    public string _loadFile = "";

    public void Write(List<string> myEntry)
    {
        string fileName = _saveFile;
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string item in myEntry)
            {
                outputFile.WriteLine(item);
            }  
        }
    }

    public void
}
