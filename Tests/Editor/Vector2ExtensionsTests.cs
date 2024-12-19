using System;
using Hian.Extensions;
using NUnit.Framework;
using UnityEngine;

public class Vector2ExtensionsTests
{
    private const float FloatTolerance = 1e-4f;
    private const float RotationTolerance = 1e-4f;

    /// <summary>
    /// Vector2.WithX() 메서드가 x 값만 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithX_WhenCalled_UpdatesXValueOnly()
    {
        // Arrange
        var vector = new Vector2(1f, 1f);

        // Act
        var result = vector.WithX(2f);

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(1f, result.y);
    }

    /// <summary>
    /// Vector2.InRangeOf() 메서드가 지정된 범위 내에 있을 때 true를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void InRangeOf_WhenInRange_ReturnsTrue()
    {
        // Arrange
        var current = new Vector2(0f, 0f);
        var target = new Vector2(1f, 1f);
        float range = 2f;

        // Act
        var result = current.InRangeOf(target, range);

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Vector2.InRangeOf() 메서드가 지정된 범위를 벗어났을 때 false를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void InRangeOf_WhenOutOfRange_ReturnsFalse()
    {
        // Arrange
        var current = new Vector2(0f, 0f);
        var target = new Vector2(2f, 2f);
        float range = 1f;

        // Act
        var result = current.InRangeOf(target, range);

        // Assert
        Assert.IsFalse(result);
    }

    /// <summary>
    /// Vector2.Round() 메서드가 뱅커스 라운딩을 정확하게 수행하는지 검증합니다.
    /// </summary>
    [TestCase(2.5f, 3.5f, 2f, 4f)]
    [TestCase(1.6f, 2.2f, 2f, 2f)]
    [TestCase(-1.6f, -2.2f, -2f, -2f)]
    public void Round_TestCases(float inX, float inY, float expectedX, float expectedY)
    {
        // Arrange
        var vector = new Vector2(inX, inY);

        // Act
        var result = vector.Round();

        // Assert
        Assert.AreEqual(expectedX, result.x, FloatTolerance);
        Assert.AreEqual(expectedY, result.y, FloatTolerance);
    }

    /// <summary>
    /// Vector2.RoundArithmetic() 메서드가 소수점 첫째 자리까지 산술 라운딩을 정확하게 수행하는지 검증합니다.
    /// </summary>
    [Test]
    public void RoundArithmetic_RoundsToFirstDecimalPlaceCorrectly()
    {
        // Arrange
        var vector = new Vector2(2.5f, 3.5f);

        // Act
        var result = vector.RoundArithmetic(0);

        // Assert
        Assert.AreEqual(3f, result.x, FloatTolerance);
        Assert.AreEqual(4f, result.y, FloatTolerance);
    }

    /// <summary>
    /// Vector2.RoundArithmetic() 메서드가 소수점 둘째 자리까지 산술 라운딩을 정확하게 수행하는지 검증합니다.
    /// </summary>
    [Test]
    public void RoundArithmetic_RoundsToSecondDecimalPlaceCorrectly()
    {
        // Arrange
        var vector = new Vector2(1.55f, 2.25f);

        // Act
        var result = vector.RoundArithmetic(1);

        // Assert
        Assert.AreEqual(
            (float)System.Math.Round(1.55f, 1, MidpointRounding.AwayFromZero),
            result.x,
            FloatTolerance
        );
        Assert.AreEqual(
            (float)System.Math.Round(2.25f, 1, MidpointRounding.AwayFromZero),
            result.y,
            FloatTolerance
        );
    }

    /// <summary>
    /// Vector2.RoundArithmetic() 메서드가 음수에 대해 산술 라운딩을 정확하게 수행하는지 검증합니다.
    /// </summary>
    [Test]
    public void RoundArithmetic_RoundsNegativeNumbersCorrectly()
    {
        // Arrange
        var vector = new Vector2(-1.6f, -2.2f);

        // Act
        var result = vector.RoundArithmetic(0);

        // Assert
        Assert.AreEqual(-2f, result.x, FloatTolerance);
        Assert.AreEqual(-2f, result.y, FloatTolerance);
    }

    /// <summary>
    /// Vector2.Rotate() 메서드가 벡터를 정확하게 회전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void Rotate_WhenCalled_RotatesVectorCorrectly()
    {
        // Arrange
        var vector = new Vector2(1f, 0f);
        float angle = 90f;

        // Act
        var result = vector.Rotate(angle);

        // Assert
        Assert.AreEqual(0f, result.x, RotationTolerance);
        Assert.AreEqual(1f, result.y, RotationTolerance);
    }

    /// <summary>
    /// Vector2.Rotate() 메서드가 지정된 중심점을 기준으로 회전하는지 검증합니다.
    /// </summary>
    [Test]
    public void Rotate_WithPivot_RotatesAroundPivotCorrectly()
    {
        // Arrange
        var vector = new Vector2(2f, 0f);
        var pivot = new Vector2(1f, 0f);
        float angle = 90f;

        // Act
        var result = vector.Rotate(angle, pivot);

        // Assert
        Assert.AreEqual(1f, result.x, RotationTolerance);
        Assert.AreEqual(1f, result.y, RotationTolerance);
    }

    /// <summary>
    /// Vector2.RotateRadians() 메서드가 벡터를 정확하게 회전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void RotateRadians_WhenCalled_RotatesVectorCorrectly()
    {
        // Arrange
        var vector = new Vector2(1f, 0f);
        float radians = Mathf.PI / 2f; // 90도

        // Act
        var result = vector.RotateRadians(radians);

        // Assert
        Assert.AreEqual(0f, result.x, RotationTolerance);
        Assert.AreEqual(1f, result.y, RotationTolerance);
    }

    /// <summary>
    /// Vector2.RotateRadians() 메서드가 지정된 중심점을 기준으로 회전하는지 검증합니다.
    /// </summary>
    [Test]
    public void RotateRadians_WithPivot_RotatesAroundPivotCorrectly()
    {
        // Arrange
        var vector = new Vector2(2f, 0f);
        var pivot = new Vector2(1f, 0f);
        float radians = Mathf.PI / 2f; // 90도

        // Act
        var result = vector.RotateRadians(radians, pivot);

        // Assert
        Assert.AreEqual(1f, result.x, RotationTolerance);
        Assert.AreEqual(1f, result.y, RotationTolerance);
    }

    /// <summary>
    /// Vector2.Rotate90Clockwise() 메서드가 벡터를 정확하게 90도 회전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void Rotate90Clockwise_WhenCalled_RotatesVector90DegreesCorrectly()
    {
        // Arrange
        var vector = new Vector2(1f, 0f);

        // Act
        var result = vector.Rotate90Clockwise();

        // Assert
        Assert.AreEqual(0f, result.x, FloatTolerance);
        Assert.AreEqual(-1f, result.y, FloatTolerance);
    }

    /// <summary>
    /// Vector2.Rotate90CounterClockwise() 메서드가 벡터를 정확하게 90도 회전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void Rotate90CounterClockwise_WhenCalled_RotatesVector90DegreesCorrectly()
    {
        // Arrange
        var vector = new Vector2(1f, 0f);

        // Act
        var result = vector.Rotate90CounterClockwise();

        // Assert
        Assert.AreEqual(0f, result.x, FloatTolerance);
        Assert.AreEqual(1f, result.y, FloatTolerance);
    }

    /// <summary>
    /// Vector2.Abs() 메서드가 각 컴포넌트의 절대값을 정확하게 계산하는지 검증합니다.
    /// </summary>
    [Test]
    public void Abs_WhenCalled_ReturnsAbsoluteValues()
    {
        // Arrange
        var vectors = new[]
        {
            new Vector2(1.5f, 2.5f), // 양수 케이스
            new Vector2(-1.5f, -2.5f), // 음수 케이스
            new Vector2(0f, 0f), // 0 케이스
        };

        foreach (var vector in vectors)
        {
            // Act
            var result = vector.Abs();

            // Assert
            Assert.AreEqual(Mathf.Abs(vector.x), result.x, FloatTolerance);
            Assert.AreEqual(Mathf.Abs(vector.y), result.y, FloatTolerance);
        }
    }

    /// <summary>
    /// Vector2.Clamp() 메서드가 각 컴포넌트를 지정된 범위로 제한하는지 검증합니다.
    /// </summary>
    [Test]
    public void Clamp_WhenCalled_ClampsComponentsCorrectly()
    {
        // Arrange
        var vector = new Vector2(-1f, 3f);
        float min = 0f;
        float max = 2f;

        // Act
        var result = vector.Clamp(min, max);

        // Assert
        Assert.AreEqual(0f, result.x);
        Assert.AreEqual(2f, result.y);
    }

    /// <summary>
    /// Vector2를 Vector3로 변환하며, 지정된 축에 값을 추가합니다
    /// </summary>
    /// <param name="vector">변환할 Vector2</param>
    /// <param name="z">z축 값 (기본값: 0)</param>
    /// <returns>변환된 Vector3</returns>
    [Test]
    public void ToVector3_WhenCalled_CreatesCorrectVector3()
    {
        // Arrange
        var vector2 = new Vector2(1f, 2f);

        // Act
        var result = vector2.ToVector3(3f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector2를 XZ 평면의 Vector3로 변환합니다
    /// </summary>
    /// <param name="vector">변환할 Vector2</param>
    /// <param name="y">y축 값 (기본값: 0)</param>
    /// <returns>XZ 평면상의 Vector3</returns>
    [Test]
    public void ToVector3XZ_WhenCalled_CreatesCorrectVector3()
    {
        // Arrange
        var vector2 = new Vector2(1f, 2f);

        // Act
        var result = vector2.ToVector3XZ(3f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(3f, result.y);
        Assert.AreEqual(2f, result.z);
    }

    [Test]
    public void Clamp_WhenMinEqualsMax_ReturnsMinValue()
    {
        // Arrange
        var vector = new Vector2(0.5f, 1.5f);
        float min = 1f;
        float max = 1f;

        // Act
        var result = vector.Clamp(min, max);

        // Assert
        Assert.AreEqual(min, result.x);
        Assert.AreEqual(min, result.y);
    }

    [Test]
    public void Clamp_WhenMinGreaterThanMax_ThrowsArgumentException()
    {
        // Arrange
        var vector = new Vector2(1f, 1f);
        float min = 2f;
        float max = 1f;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => vector.Clamp(min, max));
    }

    [Test]
    public void Normalize_ReturnsNormalizedVector()
    {
        Vector2 vector = new Vector2(3, 4);
        Vector2 normalized = vector.normalized;
        Assert.AreEqual(new Vector2(0.6f, 0.8f), normalized);
    }

    [Test]
    public void Dot_ReturnsDotProduct()
    {
        Vector2 vector1 = new Vector2(1, 2);
        Vector2 vector2 = new Vector2(3, 4);
        float dotProduct = vector1.Dot(vector2);
        Assert.AreEqual(11, dotProduct);
    }

    [Test]
    public void Cross_ReturnsCrossProduct()
    {
        Vector2 vector1 = new Vector2(1, 2);
        Vector2 vector2 = new Vector2(3, 4);
        float crossProduct = vector1.Cross(vector2);
        Assert.AreEqual(-2, crossProduct);
    }

    [Test]
    public void Project_ReturnsProjectedVector()
    {
        Vector2 vector = new Vector2(2, 3);
        Vector2 onto = new Vector2(4, 0);
        Vector2 projected = vector.Project(onto);
        Assert.AreEqual(new Vector2(2, 0), projected);
    }

    [Test]
    public void Reflect_ReturnsReflectedVector()
    {
        Vector2 vector = new Vector2(1, 1);
        Vector2 normal = new Vector2(0, 1);
        Vector2 reflected = vector.Reflect(normal);
        Assert.AreEqual(new Vector2(1, -1), reflected);
    }

    #region With

    /// <summary>
    /// Vector2.With() 메서드가 지정된 축의 값을 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void With_WhenCalled_UpdatesSpecifiedAxisValue()
    {
        // Arrange
        var vector = new Vector2(1f, 1f);

        // Act
        var resultX = vector.With(0, 2f);
        var resultY = vector.With(1, 3f);

        // Assert
        Assert.AreEqual(2f, resultX.x);
        Assert.AreEqual(1f, resultX.y);
        Assert.AreEqual(1f, resultY.x);
        Assert.AreEqual(3f, resultY.y);
    }

    /// <summary>
    /// Vector2.With() 메서드에 잘못된 축 인덱스를 전달하면 ArgumentOutOfRangeException이 발생하는지 검증합니다.
    /// </summary>
    [Test]
    public void With_WhenCalledWithInvalidAxis_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var vector = new Vector2(1f, 1f);

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => vector.With(2, 2f));
    }

    /// <summary>
    /// Vector2.WithXY() 메서드가 x와 y 값을 모두 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithXY_WhenCalled_UpdatesXAndYValues()
    {
        // Arrange
        var vector = new Vector2(1f, 1f);

        // Act
        var result = vector.WithXY(2f, 3f);

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(3f, result.y);
    }

    #endregion

    #region Negate

    /// <summary>
    /// Vector2.WithNegate() 메서드가 지정된 축의 값을 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegate_WhenCalled_NegatesSpecifiedAxisValue()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var resultX = vector.WithNegate(0);
        var resultY = vector.WithNegate(1);

        // Assert
        Assert.AreEqual(-1f, resultX.x);
        Assert.AreEqual(2f, resultX.y);
        Assert.AreEqual(1f, resultY.x);
        Assert.AreEqual(-2f, resultY.y);
    }

