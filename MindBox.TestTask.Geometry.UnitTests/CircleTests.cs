using MindBox.TestTask.Geometry.Shapes;
using System;
using Xunit;

namespace MindBox.TestTask.Geometry.UnitTests;

public sealed class CircleTests
{
    [Theory]
    [InlineData(-4)]
    [InlineData(0)]
    public void Constructor_CreateCircleWithZeroOrLessLengthRadius_Exception(double radius)
    {
        // Arrange

        // Act
        var exception = Record.Exception(() => new Circle(radius));

        // Assert
        Assert.NotNull(exception);
        Assert.IsType<ArgumentOutOfRangeException>(exception);
    }

    [Fact]
    public void Constructor_CreateCircleWithPositiveRadius_NoException()
    {
        // Arrange
        const double positiveRadius = 4;

        // Act
        var exception = Record.Exception(() => new Circle(positiveRadius));

        // Assert
        Assert.Null(exception);
    }
}
