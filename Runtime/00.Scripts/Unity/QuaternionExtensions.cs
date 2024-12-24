using UnityEngine;

namespace Hian.Extensions
{
    /// <summary>
    /// Quaternion 구조체에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class QuaternionExtensions
    {
        /// <summary>
        /// 지정된 축에 <paramref name="value"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="axis">설정할 축.</param>
        /// <param name="value">설정할 값.</param>
        /// <returns>변경된 <paramref name="quaternion"/>의 복사본.</returns>
        public static Quaternion With(this Quaternion quaternion, int axis, float value)
        {
            quaternion[axis] = value;
            return quaternion;
        }

        /// <summary>
        /// x 축에 <paramref name="x"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="x">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithX(this Quaternion quaternion, float x)
        {
            return With(quaternion, 0, x);
        }

        /// <summary>
        /// y 축에 <paramref name="y"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="y">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithY(this Quaternion quaternion, float y)
        {
            return With(quaternion, 1, y);
        }

        /// <summary>
        /// z 축에 <paramref name="z"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="z">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithZ(this Quaternion quaternion, float z)
        {
            return With(quaternion, 2, z);
        }

        /// <summary>
        /// w 축에 <paramref name="w"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="w">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithW(this Quaternion quaternion, float w)
        {
            return With(quaternion, 3, w);
        }

        /// <summary>
        /// 지정된 축들에 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="axis1">설정할 첫 번째 축.</param>
        /// <param name="value1">설정할 첫 번째 값.</param>
        /// <param name="axis2">설정할 두 번째 축.</param>
        /// <param name="value2">설정할 두 번째 값.</param>
        /// <returns>변경된 <paramref name="quaternion"/>의 복사본.</returns>
        public static Quaternion With(
            this Quaternion quaternion,
            int axis1,
            float value1,
            int axis2,
            float value2
        )
        {
            quaternion[axis1] = value1;
            quaternion[axis2] = value2;
            return quaternion;
        }

        /// <summary>
        /// x, y 축에 각각 <paramref name="x"/>, <paramref name="y"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXY(this Quaternion quaternion, float x, float y)
        {
            return With(quaternion, 0, x, 1, y);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXY(this Quaternion quaternion, Vector2 values)
        {
            return With(quaternion, 0, values.x, 1, values.y);
        }

        /// <summary>
        /// x, z 축에 각각 <paramref name="x"/>, <paramref name="z"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXZ(this Quaternion quaternion, float x, float z)
        {
            return With(quaternion, 0, x, 2, z);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXZ(this Quaternion quaternion, Vector2 values)
        {
            return With(quaternion, 0, values.x, 2, values.y);
        }

        /// <summary>
        /// y, z 축에 각각 <paramref name="y"/>, <paramref name="z"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithYZ(this Quaternion quaternion, float y, float z)
        {
            return With(quaternion, 1, y, 2, z);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithYZ(this Quaternion quaternion, Vector2 values)
        {
            return With(quaternion, 1, values.x, 2, values.y);
        }

        /// <summary>
        /// x, w 축에 각각 <paramref name="x"/>, <paramref name="w"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="w">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXW(this Quaternion quaternion, float x, float w)
        {
            return With(quaternion, 0, x, 3, w);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXW(this Quaternion quaternion, Vector2 values)
        {
            return With(quaternion, 0, values.x, 3, values.y);
        }

        /// <summary>
        /// y, w 축에 각각 <paramref name="y"/>, <paramref name="w"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="w">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithYW(this Quaternion quaternion, float y, float w)
        {
            return With(quaternion, 1, y, 3, w);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithYW(this Quaternion quaternion, Vector2 values)
        {
            return With(quaternion, 1, values.x, 3, values.y);
        }

        /// <summary>
        /// z, w 축에 각각 <paramref name="z"/>, <paramref name="w"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="z">설정할 값.</param>
        /// <param name="w">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithZW(this Quaternion quaternion, float z, float w)
        {
            return With(quaternion, 2, z, 3, w);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithZW(this Quaternion quaternion, Vector2 values)
        {
            return With(quaternion, 2, values.x, 3, values.y);
        }

        /// <summary>
        /// 지정된 축들에 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="axis1">설정할 첫 번째 축.</param>
        /// <param name="value1">설정할 첫 번째 값.</param>
        /// <param name="axis2">설정할 두 번째 축.</param>
        /// <param name="value2">설정할 두 번째 값.</param>
        /// <param name="axis3">설정할 세 번째 축.</param>
        /// <param name="value3">설정할 세 번째 값.</param>
        /// <returns>변경된 <paramref name="quaternion"/>의 복사본.</returns>
        public static Quaternion With(
            this Quaternion quaternion,
            int axis1,
            float value1,
            int axis2,
            float value2,
            int axis3,
            float value3
        )
        {
            quaternion[axis1] = value1;
            quaternion[axis2] = value2;
            quaternion[axis3] = value3;
            return quaternion;
        }

        /// <summary>
        /// x, y, z 축에 각각 <paramref name="x"/>, <paramref name="y"/>, <paramref name="z"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXYZ(this Quaternion quaternion, float x, float y, float z)
        {
            return With(quaternion, 0, x, 1, y, 2, z);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXYZ(this Quaternion quaternion, Vector3 values)
        {
            return With(quaternion, 0, values.x, 1, values.y, 2, values.z);
        }

        /// <summary>
        /// x, y, w 축에 각각 <paramref name="x"/>, <paramref name="y"/>, <paramref name="w"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="w">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXYW(this Quaternion quaternion, float x, float y, float w)
        {
            return With(quaternion, 0, x, 1, y, 3, w);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXYW(this Quaternion quaternion, Vector3 values)
        {
            return With(quaternion, 0, values.x, 1, values.y, 3, values.z);
        }

        /// <summary>
        /// x, z, w 축에 각각 <paramref name="x"/>, <paramref name="z"/>, <paramref name="w"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="x">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        /// <param name="w">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXZW(this Quaternion quaternion, float x, float z, float w)
        {
            return With(quaternion, 0, x, 2, z, 3, w);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithXZW(this Quaternion quaternion, Vector3 values)
        {
            return With(quaternion, 0, values.x, 2, values.y, 3, values.z);
        }

        /// <summary>
        /// y, z, w 축에 각각 <paramref name="y"/>, <paramref name="z"/>, <paramref name="w"/> 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="y">설정할 값.</param>
        /// <param name="z">설정할 값.</param>
        /// <param name="w">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithYZW(this Quaternion quaternion, float y, float z, float w)
        {
            return With(quaternion, 1, y, 2, z, 3, w);
        }

        /// <summary>
        /// 지정된 축들에 <paramref name="values"/>의 컴포넌트 값을 설정합니다.
        /// </summary>
        /// <param name="quaternion">대상 Quaternion.</param>
        /// <param name="values">설정할 값.</param>
        /// <returns><see cref="With(Quaternion, int, float)"/>와 동일합니다.</returns>
        public static Quaternion WithYZW(this Quaternion quaternion, Vector3 values)
        {
            return With(quaternion, 1, values.x, 2, values.y, 3, values.z);
        }
    }
}
