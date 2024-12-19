using System;
using System.Globalization;
using Hian.Extensions;
using NUnit.Framework;

public class DateTimeExtensionsTests
{
    [Test]
    public void GetTodayAbbreviatedDayName_DefaultCulture_ReturnsCorrectValue()
    {
        // Arrange
        var expected = DateTime.Today.ToString("ddd", new CultureInfo("en-us"));

        // Act
        var actual = DateTimeExtensions.GetTodayAbbreviatedDayName();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetTodayAbbreviatedDayName_SpecificCulture_ReturnsCorrectValue()
    {
        // Arrange
        var expected = DateTime.Today.ToString("ddd", new CultureInfo("ko-kr"));

        // Act
        var actual = DateTimeExtensions.GetTodayAbbreviatedDayName("ko-kr");

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetTodayAbbreviatedDayName_NullCulture_ReturnsDefaultCultureValue()
    {
        // Arrange
        var expected = DateTime.Today.ToString("ddd", new CultureInfo("en-us"));

        // Act
        var actual = DateTimeExtensions.GetTodayAbbreviatedDayName(null);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetTodayDayName_DefaultCulture_ReturnsCorrectValue()
    {
        // Arrange
        var expected = DateTime.Today.ToString("dddd", new CultureInfo("en-us"));

        // Act
        var actual = DateTimeExtensions.GetTodayDayName();

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetTodayDayName_SpecificCulture_ReturnsCorrectValue()
    {
        // Arrange
        var expected = DateTime.Today.ToString("dddd", new CultureInfo("ko-kr"));

        // Act
        var actual = DateTimeExtensions.GetTodayDayName("ko-kr");

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetTodayDayName_NullCulture_ReturnsDefaultCultureValue()
    {
        // Arrange
        var expected = DateTime.Today.ToString("dddd", new CultureInfo("en-us"));

        // Act
        var actual = DateTimeExtensions.GetTodayDayName(null);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void IsAbbreviatedDayName_ValidName_ReturnsTrue()
    {
        // Arrange
        var dayName = DateTime.Today.ToString("ddd", new CultureInfo("en-us"));

        // Act
        var result = DateTimeExtensions.IsAbbreviatedDayName(dayName);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsAbbreviatedDayName_InvalidName_ReturnsFalse()
    {
        // Act
        var result = DateTimeExtensions.IsAbbreviatedDayName("InvalidDayName");

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void IsAbbreviatedDayName_NullCulture_ReturnsDefaultCultureValue()
    {
        // Arrange
        var dayName = DateTime.Today.ToString("ddd", new CultureInfo("en-us"));

        // Act
        var result = DateTimeExtensions.IsAbbreviatedDayName(dayName, null);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsDayName_ValidName_ReturnsTrue()
    {
        // Arrange
        var dayName = DateTime.Today.ToString("dddd", new CultureInfo("en-us"));

        // Act
        var result = DateTimeExtensions.IsDayName(dayName);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void IsDayName_InvalidName_ReturnsFalse()
    {
        // Act
        var result = DateTimeExtensions.IsDayName("InvalidDayName");

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void IsDayName_NullCulture_ReturnsDefaultCultureValue()
    {
        // Arrange
        var dayName = DateTime.Today.ToString("dddd", new CultureInfo("en-us"));

        // Act
        var result = DateTimeExtensions.IsDayName(dayName, null);

        // Assert
        Assert.IsTrue(result);
    }
}
