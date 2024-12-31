using Hian.Extensions;
using NUnit.Framework;

public class DoubleExtensionsTests
{
    private const double DoubleTolerance = 1E-15;

    [Test]
    public void Remap_WhenCalled_ReturnsRemappedValue()
    {
        // Arrange
        double value = 5.0;
        double min1 = 0.0;
        double max1 = 10.0;
        double min2 = 0.0;
        double max2 = 100.0;

        // Act
        double result = value.Remap(min1, max1, min2, max2);

        // Assert
        Assert.AreEqual(50.0, result, DoubleTolerance);
    }

    [Test]
    public void Approx_WhenApproximatelyEqual_ReturnsTrue()
    {
        // Arrange
        double value1 = 1.0000000000000001;
        double value2 = 1.0000000000000002;

        // Act
        _ = value1.Approx(value2);

        // Assert
        Assert.That(value1, Is.EqualTo(value2).Within(DoubleTolerance));
    }

    [Test]
    public void Approx_WhenNotApproximatelyEqual_ReturnsFalse()
    {
        // Arrange
        double value1 = 1.0;
        double value2 = 1.0001;

        // Act
        bool result = value1.Approx(value2);

        // Assert
        Assert.IsFalse(result);
    }
}
