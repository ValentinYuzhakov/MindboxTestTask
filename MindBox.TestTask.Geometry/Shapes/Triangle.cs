using MindBox.TestTask.Geometry.Internal;
using System;

namespace MindBox.TestTask.Geometry.Shapes;

public sealed class Triangle : Shape
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        ArgumentValidation.ThrowIfZeroOrLess(a, nameof(A));
        ArgumentValidation.ThrowIfZeroOrLess(b, nameof(B));
        ArgumentValidation.ThrowIfZeroOrLess(c, nameof(C));

        ValidateSidesLength(a, b, c);

        A = a;
        B = b;
        C = c;
    }

    public bool IsRight()
    {
        return PythagoreanTheoremFormula(A, B, C) ||
               PythagoreanTheoremFormula(A, C, B) ||
               PythagoreanTheoremFormula(C, B, A);
    }

    protected internal override double CalculateArea()
    {
        return HeronFormula(A, B, C);
    }

    private static double HeronFormula(double a, double b, double c)
    {
        var semiPerimeter = (a + b + c) / 2;

        return Math.Sqrt(semiPerimeter * ((semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c)));
    }

    private static bool PythagoreanTheoremFormula(double a, double b, double c)
    {
        return Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2);
    }

    private static void ValidateSidesLength(double a, double b, double c)
    {
        if (a > b + c || b > a + c || c > a + b)
            throw new ArgumentException("Any side of a triangle must be less than the sum of the other two sides");
    }
}
