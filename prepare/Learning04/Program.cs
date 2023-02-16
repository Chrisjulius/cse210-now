using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment newAssign = new Assignment("Julius Ogar", "Calculus I");
        Console.WriteLine(newAssign.GetSummary());

        Console.WriteLine("");
        MathAssignment newMath = new MathAssignment("Julius Ogar", "Calculus I", "7.1", "2-10");
        Console.WriteLine(newMath.GetSummary());
        Console.WriteLine(newMath.GetHomeworkList());

        WritingAssignment newWriting = new WritingAssignment("Julius Ogar", "European History", "The causes of World War II");
        Console.WriteLine("");
        Console.WriteLine(newWriting.GetSummary());
        Console.WriteLine(newWriting.GetWritingInformation());

    }
}