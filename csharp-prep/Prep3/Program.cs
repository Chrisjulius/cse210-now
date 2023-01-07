using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int GuessNumber;
        do
        {
            Console.Write("What is your guess? ");
            GuessNumber = int.Parse(Console.ReadLine());

            if (GuessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (GuessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (GuessNumber != magicNumber);
        
        

        


    }
}