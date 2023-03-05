using System;
using System.Collections.Generic;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle()
    {
        _length = 0;
        _width = 0;
    }
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length  = length;
        _width = width;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }
    public void SetLength(double length)
    {
        _length = length;
    }

    public double GetWidth()
    {
        return _width;
    }
    public double GetLength()
    {
        return _length;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}