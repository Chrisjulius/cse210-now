using System;
using System.Collections.Generic;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public int getFractionTop()
    {
        return _numerator;
    }

    public int getFractionBottom()
    {
        return _denominator;
    }

    public void setFraction(int top, int bottom)
    {
        _numerator = top;
        _numerator = bottom;
    }

    public string getFractionString()
    {
        string stringFrac = $"{_numerator}/{_denominator}";
        return stringFrac;
    }

    public double getDecimalValue()
    {
        return Convert.ToDouble(_numerator) / Convert.ToDouble(_denominator);
    }
}