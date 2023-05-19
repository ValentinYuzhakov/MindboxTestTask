using MindBox.TestTask.Geometry.Shapes;
using System.Collections.Generic;
using Xunit;

namespace MindBox.TestTask.Geometry.UnitTests;

public sealed class ShapeAreaCalculatorTests
{
    public static IEnumerable<object[]> Shapes =>
        new List<object[]>
        {
            new object[] { new Triangle(4, 10, 7), 10.928746497197197},
            new object[] { new Circle(4), 50.26548245743669 }
        };

    [Theory]
    [InlineData(3, 28.274333882308138)]
    public void Calculate_CircleArea_Valid(double radius, double expectedArea)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act
        var area = ShapeAreaCalculator.Calculate(circle);

        // Assert
        Assert.Equal(expectedArea, area);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    public void Calculate_TriangleArea_Valid(double a, double b,
        double c, double expectedArea)
    {
        // Arrange
        var triangle = new Triangle(a, b, c);

        // Act
        var area = ShapeAreaCalculator.Calculate(triangle);

        // Assert
        Assert.Equal(expectedArea, area);
    }

    [Theory]
    [MemberData(nameof(Shapes))]
    public void Calculate_ShapeArea_Valid(Shape shape, double expectedArea)
    {
        // Arrange

        // Act
        var area = ShapeAreaCalculator.Calculate(shape);

        // Assert
        Assert.Equal(expectedArea, area);
    }
}