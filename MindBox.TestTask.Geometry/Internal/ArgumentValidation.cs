using System;

namespace MindBox.TestTask.Geometry.Internal;

internal sealed class ArgumentValidation
{
    public static void ThrowIfZeroOrLess(double value, string fieldName)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException($"'{fieldName}' cannot be zero or less than zero");
    }
}
