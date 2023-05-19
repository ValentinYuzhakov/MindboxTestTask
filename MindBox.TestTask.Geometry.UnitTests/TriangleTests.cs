using MindBox.TestTask.Geometry.Shapes;
using System;
using Xunit;

namespace MindBox.TestTask.Geometry.UnitTests;

public sealed class TriangleTests
{
    [Theory]
    [InlineData(-4, 3, 4)]
    [InlineData(4, -3, 4)]
    [InlineData(4, 3, -4)]
    [InlineData(0, 3, 4)]
    [InlineData(4, 0, 4)]
    [InlineData(4, 3, 0)]
    public void Constructor_CreateTriangleWithZeroOrLessLengthSides_Exception(double a, double b, double c)
    {
        // Arrange

        // Act
        var exception = Record.Exception(() => new Triangle(a, b, c));

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<ArgumentOutOfRangeException>(exception);
    }

    [Theory]
    [InlineData(4, 3, 4)]
    public void Constructor_CreateTriangleWithPositiveSides_NoException(double a, double b, double c)
    {
        // Arrange

        // Act
        var exception = Record.Exception(() => new Triangle(a, b, c));

        // Assert
        Assert.Null(exception);
    }

    [Fact]
    public void IsRight_RightTriangle_True()
    {
        // Arrange
        var triangle = new Triangle(6, 8, 10);

        // Act
        var isRight = triangle.IsRight();

        // Assert
        Assert.True(isRight);
    }

    [Fact]
    public void IsRight_NotRightTriangle_False()
    {
        // Arrange
        var triangle = new Triangle(1, 5, 6);

        // Act
        var isRight = triangle.IsRight();

        // Assert
        Assert.False(isRight);
    }
}
