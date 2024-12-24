using System;
using UnityEngine;

namespace Hian.Extensions
{
    public static class Vector4Extensions
    {
        #region With

        /// <summary>
        /// 벡터의 지정된 축에 값을 설정합니다.
        /// 이 메서드는 새로운 Vector4를 반환하며, 원래의 Vector4는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 설정할 축의 인덱스 (0: x, 1: y, 2: z, 3: w).</param>
        /// <param name="value">설정할 값.</param>
        /// <returns>지정된 축의 값이 변경된 새 Vector4.</returns>
        /// <exception cref="ArgumentOutOfRangeException">축 인덱스가 0, 1, 2, 3이 아닌 경우 발생합니다.</exception>
        public static Vector4 With(this Vector4 vector, int axis, float value)
        {
            return axis switch
            {
                0 => vector.WithX(value),
                1 => vector.WithY(value),
                2 => vector.WithZ(value),
                3 => vector.WithW(value),
                _ => throw new ArgumentOutOfRangeException(
                    "axis",
                    "축 인덱스는 0, 1, 2, 3 중 하나여야 합니다."
                ),
            };
        }

        /// <summary>
        /// 벡터의 x 축에 값을 설정합니다.
        /// 이 메서드는 새로운 Vector4를 반환하며, 원래의 Vector4는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <returns>x 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithX(this Vector4 vector, float x)
        {
            return new Vector4(x, vector.y, vector.z, vector.w);
        }

        /// <summary>
        /// 벡터의 y 축에 값을 설정합니다.
        /// 이 메서드는 새로운 Vector4를 반환하며, 원래의 Vector4는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>y 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithY(this Vector4 vector, float y)
        {
            return new Vector4(vector.x, y, vector.z, vector.w);
        }

        /// <summary>
        /// 벡터의 z 축에 값을 설정합니다.
        /// 이 메서드는 새로운 Vector4를 반환하며, 원래의 Vector4는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>z 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithZ(this Vector4 vector, float z)
        {
            return new Vector4(vector.x, vector.y, z, vector.w);
        }

        /// <summary>
        /// 벡터의 w 축에 값을 설정합니다.
        /// 이 메서드는 새로운 Vector4를 반환하며, 원래의 Vector4는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="w">설정할 w 값.</param>
        /// <returns>w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithW(this Vector4 vector, float w)
        {
            return new Vector4(vector.x, vector.y, vector.z, w);
        }

        /// <summary>
        /// 벡터의 x, y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>x, y 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXY(this Vector4 vector, float x, float y)
        {
            return new Vector4(x, y, vector.z, vector.w);
        }

