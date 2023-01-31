using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Journal
{
    public Journal()
    {
         
    }
    public List<Entry> listEntry = new List<Entry>();
    public string _file = "";
    public void CollectEntries()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.RandomPrompt();
        Console.Write(prompt);
        string userEntry = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        listEntry.Add(new Entry(prompt, userEntry, dateText));

    }

    public void Write()
    {
        StringBuilder output = new StringBuilder();

        foreach (var enter in listEntry)
        {
            List<string> newLine = new List<string>() {enter.Prompt, enter.UserEntry, enter.EntryDate};
            output.AppendLine(string.Join(" --- ", newLine));
            try
            {
                File.AppendAllText(_file, output.ToString());
            }
            catch(Exception e)
            {
                Console.WriteLine("Data could not be written to CSV file");
            }

            Console.WriteLine("Successfully done!");
        }
    }
}
