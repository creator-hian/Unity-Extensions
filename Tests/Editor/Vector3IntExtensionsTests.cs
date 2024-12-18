using System;
using System.Collections.Generic;
using Hian.Extensions;
using NUnit.Framework;
using UnityEngine;

public class Vector3IntExtensionsTests
{
    [Test]
    public void With_ValidAxis_ReturnsNewVectorWithModifiedValue()
    {
        var vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.With(0, 4), Is.EqualTo(new Vector3Int(4, 2, 3)));
        Assert.That(vector.With(1, 5), Is.EqualTo(new Vector3Int(1, 5, 3)));
        Assert.That(vector.With(2, 6), Is.EqualTo(new Vector3Int(1, 2, 6)));
    }

    [Test]
    public void With_InvalidAxis_ThrowsArgumentOutOfRangeException()
    {
        var vector = new Vector3Int(1, 2, 3);

        Assert.Throws<ArgumentOutOfRangeException>(() => vector.With(3, 4));
    }

    [Test]
    public void WithX_ReturnsNewVectorWithModifiedX()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithX(4), Is.EqualTo(new Vector3Int(4, 2, 3)));
    }

    [Test]
    public void WithY_ReturnsNewVectorWithModifiedY()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithY(4), Is.EqualTo(new Vector3Int(1, 4, 3)));
    }

    [Test]
    public void WithZ_ReturnsNewVectorWithModifiedZ()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithZ(4), Is.EqualTo(new Vector3Int(1, 2, 4)));
    }

    [Test]
    public void WithXY_WithTwoInts_ReturnsNewVectorWithModifiedXY()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithXY(4, 5), Is.EqualTo(new Vector3Int(4, 5, 3)));
    }

    [Test]
    public void WithXY_WithVector2Int_ReturnsNewVectorWithModifiedXY()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithXY(new Vector2Int(4, 5)), Is.EqualTo(new Vector3Int(4, 5, 3)));
    }

    [Test]
    public void WithXZ_WithTwoInts_ReturnsNewVectorWithModifiedXZ()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithXZ(4, 5), Is.EqualTo(new Vector3Int(4, 2, 5)));
    }

    [Test]
    public void WithXZ_WithVector2Int_ReturnsNewVectorWithModifiedXZ()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithXZ(new Vector2Int(4, 5)), Is.EqualTo(new Vector3Int(4, 2, 5)));
    }

    [Test]
    public void WithYZ_WithTwoInts_ReturnsNewVectorWithModifiedYZ()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithYZ(4, 5), Is.EqualTo(new Vector3Int(1, 4, 5)));
    }

    [Test]
    public void WithYZ_WithVector2Int_ReturnsNewVectorWithModifiedYZ()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithYZ(new Vector2Int(4, 5)), Is.EqualTo(new Vector3Int(1, 4, 5)));
    }

    [Test]
    public void WithNegate_ValidAxis_ReturnsNewVectorWithNegatedValue()
    {
        var vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.WithNegate(0), Is.EqualTo(new Vector3Int(-1, 2, 3)));
        Assert.That(vector.WithNegate(1), Is.EqualTo(new Vector3Int(1, -2, 3)));
        Assert.That(vector.WithNegate(2), Is.EqualTo(new Vector3Int(1, 2, -3)));
    }

    [Test]
    public void WithNegateX_ReturnsNewVectorWithNegatedX()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateX(), Is.EqualTo(new Vector3Int(-1, 2, 3)));
    }

    [Test]
    public void WithNegateY_ReturnsNewVectorWithNegatedY()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateY(), Is.EqualTo(new Vector3Int(1, -2, 3)));
    }

    [Test]
    public void WithNegateZ_ReturnsNewVectorWithNegatedZ()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateZ(), Is.EqualTo(new Vector3Int(1, 2, -3)));
    }

    [Test]
    public void WithNegate_TwoAxes_ReturnsNewVectorWithNegatedValues()
    {
        var vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.WithNegate(0, 1), Is.EqualTo(new Vector3Int(-1, -2, 3)));
        Assert.That(vector.WithNegate(0, 2), Is.EqualTo(new Vector3Int(-1, 2, -3)));
        Assert.That(vector.WithNegate(1, 2), Is.EqualTo(new Vector3Int(1, -2, -3)));
    }

    [Test]
    public void WithNegateXY_ReturnsNewVectorWithNegatedXY()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateXY(), Is.EqualTo(new Vector3Int(-1, -2, 3)));
    }

    [Test]
    public void WithNegateXZ_ReturnsNewVectorWithNegatedXZ()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateXZ(), Is.EqualTo(new Vector3Int(-1, 2, -3)));
    }

    [Test]
    public void WithNegateYZ_ReturnsNewVectorWithNegatedYZ()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateYZ(), Is.EqualTo(new Vector3Int(1, -2, -3)));
    }

    [Test]
    public void Negate_ReturnsNewVectorWithAllValuesNegated()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.Negate(), Is.EqualTo(new Vector3Int(-1, -2, -3)));
    }

    [Test]
    public void Get_TwoAxes_ReturnsVector2IntWithSelectedValues()
    {
        var vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.Get(0, 1), Is.EqualTo(new Vector2Int(1, 2)));
        Assert.That(vector.Get(0, 2), Is.EqualTo(new Vector2Int(1, 3)));
        Assert.That(vector.Get(1, 2), Is.EqualTo(new Vector2Int(2, 3)));
    }

    [Test]
    public void GetXY_ReturnsVector2IntWithXYValues()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetXY(), Is.EqualTo(new Vector2Int(1, 2)));
    }

    [Test]
    public void GetXZ_ReturnsVector2IntWithXZValues()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetXZ(), Is.EqualTo(new Vector2Int(1, 3)));
    }

    [Test]
    public void GetYX_ReturnsVector2IntWithYXValues()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetYX(), Is.EqualTo(new Vector2Int(2, 1)));
    }

    [Test]
    public void GetYZ_ReturnsVector2IntWithYZValues()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetYZ(), Is.EqualTo(new Vector2Int(2, 3)));
    }

    [Test]
    public void GetZX_ReturnsVector2IntWithZXValues()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetZX(), Is.EqualTo(new Vector2Int(3, 1)));
    }

    [Test]
    public void GetZY_ReturnsVector2IntWithZYValues()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetZY(), Is.EqualTo(new Vector2Int(3, 2)));
    }

    [Test]
    public void Get_ThreeAxes_ReturnsNewVectorWithRearrangedValues()
    {
        var vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.Get(0, 1, 2), Is.EqualTo(new Vector3Int(1, 2, 3)));
        Assert.That(vector.Get(0, 2, 1), Is.EqualTo(new Vector3Int(1, 3, 2)));
        Assert.That(vector.Get(1, 0, 2), Is.EqualTo(new Vector3Int(2, 1, 3)));
        Assert.That(vector.Get(1, 2, 0), Is.EqualTo(new Vector3Int(2, 3, 1)));
        Assert.That(vector.Get(2, 0, 1), Is.EqualTo(new Vector3Int(3, 1, 2)));
        Assert.That(vector.Get(2, 1, 0), Is.EqualTo(new Vector3Int(3, 2, 1)));
    }

    [Test]
    public void GetXZY_ReturnsNewVectorWithXZYOrder()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetXZY(), Is.EqualTo(new Vector3Int(1, 3, 2)));
    }

    [Test]
    public void GetYXZ_ReturnsNewVectorWithYXZOrder()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetYXZ(), Is.EqualTo(new Vector3Int(2, 1, 3)));
    }

    [Test]
    public void GetYZX_ReturnsNewVectorWithYZXOrder()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetYZX(), Is.EqualTo(new Vector3Int(2, 3, 1)));
    }

    [Test]
    public void GetZXY_ReturnsNewVectorWithZXYOrder()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetZXY(), Is.EqualTo(new Vector3Int(3, 1, 2)));
    }

    [Test]
    public void GetZYX_ReturnsNewVectorWithZYXOrder()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetZYX(), Is.EqualTo(new Vector3Int(3, 2, 1)));
    }

    [Test]
    public void MaxComponent_ReturnsIndexOfMaxValue()
    {
        var vector = new Vector3Int(1, 3, 2);
        Assert.That(vector.MaxComponent().index, Is.EqualTo(1));
    }

    [Test]
    public void MinComponent_ReturnsIndexOfMinValue()
    {
        var vector = new Vector3Int(1, 3, 2);
        Assert.That(vector.MinComponent().index, Is.EqualTo(0));
    }

    [Test]
    public void Abs_ReturnsNewVectorWithAbsoluteValues()
    {
        var vector = new Vector3Int(-1, 2, -3);
        Assert.That(vector.Abs(), Is.EqualTo(new Vector3Int(1, 2, 3)));
    }

    [Test]
    public void Clamp_ReturnsNewVectorWithClampedValues()
    {
        var vector = new Vector3Int(1, 5, 9);
        Assert.That(vector.Clamp(2, 6), Is.EqualTo(new Vector3Int(2, 5, 6)));
    }

    [Test]
    public void Divide_ReturnsNewVectorWithDividedValues()
    {
        var vector = new Vector3Int(4, 6, 8);
        Assert.That(vector.Divide(new Vector3Int(2, 3, 4)), Is.EqualTo(new Vector3Int(2, 2, 2)));
    }

    [Test]
    public void IsUniform_AllComponentsAreEqual_ReturnsTrue()
    {
        var vector = new Vector3Int(2, 2, 2);
        Assert.That(vector.IsUniform(), Is.True);
    }

    [Test]
    public void IsUniform_ComponentsAreNotEqual_ReturnsFalse()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.IsUniform(), Is.False);
    }

    [Test]
    public void GetClosestPoint_ParamsArray_ReturnsClosestPointAndIndex()
    {
        var point = new Vector3Int(1, 1, 1);
        var points = new[]
        {
            new Vector3Int(0, 0, 0),
            new Vector3Int(1, 2, 2), // (1,2,2)이 (1,1,1)과 더 가깝도록 수정
            new Vector3Int(3, 3, 3),
        };
        var (closestPoint, index) = point.GetClosestPoint(points);

        Assert.That(closestPoint, Is.EqualTo(new Vector3Int(1, 2, 2)));
        Assert.That(index, Is.EqualTo(1));
    }

    [Test]
    public void GetClosestPoint_Enumerable_ReturnsClosestPointAndIndex()
    {
        var point = new Vector3Int(1, 1, 1);
        var points = new List<Vector3Int>
        {
            new Vector3Int(0, 0, 0),
            new Vector3Int(1, 2, 2), // (1,2,2)이 (1,1,1)과 더 가깝도록 수정
            new Vector3Int(3, 3, 3),
        };
        var (closestPoint, index) = point.GetClosestPoint(points);

        Assert.That(closestPoint, Is.EqualTo(new Vector3Int(1, 2, 2)));
        Assert.That(index, Is.EqualTo(1));
    }

    [Test]
    public void GetClosestPointOnRay_ReturnsClosestPointAndDistance()
    {
        var point = new Vector3Int(1, 1, 1);
        var origin = new Vector3(0, 0, 0);
        var direction = new Vector3(1, 1, 1).normalized;
        var (closestPoint, distance) = point.GetClosestPointOnRay(origin, direction);

        var expectedPoint = new Vector3(1f, 1f, 1f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create((a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1)
                )
        );
        Assert.That(distance, Is.EqualTo(0f).Within(1e-5f));
    }

    [Test]
    public void GetClosestPointOnSegment_ReturnsClosestPointAndDistance()
    {
        var point = new Vector3Int(1, 1, 1);
        var start = new Vector3(0, 0, 0);
        var end = new Vector3(2, 2, 2);
        var (closestPoint, distance) = point.GetClosestPointOnSegment(start, end);

        var expectedPoint = new Vector3(1f, 1f, 1f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create((a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1)
                )
        );
        Assert.That(distance, Is.EqualTo(0f).Within(1e-5f));
    }

    [Test]
    public void GetClosestPointOnRay_WhenClosestPointIsBeforeOrigin_ReturnsOriginAndCorrectDistance()
    {
        var point = new Vector3Int(-1, 0, 0);
        var origin = new Vector3(0, 0, 0);
        var direction = new Vector3(1, 0, 0).normalized;
        var (closestPoint, distance) = point.GetClosestPointOnRay(origin, direction);

        var expectedPoint = new Vector3(0f, 0f, 0f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create((a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1)
                )
        );
        Assert.That(distance, Is.EqualTo(1f).Within(1e-5f));
    }

    [Test]
    public void GetClosestPointOnRay_WhenPointIsOnRay_ReturnsPointAndZeroDistance()
    {
        var point = new Vector3Int(2, 2, 2);
        var origin = new Vector3(0, 0, 0);
        var direction = new Vector3(1, 1, 1).normalized;
        var (closestPoint, distance) = point.GetClosestPointOnRay(origin, direction);

        var expectedPoint = new Vector3(2f, 2f, 2f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create((a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1)
                )
        );
        Assert.That(distance, Is.EqualTo(0f).Within(1e-5f));
    }

    [Test]
    public void GetClosestPointOnSegment_WhenClosestPointIsEnd_ReturnsEndAndCorrectDistance()
    {
        var point = new Vector3Int(3, 3, 3);
        var start = new Vector3(0, 0, 0);
        var end = new Vector3(2, 2, 2);
        var (closestPoint, distance) = point.GetClosestPointOnSegment(start, end);

        var expectedPoint = new Vector3(2f, 2f, 2f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create((a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1)
                )
        );
        Assert.That(distance, Is.EqualTo(Mathf.Sqrt(3)).Within(1e-5f));
    }

    [Test]
    public void ToVector3_ReturnsEquivalentVector3()
    {
        var vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.ToVector3(), Is.EqualTo(new Vector3(1, 2, 3)));
    }
}
