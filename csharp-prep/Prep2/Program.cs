using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage?: ");
        string grade_percentage = Console.ReadLine();

        string letter="";
        string sign="";

        if (int.Parse(grade_percentage) >= 90)
        {
           letter = "A";
        }
        else if (int.Parse(grade_percentage) >= 80)
        {
            letter = "B";
        }
        else if (int.Parse(grade_percentage) >= 70)
        {
            letter = "C";
        }
        else if (int.Parse(grade_percentage)>=60)
        {
            letter = "D";
        }
        else if (int.Parse(grade_percentage) < 60)
        {
            letter = "F";
        }

        if (int.Parse(grade_percentage) % 10 >= 7 )
        {
            sign = "+";
        }
        else if (int.Parse(grade_percentage) % 10 < 3)
        {
            sign = "-";
        }

        else 
        {
            sign = "";
        }

        if (letter == "A" && sign == "+" || letter == "F" && sign == "+" || letter == "F" && sign == "-")
        {
            Console.Write("");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"That is a/an {letter}{sign}");
        }

        if (int.Parse(grade_percentage) >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }

        else
        {
            Console.WriteLine("Try again. You'll do better");
        }

        
    }
}