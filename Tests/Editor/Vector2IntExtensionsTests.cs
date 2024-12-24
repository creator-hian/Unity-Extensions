using System;
using Hian.Extensions;
using NUnit.Framework;
using UnityEngine;

public class Vector2IntExtensionsTests
{
    #region With

    /// <summary>
    /// Vector2Int.With() 메서드가 지정된 축의 값을 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void With_WhenCalled_UpdatesSpecifiedAxisValue()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 1);

        // Act
        Vector2Int resultX = vector.With(0, 2);
        Vector2Int resultY = vector.With(1, 3);

        // Assert
        Assert.AreEqual(2, resultX.x);
        Assert.AreEqual(1, resultX.y);
        Assert.AreEqual(1, resultY.x);
        Assert.AreEqual(3, resultY.y);
    }

    /// <summary>
    /// Vector2Int.With() 메서드에 잘못된 축 인덱스를 전달하면 ArgumentOutOfRangeException이 발생하는지 검증합니다.
    /// </summary>
    [Test]
    public void With_WhenCalledWithInvalidAxis_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 1);

        // Act & Assert
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => vector.With(2, 2));
    }

    /// <summary>
    /// Vector2Int.WithXY() 메서드가 x와 y 값을 모두 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithXY_WhenCalled_UpdatesXAndYValues()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 1);

        // Act
        Vector2Int result = vector.WithXY(2, 3);

        // Assert
        Assert.AreEqual(2, result.x);
        Assert.AreEqual(3, result.y);
    }

    #endregion

    #region Negate

    /// <summary>
    /// Vector2Int.WithNegate() 메서드가 지정된 축의 값을 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegate_WhenCalled_NegatesSpecifiedAxisValue()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector2Int resultX = vector.WithNegate(0);
        Vector2Int resultY = vector.WithNegate(1);

        // Assert
        Assert.AreEqual(-1, resultX.x);
        Assert.AreEqual(2, resultX.y);
        Assert.AreEqual(1, resultY.x);
        Assert.AreEqual(-2, resultY.y);
    }

    /// <summary>
    /// Vector2Int.WithNegateX() 메서드가 x 값을 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateX_WhenCalled_NegatesXValue()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector2Int result = vector.WithNegateX();

        // Assert
        Assert.AreEqual(-1, result.x);
        Assert.AreEqual(2, result.y);
    }

    /// <summary>
    /// Vector2Int.WithNegateY() 메서드가 y 값을 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateY_WhenCalled_NegatesYValue()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector2Int result = vector.WithNegateY();

        // Assert
        Assert.AreEqual(1, result.x);
        Assert.AreEqual(-2, result.y);
    }

    /// <summary>
    /// Vector2Int.Negate() 메서드가 모든 컴포넌트를 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void Negate_WhenCalled_NegatesAllComponents()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector2Int result = vector.Negate();

        // Assert
        Assert.AreEqual(-1, result.x);
        Assert.AreEqual(-2, result.y);
    }

    #endregion

    #region Min, Max

    /// <summary>
    /// Vector2Int.MaxComponent() 메서드가 가장 큰 컴포넌트의 인덱스와 값을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void MaxComponent_WhenCalled_ReturnsIndexOfMaxValue()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        (int index, int value) = vector.MaxComponent();

        // Assert
        Assert.AreEqual(1, index);
        Assert.AreEqual(2, value);
    }

    /// <summary>
    /// Vector2Int.MinComponent() 메서드가 가장 작은 컴포넌트의 인덱스와 값을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void MinComponent_WhenCalled_ReturnsIndexOfMinValue()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        (int index, int value) = vector.MinComponent();

        // Assert
        Assert.AreEqual(0, index);
        Assert.AreEqual(1, value);
    }

    #endregion

    #region Divide, IsUniform

    /// <summary>
    /// Vector2Int.Divide() 메서드가 모든 성분을 다른 벡터로 나누는지 검증합니다.
    /// </summary>
    [Test]
    public void Divide_WhenCalled_DividesAllComponentsByOtherVector()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(4, 2);
        Vector2Int other = new Vector2Int(2, 2);

        // Act
        Vector2Int result = vector.Divide(other);

        // Assert
        Assert.AreEqual(2, result.x);
        Assert.AreEqual(1, result.y);
    }

    /// <summary>
    /// Vector2Int.IsUniform() 메서드가 모든 성분이 같은지 여부를 올바르게 반환하는지 검증합니다.
    /// </summary>
    [TestCase(1, 1, true)]
    [TestCase(1, 2, false)]
    public void IsUniform_WhenCalled_ReturnsCorrectResult(int x, int y, bool expected)
    {
        // Arrange
        Vector2Int vector = new Vector2Int(x, y);

        // Act
        bool result = vector.IsUniform();

        // Assert
        Assert.AreEqual(expected, result);
    }

    #endregion

    #region Dot, Cross

    /// <summary>
    /// Vector2Int.Dot() 메서드가 내적을 정확하게 계산하는지 검증합니다.
    /// </summary>
    [Test]
    public void Dot_WhenCalled_CalculatesDotProductCorrectly()
    {
        // Arrange
        Vector2Int vector1 = new Vector2Int(1, 2);
        Vector2Int vector2 = new Vector2Int(3, 4);

        // Act
        int result = vector1.Dot(vector2);

        // Assert
        Assert.AreEqual(11, result);
    }

    /// <summary>
    /// Vector2Int.Cross() 메서드가 외적을 정확하게 계산하는지 검증합니다.
    /// </summary>
    [Test]
    public void Cross_WhenCalled_CalculatesCrossProductCorrectly()
    {
        // Arrange
        Vector2Int vector1 = new Vector2Int(1, 2);
        Vector2Int vector2 = new Vector2Int(3, 4);

        // Act
        int result = vector1.Cross(vector2);

        // Assert
        Assert.AreEqual(-2, result);
    }

    #endregion

    #region GetClosestPoint, GetClosestPointOnRay, GetClosestPointOnSegment

    /// <summary>
    /// Vector2Int.GetClosestPoint() 메서드가 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPoint_WhenCalled_ReturnsClosestPointInfo()
    {
        // Arrange
        Vector2Int point = new Vector2Int(0, 0);
        Vector2Int[] points = new[]
        {
            new Vector2Int(1, 1),
            new Vector2Int(2, 2),
            new Vector2Int(3, 3),
        };

        // Act
        (Vector2Int closestPoint, int index) = point.GetClosestPoint(points);

        // Assert
        Assert.AreEqual(new Vector2Int(1, 1), closestPoint);
        Assert.AreEqual(0, index);
    }

    /// <summary>
    /// Vector2Int.GetClosestPointOnRay() 메서드가 광선(Ray) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPointOnRay_WhenCalled_ReturnsClosestPointInfoOnRay()
    {
        // Arrange
        Vector2Int point = new Vector2Int(2, 2);
        Vector2 origin = new Vector2(0f, 0f);
        Vector2 direction = new Vector2(1f, 0f).normalized;

        // Act
        (Vector2 closestPoint, float distance) = point.GetClosestPointOnRay(origin, direction);

        // Assert
        Assert.AreEqual(new Vector2(2, 0), closestPoint);
        Assert.AreEqual(2f, distance);
    }

    /// <summary>
    /// Vector2Int.GetClosestPointOnSegment() 메서드가 선분(Line Segment) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPointOnSegment_WhenCalled_ReturnsClosestPointInfoOnSegment()
    {
        // Arrange
        Vector2Int point = new Vector2Int(2, 2);
        Vector2Int start = new Vector2Int(0, 0);
        Vector2Int end = new Vector2Int(4, 0);

        // Act
        (Vector2 closestPoint, float distance) = point.GetClosestPointOnSegment(start, end);

        // Assert
        Assert.AreEqual(new Vector2(2, 0), closestPoint);
        Assert.AreEqual(2f, distance);
    }

    #endregion

    #region Insert

    /// <summary>
    /// Vector2Int.InsertX() 메서드가 x 축에 값을 삽입하고 벡터를 3차원으로 확장하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertX_WhenCalled_Returns3DVectorWithInsertedX()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector3Int result = vector.InsertX(3);

        // Assert
        Assert.AreEqual(3, result.x);
        Assert.AreEqual(1, result.y);
        Assert.AreEqual(2, result.z);
    }

    /// <summary>
    /// Vector2Int.InsertY() 메서드가 y 축에 값을 삽입하고 벡터를 3차원으로 확장하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertY_WhenCalled_Returns3DVectorWithInsertedY()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector3Int result = vector.InsertY(3);

        // Assert
        Assert.AreEqual(1, result.x);
        Assert.AreEqual(3, result.y);
        Assert.AreEqual(2, result.z);
    }

    /// <summary>
    /// Vector2Int.InsertZ() 메서드가 z 축에 값을 삽입하고 벡터를 3차원으로 확장하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertZ_WhenCalled_Returns3DVectorWithInsertedZ()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector3Int result = vector.InsertZ(3);

        // Assert
        Assert.AreEqual(1, result.x);
        Assert.AreEqual(2, result.y);
        Assert.AreEqual(3, result.z);
    }

    #endregion

    #region ToVector

    /// <summary>
    /// Vector2Int.ToVector2() 메서드가 Vector2Int를 Vector2로 변환하는지 검증합니다.
    /// </summary>
    [Test]
    public void ToVector2_WhenCalled_ReturnsVector2()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector2 result = vector.ToVector2();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
    }

    /// <summary>
    /// Vector2Int.ToVector3Int() 메서드가 Vector2Int를 Vector3Int로 변환하는지 검증합니다.
    /// </summary>
    [Test]
    public void ToVector3Int_WhenCalled_ReturnsVector3Int()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector3Int result = vector.ToVector3Int();

        // Assert
        Assert.AreEqual(1, result.x);
        Assert.AreEqual(2, result.y);
        Assert.AreEqual(0, result.z);
    }

    /// <summary>
    /// Vector2Int.ToVector3() 메서드가 Vector2Int를 Vector3로 변환하는지 검증합니다.
    /// </summary>
    [Test]
    public void ToVector3_WhenCalled_ReturnsVector3()
    {
        // Arrange
        Vector2Int vector = new Vector2Int(1, 2);

        // Act
        Vector3 result = vector.ToVector3();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(0f, result.z);
    }

    #endregion
}
