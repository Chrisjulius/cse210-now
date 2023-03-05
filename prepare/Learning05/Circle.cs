using System;
using System.Collections.Generic;

public class Circle : Shape
{
    private double _radius;

    public Circle()
    {
        _radius = 0;
    }
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }

    public override double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }

}