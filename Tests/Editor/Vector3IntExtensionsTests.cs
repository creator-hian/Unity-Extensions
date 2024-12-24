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
        Vector3Int vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.With(0, 4), Is.EqualTo(new Vector3Int(4, 2, 3)));
        Assert.That(vector.With(1, 5), Is.EqualTo(new Vector3Int(1, 5, 3)));
        Assert.That(vector.With(2, 6), Is.EqualTo(new Vector3Int(1, 2, 6)));
    }

    [Test]
    public void With_InvalidAxis_ThrowsArgumentOutOfRangeException()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);

        _ = Assert.Throws<ArgumentOutOfRangeException>(() => vector.With(3, 4));
    }

    [Test]
    public void WithX_ReturnsNewVectorWithModifiedX()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithX(4), Is.EqualTo(new Vector3Int(4, 2, 3)));
    }

    [Test]
    public void WithY_ReturnsNewVectorWithModifiedY()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithY(4), Is.EqualTo(new Vector3Int(1, 4, 3)));
    }

    [Test]
    public void WithZ_ReturnsNewVectorWithModifiedZ()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithZ(4), Is.EqualTo(new Vector3Int(1, 2, 4)));
    }

    [Test]
    public void WithXY_WithTwoInts_ReturnsNewVectorWithModifiedXY()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithXY(4, 5), Is.EqualTo(new Vector3Int(4, 5, 3)));
    }

    [Test]
    public void WithXY_WithVector2Int_ReturnsNewVectorWithModifiedXY()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithXY(new Vector2Int(4, 5)), Is.EqualTo(new Vector3Int(4, 5, 3)));
    }

    [Test]
    public void WithXZ_WithTwoInts_ReturnsNewVectorWithModifiedXZ()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithXZ(4, 5), Is.EqualTo(new Vector3Int(4, 2, 5)));
    }

    [Test]
    public void WithXZ_WithVector2Int_ReturnsNewVectorWithModifiedXZ()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithXZ(new Vector2Int(4, 5)), Is.EqualTo(new Vector3Int(4, 2, 5)));
    }

    [Test]
    public void WithYZ_WithTwoInts_ReturnsNewVectorWithModifiedYZ()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithYZ(4, 5), Is.EqualTo(new Vector3Int(1, 4, 5)));
    }

    [Test]
    public void WithYZ_WithVector2Int_ReturnsNewVectorWithModifiedYZ()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithYZ(new Vector2Int(4, 5)), Is.EqualTo(new Vector3Int(1, 4, 5)));
    }

    [Test]
    public void WithNegate_ValidAxis_ReturnsNewVectorWithNegatedValue()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.WithNegate(0), Is.EqualTo(new Vector3Int(-1, 2, 3)));
        Assert.That(vector.WithNegate(1), Is.EqualTo(new Vector3Int(1, -2, 3)));
        Assert.That(vector.WithNegate(2), Is.EqualTo(new Vector3Int(1, 2, -3)));
    }

    [Test]
    public void WithNegateX_ReturnsNewVectorWithNegatedX()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateX(), Is.EqualTo(new Vector3Int(-1, 2, 3)));
    }

    [Test]
    public void WithNegateY_ReturnsNewVectorWithNegatedY()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateY(), Is.EqualTo(new Vector3Int(1, -2, 3)));
    }

    [Test]
    public void WithNegateZ_ReturnsNewVectorWithNegatedZ()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateZ(), Is.EqualTo(new Vector3Int(1, 2, -3)));
    }

    [Test]
    public void WithNegate_TwoAxes_ReturnsNewVectorWithNegatedValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.WithNegate(0, 1), Is.EqualTo(new Vector3Int(-1, -2, 3)));
        Assert.That(vector.WithNegate(0, 2), Is.EqualTo(new Vector3Int(-1, 2, -3)));
        Assert.That(vector.WithNegate(1, 2), Is.EqualTo(new Vector3Int(1, -2, -3)));
    }

    [Test]
    public void WithNegateXY_ReturnsNewVectorWithNegatedXY()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateXY(), Is.EqualTo(new Vector3Int(-1, -2, 3)));
    }

    [Test]
    public void WithNegateXZ_ReturnsNewVectorWithNegatedXZ()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateXZ(), Is.EqualTo(new Vector3Int(-1, 2, -3)));
    }

    [Test]
    public void WithNegateYZ_ReturnsNewVectorWithNegatedYZ()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.WithNegateYZ(), Is.EqualTo(new Vector3Int(1, -2, -3)));
    }

    [Test]
    public void Negate_ReturnsNewVectorWithAllValuesNegated()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.Negate(), Is.EqualTo(new Vector3Int(-1, -2, -3)));
    }

    [Test]
    public void Get_TwoAxes_ReturnsVector2IntWithSelectedValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);

        Assert.That(vector.Get(0, 1), Is.EqualTo(new Vector2Int(1, 2)));
        Assert.That(vector.Get(0, 2), Is.EqualTo(new Vector2Int(1, 3)));
        Assert.That(vector.Get(1, 2), Is.EqualTo(new Vector2Int(2, 3)));
    }

    [Test]
    public void GetXY_ReturnsVector2IntWithXYValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetXY(), Is.EqualTo(new Vector2Int(1, 2)));
    }

    [Test]
    public void GetXZ_ReturnsVector2IntWithXZValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetXZ(), Is.EqualTo(new Vector2Int(1, 3)));
    }

    [Test]
    public void GetYX_ReturnsVector2IntWithYXValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetYX(), Is.EqualTo(new Vector2Int(2, 1)));
    }

    [Test]
    public void GetYZ_ReturnsVector2IntWithYZValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetYZ(), Is.EqualTo(new Vector2Int(2, 3)));
    }

    [Test]
    public void GetZX_ReturnsVector2IntWithZXValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetZX(), Is.EqualTo(new Vector2Int(3, 1)));
    }

    [Test]
    public void GetZY_ReturnsVector2IntWithZYValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetZY(), Is.EqualTo(new Vector2Int(3, 2)));
    }

    [Test]
    public void Get_ThreeAxes_ReturnsNewVectorWithRearrangedValues()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);

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
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetXZY(), Is.EqualTo(new Vector3Int(1, 3, 2)));
    }

    [Test]
    public void GetYXZ_ReturnsNewVectorWithYXZOrder()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetYXZ(), Is.EqualTo(new Vector3Int(2, 1, 3)));
    }

    [Test]
    public void GetYZX_ReturnsNewVectorWithYZXOrder()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetYZX(), Is.EqualTo(new Vector3Int(2, 3, 1)));
    }

    [Test]
    public void GetZXY_ReturnsNewVectorWithZXYOrder()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetZXY(), Is.EqualTo(new Vector3Int(3, 1, 2)));
    }

    [Test]
    public void GetZYX_ReturnsNewVectorWithZYXOrder()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.GetZYX(), Is.EqualTo(new Vector3Int(3, 2, 1)));
    }

    [Test]
    public void MaxComponent_ReturnsIndexOfMaxValue()
    {
        Vector3Int vector = new Vector3Int(1, 3, 2);
        Assert.That(vector.MaxComponent().index, Is.EqualTo(1));
    }

    [Test]
    public void MinComponent_ReturnsIndexOfMinValue()
    {
        Vector3Int vector = new Vector3Int(1, 3, 2);
        Assert.That(vector.MinComponent().index, Is.EqualTo(0));
    }

    [Test]
    public void Abs_ReturnsNewVectorWithAbsoluteValues()
    {
        Vector3Int vector = new Vector3Int(-1, 2, -3);
        Assert.That(vector.Abs(), Is.EqualTo(new Vector3Int(1, 2, 3)));
    }

    [Test]
    public void Clamp_ReturnsNewVectorWithClampedValues()
    {
        Vector3Int vector = new Vector3Int(1, 5, 9);
        Assert.That(vector.Clamp(2, 6), Is.EqualTo(new Vector3Int(2, 5, 6)));
    }

    [Test]
    public void Divide_ReturnsNewVectorWithDividedValues()
    {
        Vector3Int vector = new Vector3Int(4, 6, 8);
        Assert.That(vector.Divide(new Vector3Int(2, 3, 4)), Is.EqualTo(new Vector3Int(2, 2, 2)));
    }

    [Test]
    public void IsUniform_AllComponentsAreEqual_ReturnsTrue()
    {
        Vector3Int vector = new Vector3Int(2, 2, 2);
        Assert.That(vector.IsUniform(), Is.True);
    }

    [Test]
    public void IsUniform_ComponentsAreNotEqual_ReturnsFalse()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.IsUniform(), Is.False);
    }

    [Test]
    public void GetClosestPoint_ParamsArray_ReturnsClosestPointAndIndex()
    {
        Vector3Int point = new Vector3Int(1, 1, 1);
        Vector3Int[] points = new[]
        {
            new Vector3Int(0, 0, 0),
            new Vector3Int(1, 2, 2), // (1,2,2)이 (1,1,1)과 더 가깝도록 수정
            new Vector3Int(3, 3, 3),
        };
        (Vector3Int closestPoint, int index) = point.GetClosestPoint(points);

        Assert.That(closestPoint, Is.EqualTo(new Vector3Int(1, 2, 2)));
        Assert.That(index, Is.EqualTo(1));
    }

    [Test]
    public void GetClosestPoint_Enumerable_ReturnsClosestPointAndIndex()
    {
        Vector3Int point = new Vector3Int(1, 1, 1);
        List<Vector3Int> points = new List<Vector3Int>
        {
            new Vector3Int(0, 0, 0),
            new Vector3Int(1, 2, 2), // (1,2,2)이 (1,1,1)과 더 가깝도록 수정
            new Vector3Int(3, 3, 3),
        };
        (Vector3Int closestPoint, int index) = point.GetClosestPoint(points);

        Assert.That(closestPoint, Is.EqualTo(new Vector3Int(1, 2, 2)));
        Assert.That(index, Is.EqualTo(1));
    }

    [Test]
    public void GetClosestPointOnRay_ReturnsClosestPointAndDistance()
    {
        Vector3Int point = new Vector3Int(1, 1, 1);
        Vector3 origin = new Vector3(0, 0, 0);
        Vector3 direction = new Vector3(1, 1, 1).normalized;
        (Vector3 closestPoint, float distance) = point.GetClosestPointOnRay(origin, direction);

        Vector3 expectedPoint = new Vector3(1f, 1f, 1f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create(
                        static (a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1
                    )
                )
        );
        Assert.That(distance, Is.EqualTo(0f).Within(1e-5f));
    }

    [Test]
    public void GetClosestPointOnSegment_ReturnsClosestPointAndDistance()
    {
        Vector3Int point = new Vector3Int(1, 1, 1);
        Vector3 start = new Vector3(0, 0, 0);
        Vector3 end = new Vector3(2, 2, 2);
        (Vector3 closestPoint, float distance) = point.GetClosestPointOnSegment(start, end);

        Vector3 expectedPoint = new Vector3(1f, 1f, 1f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create(
                        static (a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1
                    )
                )
        );
        Assert.That(distance, Is.EqualTo(0f).Within(1e-5f));
    }

    [Test]
    public void GetClosestPointOnRay_WhenClosestPointIsBeforeOrigin_ReturnsOriginAndCorrectDistance()
    {
        Vector3Int point = new Vector3Int(-1, 0, 0);
        Vector3 origin = new Vector3(0, 0, 0);
        Vector3 direction = new Vector3(1, 0, 0).normalized;
        (Vector3 closestPoint, float distance) = point.GetClosestPointOnRay(origin, direction);

        Vector3 expectedPoint = new Vector3(0f, 0f, 0f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create(
                        static (a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1
                    )
                )
        );
        Assert.That(distance, Is.EqualTo(1f).Within(1e-5f));
    }

    [Test]
    public void GetClosestPointOnRay_WhenPointIsOnRay_ReturnsPointAndZeroDistance()
    {
        Vector3Int point = new Vector3Int(2, 2, 2);
        Vector3 origin = new Vector3(0, 0, 0);
        Vector3 direction = new Vector3(1, 1, 1).normalized;
        (Vector3 closestPoint, float distance) = point.GetClosestPointOnRay(origin, direction);

        Vector3 expectedPoint = new Vector3(2f, 2f, 2f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create(
                        static (a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1
                    )
                )
        );
        Assert.That(distance, Is.EqualTo(0f).Within(1e-5f));
    }

    [Test]
    public void GetClosestPointOnSegment_WhenClosestPointIsEnd_ReturnsEndAndCorrectDistance()
    {
        Vector3Int point = new Vector3Int(3, 3, 3);
        Vector3 start = new Vector3(0, 0, 0);
        Vector3 end = new Vector3(2, 2, 2);
        (Vector3 closestPoint, float distance) = point.GetClosestPointOnSegment(start, end);

        Vector3 expectedPoint = new Vector3(2f, 2f, 2f);
        Assert.That(
            closestPoint,
            Is.EqualTo(expectedPoint)
                .Using<Vector3>(
                    Comparer<Vector3>.Create(
                        static (a, b) => Vector3.Distance(a, b) < 1e-5f ? 0 : 1
                    )
                )
        );
        Assert.That(distance, Is.EqualTo(Mathf.Sqrt(3)).Within(1e-5f));
    }

    [Test]
    public void ToVector3_ReturnsEquivalentVector3()
    {
        Vector3Int vector = new Vector3Int(1, 2, 3);
        Assert.That(vector.ToVector3(), Is.EqualTo(new Vector3(1, 2, 3)));
    }
}
