using Hian.Extensions;
using NUnit.Framework;
using UnityEngine;

/// <summary>
/// ColorExtensions 클래스의 확장 메서드에 대한 테스트를 제공합니다.
/// </summary>
[TestFixture]
public class ColorExtensionsTests
{
    /// <summary>
    /// WithR 메서드가 빨간색 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithR_SetsRedChannel_ReturnsNewColorWithRedValue()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newRedValue = 0.8f;

        // Act
        Color newColor = originalColor.WithR(newRedValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithG 메서드가 녹색 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithG_SetsGreenChannel_ReturnsNewColorWithGreenValue()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newGreenValue = 0.8f;

        // Act
        Color newColor = originalColor.WithG(newGreenValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithB 메서드가 파란색 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithB_SetsBlueChannel_ReturnsNewColorWithBlueValue()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newBlueValue = 0.8f;

        // Act
        Color newColor = originalColor.WithB(newBlueValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithA 메서드가 알파 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithA_SetsAlphaChannel_ReturnsNewColorWithAlphaValue()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newAlphaValue = 0.8f;

        // Act
        Color newColor = originalColor.WithA(newAlphaValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRG 메서드가 빨간색과 녹색 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRG_SetsRedAndGreenChannels_ReturnsNewColorWithRedAndGreenValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newRedValue = 0.8f;
        float newGreenValue = 0.9f;

        // Act
        Color newColor = originalColor.WithRG(newRedValue, newGreenValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRB 메서드가 빨간색과 파란색 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRB_SetsRedAndBlueChannels_ReturnsNewColorWithRedAndBlueValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newRedValue = 0.8f;
        float newBlueValue = 0.9f;

        // Act
        Color newColor = originalColor.WithRB(newRedValue, newBlueValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRA 메서드가 빨간색과 알파 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRA_SetsRedAndAlphaChannels_ReturnsNewColorWithRedAndAlphaValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newRedValue = 0.8f;
        float newAlphaValue = 0.9f;

        // Act
        Color newColor = originalColor.WithRA(newRedValue, newAlphaValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithGB 메서드가 녹색과 파란색 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithGB_SetsGreenAndBlueChannels_ReturnsNewColorWithGreenAndBlueValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newGreenValue = 0.8f;
        float newBlueValue = 0.9f;

        // Act
        Color newColor = originalColor.WithGB(newGreenValue, newBlueValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithGA 메서드가 녹색과 알파 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithGA_SetsGreenAndAlphaChannels_ReturnsNewColorWithGreenAndAlphaValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newGreenValue = 0.8f;
        float newAlphaValue = 0.9f;

        // Act
        Color newColor = originalColor.WithGA(newGreenValue, newAlphaValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithBA 메서드가 파란색과 알파 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithBA_SetsBlueAndAlphaChannels_ReturnsNewColorWithBlueAndAlphaValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newBlueValue = 0.8f;
        float newAlphaValue = 0.9f;

        // Act
        Color newColor = originalColor.WithBA(newBlueValue, newAlphaValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRGB 메서드가 빨간색, 녹색, 파란색 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRGB_SetsRedGreenAndBlueChannels_ReturnsNewColorWithRedGreenAndBlueValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newRedValue = 0.8f;
        float newGreenValue = 0.9f;
        float newBlueValue = 0.7f;

        // Act
        Color newColor = originalColor.WithRGB(newRedValue, newGreenValue, newBlueValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRGA 메서드가 빨간색, 녹색, 알파 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRGA_SetsRedGreenAndAlphaChannels_ReturnsNewColorWithRedGreenAndAlphaValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newRedValue = 0.8f;
        float newGreenValue = 0.9f;
        float newAlphaValue = 0.7f;

        // Act
        Color newColor = originalColor.WithRGA(newRedValue, newGreenValue, newAlphaValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRBA 메서드가 빨간색, 파란색, 알파 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRBA_SetsRedBlueAndAlphaChannels_ReturnsNewColorWithRedBlueAndAlphaValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newRedValue = 0.8f;
        float newBlueValue = 0.9f;
        float newAlphaValue = 0.7f;

        // Act
        Color newColor = originalColor.WithRBA(newRedValue, newBlueValue, newAlphaValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithGBA 메서드가 녹색, 파란색, 알파 채널을 올바르게 설정하고 새 Color를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithGBA_SetsGreenBlueAndAlphaChannels_ReturnsNewColorWithGreenBlueAndAlphaValues()
    {
        // Arrange
        Color originalColor = new Color(0.1f, 0.2f, 0.3f, 0.4f);
        float newGreenValue = 0.8f;
        float newBlueValue = 0.9f;
        float newAlphaValue = 0.7f;

        // Act
        Color newColor = originalColor.WithGBA(newGreenValue, newBlueValue, newAlphaValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }
}
