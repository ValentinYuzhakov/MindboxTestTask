using MindBox.TestTask.Geometry.Internal;
using System;

namespace MindBox.TestTask.Geometry.Shapes;

public sealed class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        ArgumentValidation.ThrowIfZeroOrLess(radius, nameof(Radius));

        Radius = radius;
    }

    protected internal override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
