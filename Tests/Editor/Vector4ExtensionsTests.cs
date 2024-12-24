using Hian.Extensions;
using NUnit.Framework;
using UnityEngine;

public class Vector4ExtensionsTests
{
    #region With

    [Test]
    public void With_Sets_X_Component()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithX(5);
        Assert.AreEqual(new Vector4(5, 2, 3, 4), result);
    }

    [Test]
    public void With_Sets_Y_Component()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithY(5);
        Assert.AreEqual(new Vector4(1, 5, 3, 4), result);
    }

    [Test]
    public void With_Sets_Z_Component()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithZ(5);
        Assert.AreEqual(new Vector4(1, 2, 5, 4), result);
    }

    [Test]
    public void With_Sets_W_Component()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithW(5);
        Assert.AreEqual(new Vector4(1, 2, 3, 5), result);
    }

    [Test]
    public void With_Sets_XY_Components()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithXY(5, 6);
        Assert.AreEqual(new Vector4(5, 6, 3, 4), result);
    }

    [Test]
    public void With_Sets_XY_Components_From_Vector2()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithXY(new Vector2(5, 6));
        Assert.AreEqual(new Vector4(5, 6, 3, 4), result);
    }

    // ... (WithXZ, WithXW, WithYZ, WithYW, WithZW, WithXYZ, WithXYW, WithXZW, WithYZW 테스트 케이스 추가) ...

    #endregion

    #region Negate

    [Test]
    public void WithNegate_Inverts_X_Component()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithNegateX();
        Assert.AreEqual(new Vector4(-1, 2, 3, 4), result);
    }

    [Test]
    public void WithNegate_Inverts_Y_Component()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithNegateY();
        Assert.AreEqual(new Vector4(1, -2, 3, 4), result);
    }

    [Test]
    public void WithNegate_Inverts_Z_Component()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithNegateZ();
        Assert.AreEqual(new Vector4(1, 2, -3, 4), result);
    }

    [Test]
    public void WithNegate_Inverts_W_Component()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithNegateW();
        Assert.AreEqual(new Vector4(1, 2, 3, -4), result);
    }

    [Test]
    public void WithNegate_Inverts_XY_Components()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.WithNegateXY();
        Assert.AreEqual(new Vector4(-1, -2, 3, 4), result);
    }

    // ... (WithNegateXZ, WithNegateXW, WithNegateYZ, WithNegateYW, WithNegateZW, WithNegateXYZ, WithNegateXYW, WithNegateXZW, WithNegateYZW 테스트 케이스 추가) ...

    [Test]
    public void Negate_Inverts_All_Components()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.Negate();
        Assert.AreEqual(new Vector4(-1, -2, -3, -4), result);
    }

    #endregion

    #region Get

    [Test]
    public void Get_Returns_XY_Components()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector2 result = vector.GetXY();
        Assert.AreEqual(new Vector2(1, 2), result);
    }

    [Test]
    public void Get_Returns_XZ_Components()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector2 result = vector.GetXZ();
        Assert.AreEqual(new Vector2(1, 3), result);
    }

    [Test]
    public void Get_Returns_XW_Components()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector2 result = vector.GetXW();
        Assert.AreEqual(new Vector2(1, 4), result);
    }

    // ... (GetYX, GetYZ, GetYW, GetZX, GetZY, GetZW, GetWX, GetWY, GetWZ 테스트 케이스 추가) ...

    [Test]
    public void Get_Returns_XYZ_Components()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector3 result = vector.GetXYZ();
        Assert.AreEqual(new Vector3(1, 2, 3), result);
    }

    // ... (GetXYW, GetXZY, GetXZW, GetXWY, GetXWZ, GetYXZ, GetYXW, GetYZX, GetYZW, GetYWX, GetYWZ, GetZXY, GetZXW, GetZYX, GetZYW, GetZWX, GetZWY, GetWXY, GetWXZ, GetWYX, GetWYZ, GetWZX, GetWZY 테스트 케이스 추가) ...

    [Test]
    public void Get_Returns_XYWZ_Components()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Vector4 result = vector.GetXYWZ();
        Assert.AreEqual(new Vector4(1, 2, 4, 3), result);
    }

    // ... (GetXZYW, GetXZWY, GetXWYZ, GetXWZY, GetYXZW, GetYXWZ, GetYZXW, GetYZWX, GetYWXZ, GetYWZX, GetZXYW, GetZXWY, GetZYXW, GetZYWX, GetZWXY, GetZWYX, GetWXYZ, GetWXZY, GetWYXZ, GetWYZX, GetWZXY, GetWZYX 테스트 케이스 추가) ...

    #endregion

    #region Min, Max

    [Test]
    public void MaxComponent_Returns_Index_And_Value_Of_Max_Component()
    {
        Vector4 vector = new Vector4(1, 5, 3, 2);
        (int index, float value) result = vector.MaxComponent();
        Assert.AreEqual((1, 5f), result);
    }

    [Test]
    public void MinComponent_Returns_Index_And_Value_Of_Min_Component()
    {
        Vector4 vector = new Vector4(1, 5, 3, 2);
        (int index, float value) result = vector.MinComponent();
        Assert.AreEqual((0, 1f), result);
    }

    #endregion

    #region Remap

    [Test]
    public void Remap_Remaps_All_Components()
    {
        Vector4 vector = new Vector4(0, 5, 10, 20);
        Vector4 result = vector.Remap(0, 10, 0, 100);
        Assert.AreEqual(new Vector4(0, 50, 100, 200), result);
    }

    #endregion

    #region Abs, Clamp, Clamp01, Divide, IsNaN, IsUniform

    [Test]
    public void Abs_Returns_Vector_With_Absolute_Values()
    {
        Vector4 vector = new Vector4(-1, 2, -3, 4);
        Vector4 result = vector.Abs();
        Assert.AreEqual(new Vector4(1, 2, 3, 4), result);
    }

    [Test]
    public void Clamp_Clamps_All_Components()
    {
        Vector4 vector = new Vector4(-1, 5, 15, 25);
        Vector4 result = vector.Clamp(0, 10);
        Assert.AreEqual(new Vector4(0, 5, 10, 10), result);
    }

    [Test]
    public void Clamp01_Clamps_All_Components_Between_0_And_1()
    {
        Vector4 vector = new Vector4(-1, 0.5f, 1.5f, 2.5f);
        Vector4 result = vector.Clamp01();
        Assert.AreEqual(new Vector4(0, 0.5f, 1, 1), result);
    }

    [Test]
    public void Divide_Divides_All_Components_By_Other_Vector()
    {
        Vector4 vector = new Vector4(10, 20, 30, 40);
        Vector4 other = new Vector4(2, 4, 5, 8);
        Vector4 result = vector.Divide(other);
        Assert.AreEqual(new Vector4(5, 5, 6, 5), result);
    }

    [Test]
    public void IsNaN_Returns_True_If_Any_Component_Is_NaN()
    {
        Vector4 vector = new Vector4(1, 2, float.NaN, 4);
        Assert.IsTrue(vector.IsNaN());
    }

    [Test]
    public void IsNaN_Returns_False_If_No_Component_Is_NaN()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Assert.IsFalse(vector.IsNaN());
    }

    [Test]
    public void IsUniform_Returns_True_If_All_Components_Are_Approximately_Equal()
    {
        Vector4 vector = new Vector4(1, 1.0000001f, 1.0000002f, 1.0000003f);
        Assert.IsTrue(vector.IsUniform());
    }

    [Test]
    public void IsUniform_Returns_False_If_Any_Component_Is_Not_Approximately_Equal()
    {
        Vector4 vector = new Vector4(1, 2, 3, 4);
        Assert.IsFalse(vector.IsUniform());
    }

    #endregion
}
