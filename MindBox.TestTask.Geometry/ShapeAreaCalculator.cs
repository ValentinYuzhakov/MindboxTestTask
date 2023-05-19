using MindBox.TestTask.Geometry.Shapes;

namespace MindBox.TestTask.Geometry;

/// <summary>
/// Калькулятор площади фигур
/// </summary>
public static class ShapeAreaCalculator
{
    /// <summary>
    /// Вычисляет площадь фигуры
    /// </summary>
    public static double Calculate(Shape shape)
    {
        return shape.CalculateArea();
    }
}
