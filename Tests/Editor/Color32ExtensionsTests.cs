using Hian.Extensions;
using NUnit.Framework;
using UnityEngine;

/// <summary>
/// Color32Extensions 클래스의 확장 메서드에 대한 테스트를 제공합니다.
/// </summary>
[TestFixture]
public class Color32ExtensionsTests
{
    /// <summary>
    /// WithR 메서드가 빨간색 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithR_SetsRedChannel_ReturnsNewColor32WithRedValue()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newRedValue = 80;

        // Act
        Color32 newColor = originalColor.WithR(newRedValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithG 메서드가 녹색 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithG_SetsGreenChannel_ReturnsNewColor32WithGreenValue()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newGreenValue = 80;

        // Act
        Color32 newColor = originalColor.WithG(newGreenValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithB 메서드가 파란색 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithB_SetsBlueChannel_ReturnsNewColor32WithBlueValue()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newBlueValue = 80;

        // Act
        Color32 newColor = originalColor.WithB(newBlueValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithA 메서드가 알파 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithA_SetsAlphaChannel_ReturnsNewColor32WithAlphaValue()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newAlphaValue = 80;

        // Act
        Color32 newColor = originalColor.WithA(newAlphaValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRG 메서드가 빨간색과 녹색 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRG_SetsRedAndGreenChannels_ReturnsNewColor32WithRedAndGreenValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newRedValue = 80;
        byte newGreenValue = 90;

        // Act
        Color32 newColor = originalColor.WithRG(newRedValue, newGreenValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRB 메서드가 빨간색과 파란색 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRB_SetsRedAndBlueChannels_ReturnsNewColor32WithRedAndBlueValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newRedValue = 80;
        byte newBlueValue = 90;

        // Act
        Color32 newColor = originalColor.WithRB(newRedValue, newBlueValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRA 메서드가 빨간색과 알파 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRA_SetsRedAndAlphaChannels_ReturnsNewColor32WithRedAndAlphaValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newRedValue = 80;
        byte newAlphaValue = 90;

        // Act
        Color32 newColor = originalColor.WithRA(newRedValue, newAlphaValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithGB 메서드가 녹색과 파란색 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithGB_SetsGreenAndBlueChannels_ReturnsNewColor32WithGreenAndBlueValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newGreenValue = 80;
        byte newBlueValue = 90;

        // Act
        Color32 newColor = originalColor.WithGB(newGreenValue, newBlueValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithGA 메서드가 녹색과 알파 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithGA_SetsGreenAndAlphaChannels_ReturnsNewColor32WithGreenAndAlphaValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newGreenValue = 80;
        byte newAlphaValue = 90;

        // Act
        Color32 newColor = originalColor.WithGA(newGreenValue, newAlphaValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithBA 메서드가 파란색과 알파 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithBA_SetsBlueAndAlphaChannels_ReturnsNewColor32WithBlueAndAlphaValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newBlueValue = 80;
        byte newAlphaValue = 90;

        // Act
        Color32 newColor = originalColor.WithBA(newBlueValue, newAlphaValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRGB 메서드가 빨간색, 녹색, 파란색 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRGB_SetsRedGreenAndBlueChannels_ReturnsNewColor32WithRedGreenAndBlueValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newRedValue = 80;
        byte newGreenValue = 90;
        byte newBlueValue = 70;

        // Act
        Color32 newColor = originalColor.WithRGB(newRedValue, newGreenValue, newBlueValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(originalColor.a, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRGA 메서드가 빨간색, 녹색, 알파 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRGA_SetsRedGreenAndAlphaChannels_ReturnsNewColor32WithRedGreenAndAlphaValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newRedValue = 80;
        byte newGreenValue = 90;
        byte newAlphaValue = 70;

        // Act
        Color32 newColor = originalColor.WithRGA(newRedValue, newGreenValue, newAlphaValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(originalColor.b, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithRBA 메서드가 빨간색, 파란색, 알파 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithRBA_SetsRedBlueAndAlphaChannels_ReturnsNewColor32WithRedBlueAndAlphaValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newRedValue = 80;
        byte newBlueValue = 90;
        byte newAlphaValue = 70;

        // Act
        Color32 newColor = originalColor.WithRBA(newRedValue, newBlueValue, newAlphaValue);

        // Assert
        Assert.AreEqual(newRedValue, newColor.r);
        Assert.AreEqual(originalColor.g, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }

    /// <summary>
    /// WithGBA 메서드가 녹색, 파란색, 알파 채널을 올바르게 설정하고 새 Color32를 반환하는지 테스트합니다.
    /// </summary>
    [Test]
    public void WithGBA_SetsGreenBlueAndAlphaChannels_ReturnsNewColor32WithGreenBlueAndAlphaValues()
    {
        // Arrange
        Color32 originalColor = new Color32(10, 20, 30, 40);
        byte newGreenValue = 80;
        byte newBlueValue = 90;
        byte newAlphaValue = 70;

        // Act
        Color32 newColor = originalColor.WithGBA(newGreenValue, newBlueValue, newAlphaValue);

        // Assert
        Assert.AreEqual(originalColor.r, newColor.r);
        Assert.AreEqual(newGreenValue, newColor.g);
        Assert.AreEqual(newBlueValue, newColor.b);
        Assert.AreEqual(newAlphaValue, newColor.a);
        Assert.AreNotEqual(originalColor, newColor); // 불변성 검증
    }
}
