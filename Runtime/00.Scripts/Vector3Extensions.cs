using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Hian.Extensions
{
    public static class Vector3Extensions
    {
        #region With

        /// <summary>
        /// 벡터의 지정된 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 설정할 축의 인덱스 (0: x, 1: y, 2: z).</param>
        /// <param name="value">설정할 값.</param>
        /// <returns>지정된 축의 값이 변경된 새 Vector3.</returns>
        /// <exception cref="ArgumentOutOfRangeException">축 인덱스가 0, 1, 2가 아닌 경우 발생합니다.</exception>
        public static Vector3 With(this Vector3 vector, int axis, float value)
        {
            switch (axis)
            {
                case 0:
                    return vector.WithX(value);
                case 1:
                    return vector.WithY(value);
                case 2:
                    return vector.WithZ(value);
                default:
                    throw new ArgumentOutOfRangeException(
                        "axis",
                        "축 인덱스는 0, 1, 2 중 하나여야 합니다."
                    );
            }
        }

        /// <summary>
        /// 벡터의 x 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <returns>x 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithX(this Vector3 vector, float x)
        {
            return new Vector3(x, vector.y, vector.z);
        }

        /// <summary>
        /// 벡터의 y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>y 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithY(this Vector3 vector, float y)
        {
            return new Vector3(vector.x, y, vector.z);
        }

        /// <summary>
        /// 벡터의 z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>z 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithZ(this Vector3 vector, float z)
        {
            return new Vector3(vector.x, vector.y, z);
        }

        /// <summary>
        /// 벡터의 x, y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>x, y 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithXY(this Vector3 vector, float x, float y)
        {
            return new Vector3(x, y, vector.z);
        }

        /// <summary>
        /// 벡터의 x, y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>x, y 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithXY(this Vector3 vector, Vector2 value)
        {
            return vector.WithXY(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 x, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>x, z 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithXZ(this Vector3 vector, float x, float z)
        {
            return new Vector3(x, vector.y, z);
        }

        /// <summary>
        /// 벡터의 x, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>x, z 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithXZ(this Vector3 vector, Vector2 value)
        {
            return vector.WithXZ(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 y, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>y, z 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithYZ(this Vector3 vector, float y, float z)
        {
            return new Vector3(vector.x, y, z);
        }

        /// <summary>
        /// 벡터의 y, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2 값.</param>
        /// <returns>y, z 값이 변경된 새 Vector3.</returns>
        public static Vector3 WithYZ(this Vector3 vector, Vector2 value)
        {
            return vector.WithYZ(value.x, value.y);
        }

        #endregion

        #region Negate

        /// <summary>
        /// 지정된 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 반전할 축의 인덱스 (0: x, 1: y, 2: z).</param>
        /// <returns>지정된 축의 값이 반전된 새 Vector3.</returns>
        public static Vector3 WithNegate(this Vector3 vector, int axis) =>
            vector.With(axis, -vector[axis]);

        /// <summary>
        /// x 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x 축의 값이 반전된 새 Vector3.</returns>
        public static Vector3 WithNegateX(this Vector3 vector) => WithNegate(vector, 0);

        /// <summary>
        /// y 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y 축의 값이 반전된 새 Vector3.</returns>
        public static Vector3 WithNegateY(this Vector3 vector) => WithNegate(vector, 1);

        /// <summary>
        /// z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z 축의 값이 반전된 새 Vector3.</returns>
        public static Vector3 WithNegateZ(this Vector3 vector) => WithNegate(vector, 2);

        /// <summary>
        /// 지정된 두 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <returns>지정된 두 축의 값이 반전된 새 Vector3.</returns>
        public static Vector3 WithNegate(this Vector3 vector, int axis1, int axis2)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];
            return vector;
        }

        /// <summary>
        /// x, y 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y 축의 값이 반전된 새 Vector3.</returns>
        public static Vector3 WithNegateXY(this Vector3 vector) => WithNegate(vector, 0, 1);

        /// <summary>
        /// x, z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z 축의 값이 반전된 새 Vector3.</returns>
        public static Vector3 WithNegateXZ(this Vector3 vector) => WithNegate(vector, 0, 2);

        /// <summary>
        /// y, z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z 축의 값이 반전된 새 Vector3.</returns>
        public static Vector3 WithNegateYZ(this Vector3 vector) => WithNegate(vector, 1, 2);

        /// <summary>
        /// 벡터의 모든 성분을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 반전된 새 Vector3.</returns>
        public static Vector3 Negate(this Vector3 vector) => new(-vector.x, -vector.y, -vector.z);

        #endregion

        #region Get

        /// <summary>
        /// 지정된 두 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <returns>지정된 두 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 Get(this Vector3 vector, int axis1, int axis2) =>
            new(vector[axis1], vector[axis2]);

        /// <summary>
        /// x, y 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetXY(this Vector3 vector) => Get(vector, 0, 1);

        /// <summary>
        /// x, z 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetXZ(this Vector3 vector) => Get(vector, 0, 2);

        /// <summary>
        /// y, x 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetYX(this Vector3 vector) => Get(vector, 1, 0);

        /// <summary>
        /// y, z 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetYZ(this Vector3 vector) => Get(vector, 1, 2);

        /// <summary>
        /// z, x 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetZX(this Vector3 vector) => Get(vector, 2, 0);

        /// <summary>
        /// z, y 축의 값으로 이루어진 Vector2를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y 축의 값으로 이루어진 Vector2.</returns>
        public static Vector2 GetZY(this Vector3 vector) => Get(vector, 2, 1);

        /// <summary>
        /// 지정된 세 축의 순서를 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <param name="axis3">세 번째 축의 인덱스.</param>
        /// <returns>지정된 세 축의 순서를 바꾼 새 Vector3.</returns>
        public static Vector3 Get(this Vector3 vector, int axis1, int axis2, int axis3) =>
            new(vector[axis1], vector[axis2], vector[axis3]);

        /// <summary>
        /// x, z, y 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z, y 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetXZY(this Vector3 vector) => Get(vector, 0, 2, 1);

        /// <summary>
        /// y, x, z 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x, z 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetYXZ(this Vector3 vector) => Get(vector, 1, 0, 2);

        /// <summary>
        /// y, z, x 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z, x 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetYZX(this Vector3 vector) => Get(vector, 1, 2, 0);

        /// <summary>
        /// z, x, y 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x, y 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetZXY(this Vector3 vector) => Get(vector, 2, 0, 1);

        /// <summary>
        /// z, y, x 순서로 바꾼 새 Vector3를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y, x 순서로 바꾼 새 Vector3.</returns>
        public static Vector3 GetZYX(this Vector3 vector) => Get(vector, 2, 1, 0);

        #endregion

        #region Insert

        /// <summary>
        /// x 축에 값을 삽입하고 벡터를 4차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">x 축에 삽입할 값.</param>
        /// <returns>4차원 벡터.</returns>
        public static Vector4 InsertX(this Vector3 vector, float x = 0) =>
            new(x, vector.x, vector.y, vector.z);

        /// <summary>
        /// y 축에 값을 삽입하고 벡터를 4차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">y 축에 삽입할 값.</param>
        /// <returns>4차원 벡터.</returns>
        public static Vector4 InsertY(this Vector3 vector, float y = 0) =>
            new(vector.x, y, vector.y, vector.z);

        /// <summary>
        /// z 축에 값을 삽입하고 벡터를 4차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="z">z 축에 삽입할 값.</param>
        /// <returns>4차원 벡터.</returns>
        public static Vector4 InsertZ(this Vector3 vector, float z = 0) =>
            new(vector.x, vector.y, z, vector.z);

        /// <summary>
        /// w 축에 값을 삽입하고 벡터를 4차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="w">w 축에 삽입할 값.</param>
        /// <returns>4차원 벡터.</returns>
        public static Vector4 InsertW(this Vector3 vector, float w = 0) =>
            new(vector.x, vector.y, vector.z, w);

        #endregion

        #region Min, Max

        /// <summary>
        /// 벡터에서 가장 큰 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 큰 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, float value) MaxComponent(this Vector3 vector)
        {
            var index = 0;
            for (var i = 1; i < 3; i++)
            {
                if (vector[i] > vector[index])
                {
                    index = i;
                }
            }

            return (index, vector[index]);
        }

        /// <summary>
        /// 벡터에서 가장 작은 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 작은 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, float value) MinComponent(this Vector3 vector)
        {
            var index = 0;
            for (var i = 1; i < 3; i++)
            {
                if (vector[i] < vector[index])
                {
                    index = i;
                }
            }

            return (index, vector[index]);
        }

        #endregion

        #region Remap

        /// <summary>
        /// 벡터의 모든 성분을 [min1, max1] 범위에서 [min2, max2] 범위로 재매핑합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="min1">재매핑 전 최소값.</param>
        /// <param name="max1">재매핑 전 최대값.</param>
        /// <param name="min2">재매핑 후 최소값.</param>
        /// <param name="max2">재매핑 후 최대값.</param>
        /// <returns>재매핑된 Vector3.</returns>
        public static Vector3 Remap(
            this Vector3 vector,
            float min1,
            float max1,
            float min2,
            float max2
        )
        {
            return new Vector3(
                vector.x.Remap(min1, max1, min2, max2),
                vector.y.Remap(min1, max1, min2, max2),
                vector.z.Remap(min1, max1, min2, max2)
            );
        }

        #endregion

        #region Abs, Clamp, Clamp01, Divide, IsUniform

        /// <summary>
        /// 벡터의 모든 성분을 절대값으로 변환합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 절대값으로 변환된 새 Vector3.</returns>
        public static Vector3 Abs(this Vector3 vector) =>
            new(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));

        /// <summary>
        /// 벡터의 모든 성분을 [min, max] 범위로 제한합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="min">최소값.</param>
        /// <param name="max">최대값.</param>
        /// <returns>모든 성분이 [min, max] 범위로 제한된 새 Vector3.</returns>
        public static Vector3 Clamp(this Vector3 vector, float min, float max)
        {
            return new Vector3(
                Mathf.Clamp(vector.x, min, max),
                Mathf.Clamp(vector.y, min, max),
                Mathf.Clamp(vector.z, min, max)
            );
        }

        /// <summary>
        /// 벡터의 모든 성분을 0과 1 사이로 제한합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 0과 1 사이로 제한된 새 Vector3.</returns>
        public static Vector3 Clamp01(this Vector3 vector)
        {
            return new Vector3(
                Mathf.Clamp01(vector.x),
                Mathf.Clamp01(vector.y),
                Mathf.Clamp01(vector.z)
            );
        }

        /// <summary>
        /// 벡터의 모든 성분을 다른 벡터로 나눕니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="other">나눌 벡터.</param>
        /// <returns>모든 성분이 다른 벡터로 나누어진 새 Vector3.</returns>
        public static Vector3 Divide(this Vector3 vector, Vector3 other) =>
            new(vector.x / other.x, vector.y / other.y, vector.z / other.z);

        /// <summary>
        /// 벡터의 모든 성분이 같은지 확인합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 같으면 true, 그렇지 않으면 false.</returns>
        public static bool IsUniform(this Vector3 vector) =>
            vector.x.Approx(vector.y) && vector.y.Approx(vector.z);

        #endregion

        #region EventlyDistributedPointOnSphere

        // TODO: 해당 메소드가 요구하는 바에 대하여 정확한 구현 및 검증이 되지 아니하였음.
        // /// <summary>
        // /// 구 표면에 고르게 분포된 점을 생성합니다.
        // /// </summary>
        // /// <param name="index">점의 인덱스.</param>
        // /// <param name="radius">구의 반지름.</param>
        // /// <param name="count">구 표면에 생성할 점의 총 개수.</param>
        // /// <returns>구 표면에 고르게 분포된 점의 위치.</returns>
        // public static Vector3 EventlyDistributedPointOnSphere(int index, float radius, int count)
        // {
        //     var k = index + 0.5f;
        //     var phi = Mathf.Acos(1f - 2f * k / count);
        //     var theta = Mathf.PI * (1 + Mathf.Sqrt(5)) * k;

        //     var x = Mathf.Cos(theta) * Mathf.Sin(phi);
        //     var y = Mathf.Sin(theta) * Mathf.Sin(phi);
        //     var z = Mathf.Cos(phi);

        //     return new Vector3(x, y, z) * radius;
        // }

        #endregion

        #region GetClosestPoint

        /// <summary>
        /// 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="points">비교할 점들.</param>
        /// <returns>가장 가까운 점의 정보(점, 인덱스)를 포함하는 튜플.</returns>
        public static (Vector3 point, int index) GetClosestPoint(
            this Vector3 point,
            params Vector3[] points
        )
        {
            return GetClosestPoint(point, (IEnumerable<Vector3>)points);
        }

        /// <summary>
        /// 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="points">비교할 점들.</param>
        /// <returns>가장 가까운 점의 정보(점, 인덱스)를 포함하는 튜플.</returns>
        public static (Vector3 point, int index) GetClosestPoint(
            this Vector3 point,
            IEnumerable<Vector3> points
        )
        {
            var enumerator = points.GetEnumerator();

            var index = -1;
            var closestIndex = -1;
            var closestPoint = Vector3.zero;
            var closestDistance = float.MaxValue;

            while (enumerator.MoveNext())
            {
                ++index;
                var distance = Vector3.Distance(point, enumerator.Current);

                if (distance < closestDistance)
                {
                    closestIndex = index;
                    closestDistance = distance;
                    closestPoint = enumerator.Current;
                }
            }

            return (closestPoint, closestIndex);
        }

        /// <summary>
        /// 광선(Ray) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="origin">광선의 시작점.</param>
        /// <param name="direction">광선의 방향(정규화되어야 함).</param>
        /// <returns>광선 상의 가장 가까운 점의 정보(점, 거리)를 포함하는 튜플.</returns>
        public static (Vector3 point, float distance) GetClosestPointOnRay(
            this Vector3 point,
            Vector3 origin,
            Vector3 direction
        )
        {
            if (direction == Vector3.zero)
                throw new ArgumentException("Direction vector cannot be zero.", nameof(direction));

            Vector3 normalizedDirection = direction.normalized;
            float scalarProjection = Vector3.Dot(point - origin, normalizedDirection);

            // 클램핑: scalarProjection이 0보다 작으면 0으로 설정
            float clampedProjection = Mathf.Max(scalarProjection, 0f);

            Vector3 closestPoint = origin + normalizedDirection * clampedProjection;

            // 유클리드 거리 계산
            float euclideanDistance = Vector3.Distance(point, closestPoint);

            return (closestPoint, euclideanDistance);
        }

        /// <summary>
        /// 광선(Ray) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="ray">광선.</param>
        /// <returns>광선 상의 가장 가까운 점의 정보(점, 거리)를 포함하는 튜플.</returns>
        public static (Vector3 point, float distance) GetClosestPointOnRay(
            this Vector3 point,
            Ray ray
        )
        {
            return point.GetClosestPointOnRay(ray.origin, ray.direction);
        }

        /// <summary>
        /// 선분(Line Segment) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="start">선분의 시작점.</param>
        /// <param name="end">선분의 끝점.</param>
        /// <returns>선분 상의 가장 가까운 점의 정보(점, 거리)를 포함하는 튜플.</returns>
        public static (Vector3 point, float distance) GetClosestPointOnSegment(
            this Vector3 point,
            Vector3 start,
            Vector3 end
        )
        {
            Vector3 direction = end - start;
            float lineMagnitude = direction.magnitude;

            if (lineMagnitude == 0)
                throw new ArgumentException(
                    "Start and end points cannot be the same.",
                    nameof(end)
                );

            Vector3 normalizedDirection = direction / lineMagnitude;

            float scalarProjection = Vector3.Dot(point - start, normalizedDirection);
            float clampedProjection = Mathf.Clamp(scalarProjection, 0f, lineMagnitude);
            Vector3 closestPoint = start + normalizedDirection * clampedProjection;

            // 유클리드 거리 계산
            float euclideanDistance = Vector3.Distance(point, closestPoint);

            return (closestPoint, euclideanDistance);
        }

        #endregion

        #region RandomDeflected

        /// <summary>
        /// 주어진 각도만큼 방향 벡터를 임의로 편향시킵니다.
        /// </summary>
        /// <param name="direction">대상 방향 벡터.</param>
        /// <param name="angle">편향시킬 각도.</param>
        /// <returns>편향된 방향 벡터.</returns>
        public static Vector3 RandomDeflected(this Vector3 direction, float angle) =>
            RandomDeflected(direction, new Vector2(angle, angle), Vector3.up);

        /// <summary>
        /// 주어진 각도만큼 방향 벡터를 임의로 편향시킵니다. (지정된 축 기준)
        /// </summary>
        /// <param name="direction">대상 방향 벡터.</param>
        /// <param name="angle">편향시킬 각도.</param>
        /// <param name="up">기준 축.</param>
        /// <returns>편향된 방향 벡터.</returns>
        public static Vector3 RandomDeflected(this Vector3 direction, float angle, Vector3 up) =>
            RandomDeflected(direction, new Vector2(angle, angle), up);

        /// <summary>
        /// 주어진 각도(x, y)만큼 방향 벡터를 임의로 편향시킵니다.
        /// </summary>
        /// <param name="direction">대상 방향 벡터.</param>
        /// <param name="angleX">x축으로 편향시킬 각도.</param>
        /// <param name="angleY">y축으로 편향시킬 각도.</param>
        /// <returns>편향된 방향 벡터.</returns>
        public static Vector3 RandomDeflected(this Vector3 direction, float angleX, float angleY) =>
            RandomDeflected(direction, new Vector2(angleX, angleY), Vector3.up);

        /// <summary>
        /// 주어진 각도(x, y)만큼 방향 벡터를 임의로 편향시킵니다. (지정된 축 기준)
        /// </summary>
        /// <param name="direction">대상 방향 벡터.</param>
        /// <param name="angleX">x축으로 편향시킬 각도.</param>
        /// <param name="angleY">y축으로 편향시킬 각도.</param>
        /// <param name="up">기준 축.</param>
        /// <returns>편향된 방향 벡터.</returns>
        public static Vector3 RandomDeflected(
            this Vector3 direction,
            float angleX,
            float angleY,
            Vector3 up
        ) => RandomDeflected(direction, new Vector2(angleX, angleY), up);

        /// <summary>
        /// 주어진 각도(Vector2)만큼 방향 벡터를 임의로 편향시킵니다.
        /// </summary>
        /// <param name="direction">대상 방향 벡터.</param>
        /// <param name="angles">x, y축으로 편향시킬 각도를 포함한 Vector2.</param>
        /// <returns>편향된 방향 벡터.</returns>
        public static Vector3 RandomDeflected(this Vector3 direction, Vector2 angles) =>
            RandomDeflected(direction, angles, Vector3.up);

        /// <summary>
        /// 주어진 각도(Vector2)만큼 방향 벡터를 임의로 편향시킵니다. (지정된 축 기준)
        /// </summary>
        /// <param name="direction">대상 방향 벡터.</param>
        /// <param name="angles">x, y축으로 편향시킬 각도를 포함한 Vector2.</param>
        /// <param name="up">기준 축.</param>
        /// <returns>편향된 방향 벡터.</returns>
        public static Vector3 RandomDeflected(this Vector3 direction, Vector2 angles, Vector3 up)
        {
            var randomAngles = Random.insideUnitCircle;
            randomAngles.Scale(angles);

            return Quaternion.LookRotation(direction, up)
                * Quaternion.Euler(randomAngles.y, randomAngles.x, 0f)
                * Vector3.forward;
        }

        #endregion
    }
}
