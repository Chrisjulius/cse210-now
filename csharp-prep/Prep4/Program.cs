using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int listNumber = -1;
        List<int> myList = new List<int>();

        Console.WriteLine("Enter a list of number: type 0 to stop");

        while (listNumber != 0)
        {
            Console.Write("Enter a number: ");
            listNumber = int.Parse(Console.ReadLine());
            if (listNumber != 0)
            {
                myList.Add(listNumber);
            }
        }

        int listSum = 0;

        for (int countList = 0; countList < myList.Count; countList++)
        {
            listSum += myList[countList];
        }
        Console.WriteLine($"The sum is: {listSum}.");

        float listAverage = ((float) listSum) / myList.Count;

        Console.WriteLine($"The average is: {listAverage}.");

        int maxNum = myList[0];
        foreach (int checkList in myList)
        {
            if (maxNum < checkList)
            {
                maxNum = checkList;
            }
        }

        Console.WriteLine($"The maximum number is: {maxNum}.");
    }
}