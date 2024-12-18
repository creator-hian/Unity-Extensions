using System;
using Hian.Extensions;
using NUnit.Framework;
using UnityEngine;

public class Vector3ExtensionsTests
{
    private const float FloatTolerance = 1e-4f;

    #region With

    /// <summary>
    /// Vector3.WithX() 메서드가 x 값만 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithX_WhenCalled_UpdatesXValueOnly()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithX(2f);

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(1f, result.y);
        Assert.AreEqual(1f, result.z);
    }

    /// <summary>
    /// Vector3.WithY() 메서드가 y 값만 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithY_WhenCalled_UpdatesYValueOnly()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithY(2f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(1f, result.z);
    }

    /// <summary>
    /// Vector3.WithZ() 메서드가 z 값만 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithZ_WhenCalled_UpdatesZValueOnly()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithZ(2f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(1f, result.y);
        Assert.AreEqual(2f, result.z);
    }

    /// <summary>
    /// Vector3.WithXY() 메서드가 x, y 값을 모두 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithXY_WhenCalled_UpdatesXAndYValues()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithXY(2f, 3f);

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(3f, result.y);
        Assert.AreEqual(1f, result.z);
    }

    /// <summary>
    /// Vector3.WithXY() 메서드에 Vector2를 사용했을 때 x, y 값을 모두 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithXY_WhenCalledWithVector2_UpdatesXAndYValues()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithXY(new Vector2(2f, 3f));

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(3f, result.y);
        Assert.AreEqual(1f, result.z);
    }

    /// <summary>
    /// Vector3.WithXZ() 메서드가 x, z 값을 모두 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithXZ_WhenCalled_UpdatesXAndZValues()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithXZ(2f, 3f);

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(1f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector3.WithXZ() 메서드에 Vector2를 사용했을 때 x, z 값을 모두 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithXZ_WhenCalledWithVector2_UpdatesXAndZValues()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithXZ(new Vector2(2f, 3f));

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(1f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector3.WithYZ() 메서드가 y, z 값을 모두 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithYZ_WhenCalled_UpdatesYAndZValues()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithYZ(2f, 3f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector3.WithYZ() 메서드에 Vector2를 사용했을 때 y, z 값을 모두 새 값으로 업데이트하는지 검증합니다.
    /// </summary>
    [Test]
    public void WithYZ_WhenCalledWithVector2_UpdatesYAndZValues()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.WithYZ(new Vector2(2f, 3f));

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    #endregion

    #region WithNegate

    /// <summary>
    /// Vector3.WithNegateX() 메서드가 x 값만 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateX_WhenCalled_NegatesXValueOnly()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.WithNegateX();

        // Assert
        Assert.AreEqual(-1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector3.WithNegateY() 메서드가 y 값만 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateY_WhenCalled_NegatesYValueOnly()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.WithNegateY();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(-2f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector3.WithNegateZ() 메서드가 z 값만 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateZ_WhenCalled_NegatesZValueOnly()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.WithNegateZ();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(-3f, result.z);
    }

    /// <summary>
    /// Vector3.WithNegateXY() 메서드가 x, y 값을 모두 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateXY_WhenCalled_NegatesXAndYValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.WithNegateXY();

        // Assert
        Assert.AreEqual(-1f, result.x);
        Assert.AreEqual(-2f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector3.WithNegateXZ() 메서드가 x, z 값을 모두 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateXZ_WhenCalled_NegatesXAndZValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.WithNegateXZ();

        // Assert
        Assert.AreEqual(-1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(-3f, result.z);
    }

    /// <summary>
    /// Vector3.WithNegateYZ() 메서드가 y, z 값을 모두 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void WithNegateYZ_WhenCalled_NegatesYAndZValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.WithNegateYZ();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(-2f, result.y);
        Assert.AreEqual(-3f, result.z);
    }

    /// <summary>
    /// Vector3.Negate() 메서드가 모든 값을 반전시키는지 검증합니다.
    /// </summary>
    [Test]
    public void Negate_WhenCalled_NegatesAllValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.Negate();

        // Assert
        Assert.AreEqual(-1f, result.x);
        Assert.AreEqual(-2f, result.y);
        Assert.AreEqual(-3f, result.z);
    }

    #endregion

    #region Get

    /// <summary>
    /// Vector3.GetXY() 메서드가 x, y 값을 가진 Vector2를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetXY_WhenCalled_ReturnsVector2WithXAndYValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetXY();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
    }

    /// <summary>
    /// Vector3.GetXZ() 메서드가 x, z 값을 가진 Vector2를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetXZ_WhenCalled_ReturnsVector2WithXAndZValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetXZ();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(3f, result.y);
    }

    /// <summary>
    /// Vector3.GetYX() 메서드가 y, x 값을 가진 Vector2를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetYX_WhenCalled_ReturnsVector2WithYAndXValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetYX();

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(1f, result.y);
    }

    /// <summary>
    /// Vector3.GetYZ() 메서드가 y, z 값을 가진 Vector2를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetYZ_WhenCalled_ReturnsVector2WithYAndZValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetYZ();

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(3f, result.y);
    }

    /// <summary>
    /// Vector3.GetZX() 메서드가 z, x 값을 가진 Vector2를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetZX_WhenCalled_ReturnsVector2WithZAndXValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetZX();

        // Assert
        Assert.AreEqual(3f, result.x);
        Assert.AreEqual(1f, result.y);
    }

    /// <summary>
    /// Vector3.GetZY() 메서드가 z, y 값을 가진 Vector2를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetZY_WhenCalled_ReturnsVector2WithZAndYValues()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetZY();

        // Assert
        Assert.AreEqual(3f, result.x);
        Assert.AreEqual(2f, result.y);
    }

    /// <summary>
    /// Vector3.GetXZY() 메서드가 x, z, y 순서로 값을 가진 Vector3를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetXZY_WhenCalled_ReturnsVector3WithXZYOrder()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetXZY();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(3f, result.y);
        Assert.AreEqual(2f, result.z);
    }

    /// <summary>
    /// Vector3.GetYXZ() 메서드가 y, x, z 순서로 값을 가진 Vector3를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetYXZ_WhenCalled_ReturnsVector3WithYXZOrder()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetYXZ();

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(1f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector3.GetYZX() 메서드가 y, z, x 순서로 값을 가진 Vector3를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetYZX_WhenCalled_ReturnsVector3WithYZXOrder()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetYZX();

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(3f, result.y);
        Assert.AreEqual(1f, result.z);
    }

    /// <summary>
    /// Vector3.GetZXY() 메서드가 z, x, y 순서로 값을 가진 Vector3를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetZXY_WhenCalled_ReturnsVector3WithZXYOrder()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetZXY();

        // Assert
        Assert.AreEqual(3f, result.x);
        Assert.AreEqual(1f, result.y);
        Assert.AreEqual(2f, result.z);
    }

    /// <summary>
    /// Vector3.GetZYX() 메서드가 z, y, x 순서로 값을 가진 Vector3를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetZYX_WhenCalled_ReturnsVector3WithZYXOrder()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.GetZYX();

        // Assert
        Assert.AreEqual(3f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(1f, result.z);
    }

    #endregion

    #region Insert

    /// <summary>
    /// Vector3.InsertX() 메서드가 x 위치에 값을 삽입하고 Vector4를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertX_WhenCalled_ReturnsVector4WithInsertedX()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.InsertX(4f);

        // Assert
        Assert.AreEqual(4f, result.x);
        Assert.AreEqual(1f, result.y);
        Assert.AreEqual(2f, result.z);
        Assert.AreEqual(3f, result.w);
    }

    /// <summary>
    /// Vector3.InsertY() 메서드가 y 위치에 값을 삽입하고 Vector4를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertY_WhenCalled_ReturnsVector4WithInsertedY()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.InsertY(4f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(4f, result.y);
        Assert.AreEqual(2f, result.z);
        Assert.AreEqual(3f, result.w);
    }

    /// <summary>
    /// Vector3.InsertZ() 메서드가 z 위치에 값을 삽입하고 Vector4를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertZ_WhenCalled_ReturnsVector4WithInsertedZ()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.InsertZ(4f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(4f, result.z);
        Assert.AreEqual(3f, result.w);
    }

    /// <summary>
    /// Vector3.InsertW() 메서드가 w 위치에 값을 삽입하고 Vector4를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void InsertW_WhenCalled_ReturnsVector4WithInsertedW()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.InsertW(4f);

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(3f, result.z);
        Assert.AreEqual(4f, result.w);
    }

    #endregion

    #region Min, Max

    /// <summary>
    /// Vector3.MaxComponent() 메서드가 가장 큰 컴포넌트의 인덱스와 값을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void MaxComponent_WhenCalled_ReturnsIndexOfMaxValue()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var (index, value) = vector.MaxComponent();

        // Assert
        Assert.AreEqual(2, index);
        Assert.AreEqual(3f, value);
    }

    /// <summary>
    /// Vector3.MinComponent() 메서드가 가장 작은 컴포넌트의 인덱스와 값을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void MinComponent_WhenCalled_ReturnsIndexOfMinValue()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var (index, value) = vector.MinComponent();

        // Assert
        Assert.AreEqual(0, index);
        Assert.AreEqual(1f, value);
    }

    #endregion

    #region Remap

    /// <summary>
    /// Vector3.Remap() 메서드가 모든 컴포넌트를 새 범위로 올바르게 다시 매핑하는지 검증합니다.
    /// </summary>
    [Test]
    public void Remap_WhenCalled_RemapsAllComponentsToNewRange()
    {
        // Arrange
        var vector = new Vector3(0f, 5f, 10f);

        // Act
        var result = vector.Remap(0f, 10f, 0f, 100f);

        // Assert
        Assert.AreEqual(0f, result.x);
        Assert.AreEqual(50f, result.y);
        Assert.AreEqual(100f, result.z);
    }

    #endregion

    #region Abs, Clamp, Clamp01, Divide, IsUniform

    /// <summary>
    /// Vector3.Abs() 메서드가 모든 컴포넌트의 절대값을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void Abs_WhenCalled_ReturnsAbsoluteValuesOfAllComponents()
    {
        // Arrange
        var vector = new Vector3(-1f, 2f, -3f);

        // Act
        var result = vector.Abs();

        // Assert
        Assert.AreEqual(1f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(3f, result.z);
    }

    /// <summary>
    /// Vector3.Clamp() 메서드가 모든 컴포넌트를 지정된 범위로 제한하는지 검증합니다.
    /// </summary>
    [Test]
    public void Clamp_WhenCalled_ClampsAllComponentsToSpecifiedRange()
    {
        // Arrange
        var vector = new Vector3(-1f, 5f, 11f);

        // Act
        var result = vector.Clamp(0f, 10f);

        // Assert
        Assert.AreEqual(0f, result.x);
        Assert.AreEqual(5f, result.y);
        Assert.AreEqual(10f, result.z);
    }

    /// <summary>
    /// Vector3.Clamp01() 메서드가 모든 컴포넌트를 0과 1 사이로 제한하는지 검증합니다.
    /// </summary>
    [Test]
    public void Clamp01_WhenCalled_ClampsAllComponentsBetween0And1()
    {
        // Arrange
        var vector = new Vector3(-1f, 0.5f, 2f);

        // Act
        var result = vector.Clamp01();

        // Assert
        Assert.AreEqual(0f, result.x);
        Assert.AreEqual(0.5f, result.y);
        Assert.AreEqual(1f, result.z);
    }

    /// <summary>
    /// Vector3.Divide() 메서드가 모든 컴포넌트를 다른 벡터로 나누는지 검증합니다.
    /// </summary>
    [Test]
    public void Divide_WhenCalled_DividesAllComponentsByOtherVector()
    {
        // Arrange
        var vector = new Vector3(4f, 6f, 8f);
        var other = new Vector3(2f, 3f, 4f);

        // Act
        var result = vector.Divide(other);

        // Assert
        Assert.AreEqual(2f, result.x);
        Assert.AreEqual(2f, result.y);
        Assert.AreEqual(2f, result.z);
    }

    /// <summary>
    /// Vector3.IsUniform() 메서드가 모든 컴포넌트가 동일한지 여부를 올바르게 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void IsUniform_WhenCalled_ReturnsTrueIfAllComponentsAreEqual()
    {
        // Arrange
        var vector = new Vector3(1f, 1f, 1f);

        // Act
        var result = vector.IsUniform();

        // Assert
        Assert.IsTrue(result);
    }

    /// <summary>
    /// Vector3.IsUniform() 메서드가 모든 컴포넌트가 동일하지 않을 때 false를 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void IsUniform_WhenCalled_ReturnsFalseIfAllComponentsAreNotEqual()
    {
        // Arrange
        var vector = new Vector3(1f, 2f, 3f);

        // Act
        var result = vector.IsUniform();

        // Assert
        Assert.IsFalse(result);
    }

    #endregion

    #region EventlyDistributedPointOnSphere

    // /// <summary>
    // /// Vector3.EventlyDistributedPointOnSphere() 메서드가 구 표면에 균등하게 분포된 점을 반환하는지 검증합니다.
    // /// </summary>
    // [Test]
    // public void EventlyDistributedPointOnSphere_WhenCalled_ReturnsEventlyDistributedPoint()
    // {
    //     // Arrange
    //     var index = 0;
    //     var radius = 1f;
    //     var count = 10;

    //     // Act
    //     var result = Vector3Extensions.EventlyDistributedPointOnSphere(index, radius, count);

    //     // Assert
    //     Assert.AreEqual(radius, result.magnitude, FloatTolerance);
    // }

    #endregion

    #region GetClosestPoint

    /// <summary>
    /// Vector3.GetClosestPoint() 메서드가 주어진 점들 중에서 가장 가까운 점을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPoint_WhenCalled_ReturnsClosestPoint()
    {
        // Arrange
        var point = new Vector3(0f, 0f, 0f);
        var points = new[]
        {
            new Vector3(1f, 0f, 0f),
            new Vector3(0f, 2f, 0f),
            new Vector3(0f, 0f, 3f),
        };

        // Act
        var (closestPoint, index) = point.GetClosestPoint(points);

        // Assert
        Assert.AreEqual(new Vector3(1f, 0f, 0f), closestPoint);
        Assert.AreEqual(0, index);
    }

    #endregion

    #region GetClosestPointOnRay

    /// <summary>
    /// Vector3.GetClosestPointOnRay() 메서드가 광선 상에서 가장 가까운 점을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPointOnRay_WhenCalled_ReturnsClosestPointOnRay()
    {
        // Arrange
        var point = new Vector3(0f, 0f, 0f);
        var origin = new Vector3(1f, 0f, 0f);
        var direction = new Vector3(0f, 1f, 0f);

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnRay(origin, direction);

        // Assert
        Assert.AreEqual(new Vector3(1f, 0f, 0f), closestPoint);
        Assert.AreEqual(1f, distance, FloatTolerance);
    }

    /// <summary>
    /// Vector3.GetClosestPointOnRay() 메서드에 Ray를 사용했을 때 광선 상에서 가장 가까운 점을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPointOnRay_WhenCalledWithRay_ReturnsClosestPointOnRay()
    {
        // Arrange
        var point = new Vector3(0f, 0f, 0f);
        var ray = new Ray(new Vector3(1f, 0f, 0f), new Vector3(0f, 1f, 0f));

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnRay(ray);

        // Assert
        Assert.AreEqual(new Vector3(1f, 0f, 0f), closestPoint);
        Assert.AreEqual(1f, distance, FloatTolerance); // 유클리드 거리
    }

    #endregion

    #region GetClosestPointOnSegment

    /// <summary>
    /// Vector3.GetClosestPointOnSegment() 메서드가 선분 상에서 가장 가까운 점을 반환하는지 검증합니다.
    /// </summary>
    [Test]
    public void GetClosestPointOnSegment_WhenCalled_ReturnsClosestPointOnSegment()
    {
        // Arrange
        var point = new Vector3(0f, 0f, 0f);
        var start = new Vector3(1f, 0f, 0f);
        var end = new Vector3(1f, 2f, 0f);

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnSegment(start, end);

        // Assert
        Assert.AreEqual(new Vector3(1f, 0f, 0f), closestPoint);
        Assert.AreEqual(1f, distance, FloatTolerance); // 유클리드 거리
    }

    [Test]
    public void GetClosestPointOnRay_WhenClosestPointIsOnRay_ReturnsCorrectPointAndDistance()
    {
        // Arrange
        var point = new Vector3(1f, 1f, 0f);
        var origin = new Vector3(1f, 0f, 0f);
        var direction = new Vector3(0f, 1f, 0f);

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnRay(origin, direction);

        // Assert
        Assert.AreEqual(new Vector3(1f, 1f, 0f), closestPoint);
        Assert.AreEqual(0f, distance, FloatTolerance); // 점이 광선 위에 있으므로 거리 0
    }

    [Test]
    public void GetClosestPointOnRay_WhenClosestPointIsBeforeOrigin_ReturnsOriginAndCorrectDistance()
    {
        // Arrange
        var point = new Vector3(-1f, 0f, 0f);
        var origin = new Vector3(0f, 0f, 0f);
        var direction = new Vector3(1f, 0f, 0f); // 정규화된 방향

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnRay(origin, direction);

        // Assert
        Assert.AreEqual(origin, closestPoint);
        Assert.AreEqual(1f, distance, FloatTolerance); // 유클리드 거리
    }

    [Test]
    public void GetClosestPointOnSegment_WhenClosestPointIsMiddle_ReturnsCorrectPointAndDistance()
    {
        // Arrange
        var point = new Vector3(1f, 1f, 0f);
        var start = new Vector3(0f, 0f, 0f);
        var end = new Vector3(2f, 0f, 0f);

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnSegment(start, end);

        // Assert
        Assert.AreEqual(new Vector3(1f, 0f, 0f), closestPoint);
        Assert.AreEqual(1f, distance, FloatTolerance); // 유클리드 거리
    }

    [Test]
    public void GetClosestPointOnSegment_WhenClosestPointIsStart_ReturnsStartAndCorrectDistance()
    {
        // Arrange
        var point = new Vector3(-1f, 0f, 0f);
        var start = new Vector3(0f, 0f, 0f);
        var end = new Vector3(2f, 0f, 0f);

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnSegment(start, end);

        // Assert
        Assert.AreEqual(start, closestPoint);
        Assert.AreEqual(1f, distance, FloatTolerance); // 유클리드 거리
    }

    [Test]
    public void GetClosestPointOnSegment_WhenClosestPointIsEnd_ReturnsEndAndCorrectDistance()
    {
        // Arrange
        var point = new Vector3(3f, 0f, 0f);
        var start = new Vector3(0f, 0f, 0f);
        var end = new Vector3(2f, 0f, 0f);

        // Act
        var (closestPoint, distance) = point.GetClosestPointOnSegment(start, end);

        // Assert
        Assert.AreEqual(end, closestPoint);
        Assert.AreEqual(1f, distance, FloatTolerance); // 유클리드 거리
    }

    #endregion

    #region RandomDeflected

    /// <summary>
    /// Vector3.RandomDeflected() 메서드가 주어진 각도만큼 방향 벡터를 임의로 편향시키는지 검증합니다.
    /// </summary>
    [Test]
    public void RandomDeflected_WhenCalled_ReturnsDeflectedDirectionVector()
    {
        // Arrange
        var direction = new Vector3(1f, 0f, 0f);
        var angle = 90f;

        // Act
        var result = direction.RandomDeflected(angle);

        // Assert
        Assert.AreEqual(direction.magnitude, result.magnitude, FloatTolerance);
    }

    /// <summary>
    /// Vector3.RandomDeflected() 메서드에 지정된 축을 사용했을 때 주어진 각도만큼 방향 벡터를 임의로 편향시키는지 검증합니다.
    /// </summary>
    [Test]
    public void RandomDeflected_WhenCalledWithUpAxis_ReturnsDeflectedDirectionVector()
    {
        // Arrange
        var direction = new Vector3(1f, 0f, 0f);
        var angle = 90f;
        var up = new Vector3(0f, 0f, 1f);

        // Act
        var result = direction.RandomDeflected(angle, up);

        // Assert
        Assert.AreEqual(direction.magnitude, result.magnitude, FloatTolerance);
    }

    /// <summary>
    /// Vector3.RandomDeflected() 메서드에 x, y 각도를 사용했을 때 주어진 각도만큼 방향 벡터를 임의로 편향시키는지 검증합니다.
    /// </summary>
    [Test]
    public void RandomDeflected_WhenCalledWithXYAngles_ReturnsDeflectedDirectionVector()
    {
        // Arrange
        var direction = new Vector3(1f, 0f, 0f);
        var angleX = 90f;
        var angleY = 45f;

        // Act
        var result = direction.RandomDeflected(angleX, angleY);

        // Assert
        Assert.AreEqual(direction.magnitude, result.magnitude, FloatTolerance);
    }

    /// <summary>
    /// Vector3.RandomDeflected() 메서드에 x, y 각도와 지정된 축을 사용했을 때 주어진 각도만큼 방향 벡터를 임의로 편향시키는지 검증합니다.
    /// </summary>
    [Test]
    public void RandomDeflected_WhenCalledWithXYAnglesAndUpAxis_ReturnsDeflectedDirectionVector()
    {
        // Arrange
        var direction = new Vector3(1f, 0f, 0f);
        var angleX = 90f;
        var angleY = 45f;
        var up = new Vector3(0f, 0f, 1f);

        // Act
        var result = direction.RandomDeflected(angleX, angleY, up);

        // Assert
        Assert.AreEqual(direction.magnitude, result.magnitude, FloatTolerance);
    }

    /// <summary>
    /// Vector3.RandomDeflected() 메서드에 Vector2 각도를 사용했을 때 주어진 각도만큼 방향 벡터를 임의로 편향시키는지 검증합니다.
    /// </summary>
    [Test]
    public void RandomDeflected_WhenCalledWithVector2Angles_ReturnsDeflectedDirectionVector()
    {
        // Arrange
        var direction = new Vector3(1f, 0f, 0f);
        var angles = new Vector2(90f, 45f);

        // Act
        var result = direction.RandomDeflected(angles);

        // Assert
        Assert.AreEqual(direction.magnitude, result.magnitude, FloatTolerance);
    }

    /// <summary>
    /// Vector3.RandomDeflected() 메서드에 Vector2 각도와 지정된 축을 사용했을 때 주어진 각도만큼 방향 벡터를 임의로 편향시키는지 검증합니다.
    /// </summary>
    [Test]
    public void RandomDeflected_WhenCalledWithVector2AnglesAndUpAxis_ReturnsDeflectedDirectionVector()
    {
        // Arrange
        var direction = new Vector3(1f, 0f, 0f);
        var angles = new Vector2(90f, 45f);
        var up = new Vector3(0f, 0f, 1f);

        // Act
        var result = direction.RandomDeflected(angles, up);

        // Assert
        Assert.AreEqual(direction.magnitude, result.magnitude, FloatTolerance);
    }

    #endregion
}