        /// <summary>
        /// 벡터의 x, y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>x, y 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXY(this Vector4 vector, Vector2 value)
        {
            return vector.WithXY(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 x, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>x, z 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXZ(this Vector4 vector, float x, float z)
        {
            return new Vector4(x, vector.y, z, vector.w);
        }

        /// <summary>
        /// 벡터의 x, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>x, z 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXZ(this Vector4 vector, Vector2 value)
        {
            return vector.WithXZ(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 x, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="w">설정할 w 값.</param>
        /// <returns>x, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXW(this Vector4 vector, float x, float w)
        {
            return new Vector4(x, vector.y, vector.z, w);
        }

        /// <summary>
        /// 벡터의 x, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>x, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXW(this Vector4 vector, Vector2 value)
        {
            return vector.WithXW(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 y, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>y, z 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithYZ(this Vector4 vector, float y, float z)
        {
            return new Vector4(vector.x, y, z, vector.w);
        }

        /// <summary>
        /// 벡터의 y, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>y, z 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithYZ(this Vector4 vector, Vector2 value)
        {
            return vector.WithYZ(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 y, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <param name="w">설정할 w 값.</param>
        /// <returns>y, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithYW(this Vector4 vector, float y, float w)
        {
            return new Vector4(vector.x, y, vector.z, w);
        }

        /// <summary>
        /// 벡터의 y, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>y, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithYW(this Vector4 vector, Vector2 value)
        {
            return vector.WithYW(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 z, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <param name="w">설정할 w 값.</param>
        /// <returns>z, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithZW(this Vector4 vector, float z, float w)
        {
            return new Vector4(vector.x, vector.y, z, w);
        }

        /// <summary>
        /// 벡터의 z, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>z, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithZW(this Vector4 vector, Vector2 value)
        {
            return vector.WithZW(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 x, y, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>x, y, z 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXYZ(this Vector4 vector, float x, float y, float z)
        {
            return new Vector4(x, y, z, vector.w);
        }

        /// <summary>
        /// 벡터의 x, y, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector3 값.</param>
        /// <returns>x, y, z 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXYZ(this Vector4 vector, Vector3 value)
        {
            return vector.WithXYZ(value.x, value.y, value.z);
        }

        /// <summary>
        /// 벡터의 x, y, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <param name="w">설정할 w 값.</param>
        /// <returns>x, y, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXYW(this Vector4 vector, float x, float y, float w)
        {
            return new Vector4(x, y, vector.z, w);
        }

        /// <summary>
        /// 벡터의 x, y, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector3 값.</param>
        /// <returns>x, y, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXYW(this Vector4 vector, Vector3 value)
        {
            return vector.WithXYW(value.x, value.y, value.z);
        }

        /// <summary>
        /// 벡터의 x, z, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <param name="w">설정할 w 값.</param>
        /// <returns>x, z, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXZW(this Vector4 vector, float x, float z, float w)
        {
            return new Vector4(x, vector.y, z, w);
        }

        /// <summary>
        /// 벡터의 x, z, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector3 값.</param>
        /// <returns>x, z, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithXZW(this Vector4 vector, Vector3 value)
        {
            return vector.WithXZW(value.x, value.y, value.z);
        }

        /// <summary>
        /// 벡터의 y, z, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <param name="w">설정할 w 값.</param>
        /// <returns>y, z, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithYZW(this Vector4 vector, float y, float z, float w)
        {
            return new Vector4(vector.x, y, z, w);
        }

        /// <summary>
        /// 벡터의 y, z, w 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector3 값.</param>
        /// <returns>y, z, w 값이 변경된 새 Vector4.</returns>
        public static Vector4 WithYZW(this Vector4 vector, Vector3 value)
        {
            return vector.WithYZW(value.x, value.y, value.z);
        }

        #endregion

        #region Negate

        /// <summary>
        /// 지정된 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 반전할 축의 인덱스 (0: x, 1: y, 2: z, 3: w).</param>
        /// <returns>지정된 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis)
        {
            return vector.With(axis, -vector[axis]);
        }

        /// <summary>
        /// x 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateX(this Vector4 vector)
        {
            return WithNegate(vector, 0);
        }

        /// <summary>
        /// y 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateY(this Vector4 vector)
        {
            return WithNegate(vector, 1);
        }

        /// <summary>
        /// z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateZ(this Vector4 vector)
        {
            return WithNegate(vector, 2);
        }

        /// <summary>
        /// w 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateW(this Vector4 vector)
        {
            return WithNegate(vector, 3);
        }

        /// <summary>
        /// 지정된 두 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <returns>지정된 두 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis1, int axis2)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];
            return vector;
        }

        /// <summary>
        /// x, y 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateXY(this Vector4 vector)
        {
            return WithNegate(vector, 0, 1);
        }

        /// <summary>
        /// x, z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateXZ(this Vector4 vector)
        {
            return WithNegate(vector, 0, 2);
        }

        /// <summary>
        /// x, w 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, w 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateXW(this Vector4 vector)
        {
            return WithNegate(vector, 0, 3);
        }

        /// <summary>
        /// y, z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateYZ(this Vector4 vector)
        {
            return WithNegate(vector, 1, 2);
        }

        /// <summary>
        /// y, w 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, w 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateYW(this Vector4 vector)
        {
            return WithNegate(vector, 1, 3);
        }

        /// <summary>
        /// z, w 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, w 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateZW(this Vector4 vector)
        {
            return WithNegate(vector, 2, 3);
        }

        /// <summary>
        /// 지정된 세 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <param name="axis3">세 번째 축의 인덱스.</param>
        /// <returns>지정된 세 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegate(this Vector4 vector, int axis1, int axis2, int axis3)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];
            vector[axis3] = -vector[axis3];
            return vector;
        }

        /// <summary>
        /// x, y, z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y, z 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateXYZ(this Vector4 vector)
        {
            return WithNegate(vector, 0, 1, 2);
        }

        /// <summary>
        /// x, y, w 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y, w 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateXYW(this Vector4 vector)
        {
            return WithNegate(vector, 0, 1, 3);
        }

        /// <summary>
        /// x, z, w 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z, w 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateXZW(this Vector4 vector)
        {
            return WithNegate(vector, 0, 2, 3);
        }

        /// <summary>
        /// y, z, w 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z, w 축의 값이 반전된 새 Vector4.</returns>
        public static Vector4 WithNegateYZW(this Vector4 vector)
        {
            return WithNegate(vector, 1, 2, 3);
        }

        /// <summary>
        /// 벡터의 모든 성분을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 반전된 새 Vector4.</returns>
        public static Vector4 Negate(this Vector4 vector)
        {
            return new(-vector.x, -vector.y, -vector.z, -vector.w);
        }

        #endregion

        #region Get

        /// <summary>
        /// 지정된 두 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <returns>지정된 두 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 Get(this Vector4 vector, int axis1, int axis2)
        {
            return new(vector[axis1], vector[axis2]);
        }

        /// <summary>
        /// x, y 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetXY(this Vector4 vector)
        {
            return Get(vector, 0, 1);
        }

        /// <summary>
        /// x, z 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetXZ(this Vector4 vector)
        {
            return Get(vector, 0, 2);
        }

        /// <summary>
        /// x, w 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, w 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetXW(this Vector4 vector)
        {
            return Get(vector, 0, 3);
        }

        /// <summary>
        /// y, x 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetYX(this Vector4 vector)
        {
            return Get(vector, 1, 0);
        }

        /// <summary>
        /// y, z 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetYZ(this Vector4 vector)
        {
            return Get(vector, 1, 2);
        }

        /// <summary>
        /// y, w 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, w 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetYW(this Vector4 vector)
        {
            return Get(vector, 1, 3);
        }

        /// <summary>
        /// z, x 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetZX(this Vector4 vector)
        {
            return Get(vector, 2, 0);
        }

        /// <summary>
        /// z, y 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetZY(this Vector4 vector)
        {
            return Get(vector, 2, 1);
        }

        /// <summary>
        /// z, w 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, w 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetZW(this Vector4 vector)
        {
            return Get(vector, 2, 3);
        }

        /// <summary>
        /// w, x 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, x 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetWX(this Vector4 vector)
        {
            return Get(vector, 3, 0);
        }

        /// <summary>
        /// w, y 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, y 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetWY(this Vector4 vector)
        {
            return Get(vector, 3, 1);
        }

        /// <summary>
        /// w, z 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, z 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetWZ(this Vector4 vector)
        {
            return Get(vector, 3, 2);
        }

        /// <summary>
        /// 지정된 세 축의 순서를 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <param name="axis3">세 번째 축의 인덱스.</param>
        /// <returns>지정된 세 축의 순서를 바꾼 새 Vector3.</returns>
        public static Vector3 Get(this Vector4 vector, int axis1, int axis2, int axis3)
        {
            return new(vector[axis1], vector[axis2], vector[axis3]);
        }

        /// <summary>
        /// x, y, z 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y, z 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetXYZ(this Vector4 vector)
        {
            return Get(vector, 0, 1, 2);
        }

        /// <summary>
        /// x, y, w 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y, w 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetXYW(this Vector4 vector)
        {
            return Get(vector, 0, 1, 3);
        }

        /// <summary>
        /// x, z, y 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z, y 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetXZY(this Vector4 vector)
        {
            return Get(vector, 0, 2, 1);
        }

        /// <summary>
        /// x, z, w 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z, w 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetXZW(this Vector4 vector)
        {
            return Get(vector, 0, 2, 3);
        }

        /// <summary>
        /// x, w, y 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, w, y 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetXWY(this Vector4 vector)
        {
            return Get(vector, 0, 3, 1);
        }

        /// <summary>
        /// x, w, z 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, w, z 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetXWZ(this Vector4 vector)
        {
            return Get(vector, 0, 3, 2);
        }

        /// <summary>
        /// y, x, z 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x, z 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetYXZ(this Vector4 vector)
        {
            return Get(vector, 1, 0, 2);
        }

        /// <summary>
        /// y, x, w 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x, w 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetYXW(this Vector4 vector)
        {
            return Get(vector, 1, 0, 3);
        }

        /// <summary>
        /// y, z, x 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z, x 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetYZX(this Vector4 vector)
        {
            return Get(vector, 1, 2, 0);
        }

        /// <summary>
        /// y, z, w 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z, w 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetYZW(this Vector4 vector)
        {
            return Get(vector, 1, 2, 3);
        }

        /// <summary>
        /// y, w, x 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, w, x 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetYWX(this Vector4 vector)
        {
            return Get(vector, 1, 3, 0);
        }

        /// <summary>
        /// y, w, z 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, w, z 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetYWZ(this Vector4 vector)
        {
            return Get(vector, 1, 3, 2);
        }

        /// <summary>
        /// z, x, y 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x, y 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetZXY(this Vector4 vector)
        {
            return Get(vector, 2, 0, 1);
        }

        /// <summary>
        /// z, x, w 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x, w 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetZXW(this Vector4 vector)
        {
            return Get(vector, 2, 0, 3);
        }

        /// <summary>
        /// z, y, x 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y, x 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetZYX(this Vector4 vector)
        {
            return Get(vector, 2, 1, 0);
        }

        /// <summary>
        /// z, y, w 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y, w 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetZYW(this Vector4 vector)
        {
            return Get(vector, 2, 1, 3);
        }

        /// <summary>
        /// z, w, x 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, w, x 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetZWX(this Vector4 vector)
        {
            return Get(vector, 2, 3, 0);
        }

        /// <summary>
        /// z, w, y 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, w, y 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetZWY(this Vector4 vector)
        {
            return Get(vector, 2, 3, 1);
        }

        /// <summary>
        /// w, x, y 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, x, y 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetWXY(this Vector4 vector)
        {
            return Get(vector, 3, 0, 1);
        }

        /// <summary>
        /// w, x, z 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, x, z 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetWXZ(this Vector4 vector)
        {
            return Get(vector, 3, 0, 2);
        }

        /// <summary>
        /// w, y, x 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, y, x 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetWYX(this Vector4 vector)
        {
            return Get(vector, 3, 1, 0);
        }

        /// <summary>
        /// w, y, z 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, y, z 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetWYZ(this Vector4 vector)
        {
            return Get(vector, 3, 1, 2);
        }

        /// <summary>
        /// w, z, x 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, z, x 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetWZX(this Vector4 vector)
        {
            return Get(vector, 3, 2, 0);
        }

        /// <summary>
        /// w, z, y 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, z, y 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetWZY(this Vector4 vector)
        {
            return Get(vector, 3, 2, 1);
        }

        /// <summary>
        /// 지정된 네 축의 순서를 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <param name="axis3">세 번째 축의 인덱스.</param>
        /// <param name="axis4">네 번째 축의 인덱스.</param>
        /// <returns>지정된 네 축의 순서를 바꾼 새 Vector4.</returns>
        public static Vector4 Get(this Vector4 vector, int axis1, int axis2, int axis3, int axis4)
        {
            return new(vector[axis1], vector[axis2], vector[axis3], vector[axis4]);
        }

        /// <summary>
        /// x, y, w, z 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y, w, z 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetXYWZ(this Vector4 vector)
        {
            return Get(vector, 0, 1, 3, 2);
        }

        /// <summary>
        /// x, z, y, w 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z, y, w 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetXZYW(this Vector4 vector)
        {
            return Get(vector, 0, 2, 1, 3);
        }

        /// <summary>
        /// x, z, w, y 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z, w, y 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetXZWY(this Vector4 vector)
        {
            return Get(vector, 0, 2, 3, 1);
        }

        /// <summary>
        /// x, w, y, z 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, w, y, z 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetXWYZ(this Vector4 vector)
        {
            return Get(vector, 0, 3, 1, 2);
        }

        /// <summary>
        /// x, w, z, y 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, w, z, y 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetXWZY(this Vector4 vector)
        {
            return Get(vector, 0, 3, 2, 1);
        }

        /// <summary>
        /// y, x, z, w 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x, z, w 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetYXZW(this Vector4 vector)
        {
            return Get(vector, 1, 0, 2, 3);
        }

        /// <summary>
        /// y, x, w, z 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x, w, z 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetYXWZ(this Vector4 vector)
        {
            return Get(vector, 1, 0, 3, 2);
        }

        /// <summary>
        /// y, z, x, w 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z, x, w 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetYZXW(this Vector4 vector)
        {
            return Get(vector, 1, 2, 0, 3);
        }

        /// <summary>
        /// y, z, w, x 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z, w, x 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetYZWX(this Vector4 vector)
        {
            return Get(vector, 1, 2, 3, 0);
        }

        /// <summary>
        /// y, w, x, z 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, w, x, z 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetYWXZ(this Vector4 vector)
        {
            return Get(vector, 1, 3, 0, 2);
        }

        /// <summary>
        /// y, w, z, x 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, w, z, x 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetYWZX(this Vector4 vector)
        {
            return Get(vector, 1, 3, 2, 0);
        }

        /// <summary>
        /// z, x, y, w 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x, y, w 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetZXYW(this Vector4 vector)
        {
            return Get(vector, 2, 0, 1, 3);
        }

        /// <summary>
        /// z, x, w, y 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x, w, y 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetZXWY(this Vector4 vector)
        {
            return Get(vector, 2, 0, 3, 1);
        }

        /// <summary>
        /// z, y, x, w 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y, x, w 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetZYXW(this Vector4 vector)
        {
            return Get(vector, 2, 1, 0, 3);
        }

        /// <summary>
        /// z, y, w, x 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y, w, x 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetZYWX(this Vector4 vector)
        {
            return Get(vector, 2, 1, 3, 0);
        }

        /// <summary>
        /// z, w, x, y 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, w, x, y 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetZWXY(this Vector4 vector)
        {
            return Get(vector, 2, 3, 0, 1);
        }

        /// <summary>
        /// z, w, y, x 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, w, y, x 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetZWYX(this Vector4 vector)
        {
            return Get(vector, 2, 3, 1, 0);
        }

        /// <summary>
        /// w, x, y, z 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, x, y, z 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetWXYZ(this Vector4 vector)
        {
            return Get(vector, 3, 0, 1, 2);
        }

        /// <summary>
        /// w, x, z, y 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, x, z, y 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetWXZY(this Vector4 vector)
        {
            return Get(vector, 3, 0, 2, 1);
        }

        /// <summary>
        /// w, y, x, z 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, y, x, z 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetWYXZ(this Vector4 vector)
        {
            return Get(vector, 3, 1, 0, 2);
        }

        /// <summary>
        /// w, y, z, x 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, y, z, x 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetWYZX(this Vector4 vector)
        {
            return Get(vector, 3, 1, 2, 0);
        }

        /// <summary>
        /// w, z, x, y 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, z, x, y 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetWZXY(this Vector4 vector)
        {
            return Get(vector, 3, 2, 0, 1);
        }

        /// <summary>
        /// w, z, y, x 순서로 바꾼 새 Vector4를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>w, z, y, x 순서로 바꾼 새 Vector4.</returns>
        public static Vector4 GetWZYX(this Vector4 vector)
        {
            return Get(vector, 3, 2, 1, 0);
        }

        #endregion

        #region Min, Max

        // result 값과 비교하여 index를 업데이트하는 도우미 함수
        private static void Compare(Vector4 vector, ref int index, int compareIndex, int result)
        {
            if (vector[compareIndex].CompareTo(vector[index]) == result)
            {
                index = compareIndex;
            }
        }

        // result 값과 비교하여 모든 컴포넌트를 비교하고 인덱스를 반환하는 도우미 함수
        private static int CompareAllComponents(Vector4 vector, int result)
        {
            int index = 0;

            Compare(vector, ref index, 1, result);
            Compare(vector, ref index, 2, result);
            Compare(vector, ref index, 3, result);

            return index;
        }

        /// <summary>
        /// 벡터에서 가장 큰 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 큰 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, float value) MaxComponent(this Vector4 vector)
        {
            int index = CompareAllComponents(vector, 1);
            return (index, vector[index]);
        }

        /// <summary>
        /// 벡터에서 가장 작은 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 작은 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, float value) MinComponent(this Vector4 vector)
        {
            int index = CompareAllComponents(vector, -1);
            return (index, vector[index]);
        }

        #endregion

        #region Remap

        /// <summary>
        /// 벡터의 모든 성분을 한 범위에서 다른 범위로 다시 매핑합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="min1">원래 범위의 최소값.</param>
        /// <param name="max1">원래 범위의 최대값.</param>
        /// <param name="min2">새로운 범위의 최소값.</param>
        /// <param name="max2">새로운 범위의 최대값.</param>
        /// <returns>모든 성분이 새로운 범위로 다시 매핑된 새 Vector4.</returns>
        public static Vector4 Remap(
            this Vector4 vector,
            float min1,
            float max1,
            float min2,
            float max2
        )
        {
            return new Vector4(
                vector.x.Remap(min1, max1, min2, max2),
                vector.y.Remap(min1, max1, min2, max2),
                vector.z.Remap(min1, max1, min2, max2),
                vector.w.Remap(min1, max1, min2, max2)
            );
        }

        #endregion

        #region Abs, Clamp, Clamp01, Divide, IsNaN, IsUniform

        /// <summary>
        /// 벡터의 모든 성분을 절대값으로 변환합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 절대값으로 변환된 새 Vector4.</returns>
        public static Vector4 Abs(this Vector4 vector)
        {
            return new(
                Mathf.Abs(vector.x),
                Mathf.Abs(vector.y),
                Mathf.Abs(vector.z),
                Mathf.Abs(vector.w)
            );
        }

        /// <summary>
        /// 벡터의 모든 성분을 [min, max] 범위로 제한합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="min">최소값.</param>
        /// <param name="max">최대값.</param>
        /// <returns>모든 성분이 [min, max] 범위로 제한된 새 Vector4.</returns>
        public static Vector4 Clamp(this Vector4 vector, float min, float max)
        {
            return new Vector4(
                Mathf.Clamp(vector.x, min, max),
                Mathf.Clamp(vector.y, min, max),
                Mathf.Clamp(vector.z, min, max),
                Mathf.Clamp(vector.w, min, max)
            );
        }

        /// <summary>
        /// 벡터의 모든 성분을 0과 1 사이로 제한합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 0과 1 사이로 제한된 새 Vector4.</returns>
        public static Vector4 Clamp01(this Vector4 vector)
        {
            return new Vector4(
                Mathf.Clamp01(vector.x),
                Mathf.Clamp01(vector.y),
                Mathf.Clamp01(vector.z),
                Mathf.Clamp01(vector.w)
            );
        }

        /// <summary>
        /// 벡터의 모든 성분을 다른 벡터로 나눕니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="other">나눌 벡터.</param>
        /// <returns>모든 성분이 다른 벡터로 나누어진 새 Vector4.</returns>
        public static Vector4 Divide(this Vector4 vector, Vector4 other)
        {
            return new(
                vector.x / other.x,
                vector.y / other.y,
                vector.z / other.z,
                vector.w / other.w
            );
        }

        /// <summary>
        /// 벡터에 NaN 성분이 있는지 확인합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>NaN 성분이 있으면 true, 그렇지 않으면 false.</returns>
        public static bool IsNaN(this Vector4 vector)
        {
            return float.IsNaN(vector.x)
                || float.IsNaN(vector.y)
                || float.IsNaN(vector.z)
                || float.IsNaN(vector.w);
        }

        /// <summary>
        /// 벡터의 모든 성분이 같은지 확인합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 같으면 true, 그렇지 않으면 false.</returns>
        public static bool IsUniform(this Vector4 vector)
        {
            return vector.x.Approx(vector.y)
                && vector.y.Approx(vector.z)
                && vector.z.Approx(vector.w);
        }

        #endregion
    }
}
