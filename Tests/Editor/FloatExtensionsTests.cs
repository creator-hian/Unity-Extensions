using Hian.Extensions;
using NUnit.Framework;

public class FloatExtensionsTests
{
    private const float FloatTolerance = 1e-4f;

    [Test]
    public void Remap_WhenCalled_ReturnsRemappedValue()
    {
        // Arrange
        float value = 5f;
        float min1 = 0f;
        float max1 = 10f;
        float min2 = 0f;
        float max2 = 100f;

        // Act
        float result = value.Remap(min1, max1, min2, max2);

        // Assert
        Assert.AreEqual(50f, result, FloatTolerance);
    }

    [Test]
    public void Approx_WhenApproximatelyEqual_ReturnsTrue()
    {
        // Arrange
        float value1 = 1.00001f;
        float value2 = 1.00002f;

        // Act
        _ = value1.Approx(value2);

        // Assert
        Assert.That(value1, Is.EqualTo(value2).Within(FloatTolerance));
    }

    [Test]
    public void Approx_WhenNotApproximatelyEqual_ReturnsFalse()
    {
        // Arrange
        float value1 = 1.00001f;
        float value2 = 1.0001f;

        // Act
        bool result = value1.Approx(value2);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void WithRandomSign_WhenCalled_ReturnsValueWithRandomSign()
    {
        // Arrange
        float value = 1f;

        // Act
        float result = value.WithRandomSign();

        // Assert
        Assert.IsTrue(result is 1f or (-1f));
    }
}