    /// <summary>
    /// Vector2.WithNegateX() 메서드가 x 값을 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateX_WhenCalled_NegatesXValue()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var result = vector.WithNegateX();

        // Assert
        Assert.AreEqual(-1f, result.x);
        Assert.AreEqual(2f, result.y);
    }

    /// <summary>
    /// Vector2.WithNegateY() 메서드가 y 값을 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateY_WhenCalled_NegatesYValue()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var result = vector.WithNegateY();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(-2f, result.y);
    }

    /// <summary>
    /// Vector2.Negate() 메서드가 모든 성분을 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void Negate_WhenCalled_NegatesAllComponents()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var result = vector.Negate();

        // Assert
        Assert.AreEqual(-1f, result.x);
        Assert.AreEqual(-2f, result.y);
    }

    #endregion

    #region Min, Max

    /// <summary>
    /// Vector2.MaxComponent() 메서드가 가장 큰 성분의 인덱스와 값을 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void MaxComponent_WhenCalled_ReturnsIndexOfMaxValue()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var (index, value) = vector.MaxComponent();

        // Assert
        Assert.AreEqual(1, index);
        Assert.AreEqual(2f, value);
    }

    /// <summary>
    /// Vector2.MinComponent() 메서드가 가장 작은 성분의 인덱스와 값을 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void MinComponent_WhenCalled_ReturnsIndexOfMinValue()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var (index, value) = vector.MinComponent();

        // Assert
        Assert.AreEqual(0, index);
        Assert.AreEqual(1f, value);
    }

    #endregion

    #region Clamp, Remap

    /// <summary>
    /// Vector2.Remap() 메서드가 모든 성분을 새로운 범위로 올바르게 다시 매핑하는지 검증합니다.
    /// </summary>
    [Test]
    public void Remap_WhenCalled_RemapsAllComponentsToNewRange()
    {
        // Arrange
        var vector = new Vector2(0f, 10f);
        float min1 = 0f;
        float max1 = 10f;
        float min2 = 0f;
        float max2 = 100f;

        // Act
        var result = vector.Remap(min1, max1, min2, max2);

        // Assert
        Assert.AreEqual(0f, result.x, FloatTolerance);
        Assert.AreEqual(100f, result.y, FloatTolerance);
    }

    /// <summary>
    /// Vector2.Clamp01() 메서드가 모든 성분을 0과 1 사이로 제한하는지 검증합니다.
    /// </summary>
    [Test]
    public void Clamp01_WhenCalled_ClampsAllComponentsBetween0And1()
    {
        // Arrange
        var vector = new Vector2(-1f, 2f);

        // Act
        var result = vector.Clamp01();

        // Assert
        Assert.AreEqual(0f, result.x);
        Assert.AreEqual(1f, result.y);
    }

    #endregion

    #region Divide, IsUniform

    /// <summary>
    /// Vector2.Divide() 메서드가 모든 성분을 다른 벡터로 나누는지 검증합니다.
    /// </summary>
    [Test]
    public void Divide_WhenCalled_DividesAllComponentsByOtherVector()
    {
        // Arrange
        var vector = new Vector2(4f, 6f);
        var other = new Vector2(2f, 3f);

        // Act
        var result = vector.Divide(other);

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(2f, result.y);
    }

    /// <summary>
    /// Vector2.IsUniform() 메서드가 모든 성분이 같은지 확인하는지 검증합니다.
    /// </summary>
    [Test]
    public void IsUniform_WhenCalled_ReturnsTrueIfAllComponentsAreEqual()
    {
        // Arrange
        var vector = new Vector2(1f, 1f);

        // Act
        var result = vector.IsUniform();

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Vector2.IsUniform() 메서드가 모든 성분이 같지 않을 때 false를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void IsUniform_WhenCalled_ReturnsFalseIfAllComponentsAreNotEqual()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var result = vector.IsUniform();

        // Assert
        Assert.IsFalse(result);
    }

    #endregion

    #region Etc


    /// <summary>
    /// Vector2.GetClosestPoint() 메서드가 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPoint_WhenCalled_ReturnsClosestPointInfo()
    {
        // Arrange
        var point = new Vector2(0f, 0f);
        var points = new[] { new Vector2(1f, 1f), new Vector2(2f, 2f), new Vector2(3f, 3f) };

        // Act
        var (closestPoint, index) = point.GetClosestPoint(points);

        // Assert
        Assert.AreEqual(new Vector2(1f, 1f), closestPoint);
        Assert.AreEqual(0, index);
    }

    /// <summary>
    /// Vector2.GetClosestPointOnRay() 메서드가 광선(Ray) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPointOnRay_WhenCalled_ReturnsClosestPointInfoOnRay()
    {
        // Arrange
        var point = new Vector2(2f, 2f);
        var origin = new Vector2(0f, 0f);
        var direction = new Vector2(1f, 0f).normalized;

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnRay(origin, direction);

        // Assert
        Assert.AreEqual(new Vector2(2f, 0f), closestPoint);
        Assert.AreEqual(2f, distance);
    }

    /// <summary>
    /// Vector2.GetClosestPointOnSegment() 메서드가 선분(Line Segment) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPointOnSegment_WhenCalled_ReturnsClosestPointInfoOnSegment()
    {
        // Arrange
        var point = new Vector2(2f, 2f);
        var start = new Vector2(0f, 0f);
        var end = new Vector2(4f, 0f);

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnSegment(start, end);

        // Assert
        Assert.AreEqual(new Vector2(2f, 0f), closestPoint);
        Assert.AreEqual(2f, distance);
    }

    /// <summary>
    /// Vector2.RandomDeflected() 메서드가 주어진 각도만큼 방향 벡터를 임의로 편향시키는지 검증합니다.
    /// </summary>
    [Test]
    public void RandomDeflected_WhenCalled_ReturnsDeflectedDirectionVector()
    {
        // Arrange
        var direction = new Vector2(1f, 0f);
        float angle = 90f;

        // Act
        var result = direction.RandomDeflected(angle);

        // Assert
        Assert.AreEqual(direction.magnitude, result.magnitude, FloatTolerance);
    }

    /// <summary>
    /// Vector2.InsertX() 메서드가 x 축에 값을 삽입하고 벡터를 3차원으로 확장하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertX_WhenCalled_Returns3DVectorWithInsertedX()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var result = vector.InsertX(3f);

        // Assert
        Assert.AreEqual(3f, result.x);
        Assert.AreEqual(1f, result.y);
        Assert.AreEqual(2f, result.z);
    }

    /// <summary>
    /// Vector2.InsertY() 메서드가 y 축에 값을 삽입하고 벡터를 3차원으로 확장하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertY_WhenCalled_Returns3DVectorWithInsertedY()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var result = vector.InsertY(3f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(3f, result.y);
        Assert.AreEqual(2f, result.z);
    }

    /// <summary>
    /// Vector2.InsertZ() 메서드가 z 축에 값을 삽입하고 벡터를 3차원으로 확장하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertZ_WhenCalled_Returns3DVectorWithInsertedZ()
    {
        // Arrange
        var vector = new Vector2(1f, 2f);

        // Act
        var result = vector.InsertZ(3f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    #endregion
}
