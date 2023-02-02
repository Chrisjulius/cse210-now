using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFrac = new Fraction();
        Fraction secondFrac = new Fraction(6);
        Fraction thirdFrac = new Fraction(6, 7);

        Console.WriteLine(firstFrac.getFractionString());
        Console.WriteLine(firstFrac.getDecimalValue());

        Console.WriteLine(secondFrac.getFractionString());
        Console.WriteLine(secondFrac.getDecimalValue());

        Console.WriteLine(thirdFrac.getDecimalValue());
        Console.WriteLine(thirdFrac.getFractionString());

        thirdFrac.setFraction(3, 4);
        Console.WriteLine(thirdFrac.getDecimalValue());
        Console.WriteLine(thirdFrac.getFractionString());

        thirdFrac.setFraction(1, 3);
        Console.WriteLine(thirdFrac.getDecimalValue());
        Console.WriteLine(thirdFrac.getFractionString());

        secondFrac.setFraction(5, 1);
        Console.WriteLine(secondFrac.getDecimalValue());
        Console.WriteLine(secondFrac.getFractionString());
    }
}