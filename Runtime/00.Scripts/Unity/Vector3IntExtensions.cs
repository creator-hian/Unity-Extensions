using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hian.Extensions
{
    public static class Vector3IntExtensions
    {
        /// <summary>
        /// 벡터의 지정된 축에 값을 설정합니다.
        /// 이 메서드는 새로운 Vector3Int를 반환하며, 원래의 Vector3Int는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 설정할 축의 인덱스 (0: x, 1: y, 2: z).</param>
        /// <param name="value">설정할 값.</param>
        /// <returns>지정된 축의 값이 변경된 새 Vector3Int.</returns>
        /// <exception cref="ArgumentOutOfRangeException">축 인덱스가 0, 1, 2가 아닌 경우 발생합니다.</exception>
        public static Vector3Int With(this Vector3Int vector, int axis, int value)
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
        /// 이 메서드는 새로운 Vector3Int를 반환하며, 원래의 Vector3Int는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <returns>x 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithX(this Vector3Int vector, int x)
        {
            return new Vector3Int(x, vector.y, vector.z);
        }

        /// <summary>
        /// 벡터의 y 축에 값을 설정합니다.
        /// 이 메서드는 새로운 Vector3Int를 반환하며, 원래의 Vector3Int는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>y 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithY(this Vector3Int vector, int y)
        {
            return new Vector3Int(vector.x, y, vector.z);
        }

        /// <summary>
        /// 벡터의 z 축에 값을 설정합니다.
        /// 이 메서드는 새로운 Vector3Int를 반환하며, 원래의 Vector3Int는 변경되지 않습니다 (불변성).
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>z 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithZ(this Vector3Int vector, int z)
        {
            return new Vector3Int(vector.x, vector.y, z);
        }

        /// <summary>
        /// 벡터의 x, y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>x, y 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithXY(this Vector3Int vector, int x, int y)
        {
            return new Vector3Int(x, y, vector.z);
        }

        /// <summary>
        /// 벡터의 x, y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2Int 값.</param>
        /// <returns>x, y 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithXY(this Vector3Int vector, Vector2Int value)
        {
            return vector.WithXY(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 x, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>x, z 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithXZ(this Vector3Int vector, int x, int z)
        {
            return new Vector3Int(x, vector.y, z);
        }

        /// <summary>
        /// 벡터의 x, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2Int 값.</param>
        /// <returns>x, z 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithXZ(this Vector3Int vector, Vector2Int value)
        {
            return vector.WithXZ(value.x, value.y);
        }

        /// <summary>
        /// 벡터의 y, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <param name="z">설정할 z 값.</param>
        /// <returns>y, z 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithYZ(this Vector3Int vector, int y, int z)
        {
            return new Vector3Int(vector.x, y, z);
        }

        /// <summary>
        /// 벡터의 y, z 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="value">설정할 Vector2Int 값.</param>
        /// <returns>y, z 값이 변경된 새 Vector3Int.</returns>
        public static Vector3Int WithYZ(this Vector3Int vector, Vector2Int value)
        {
            return vector.WithYZ(value.x, value.y);
        }

        /// <summary>
        /// 지정된 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 반전할 축의 인덱스 (0: x, 1: y, 2: z).</param>
        /// <returns>지정된 축의 값이 반전된 새 Vector3Int.</returns>
        public static Vector3Int WithNegate(this Vector3Int vector, int axis) =>
            vector.With(axis, -vector[axis]);

        /// <summary>
        /// x 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x 축의 값이 반전된 새 Vector3Int.</returns>
        public static Vector3Int WithNegateX(this Vector3Int vector) => WithNegate(vector, 0);

        /// <summary>
        /// y 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y 축의 값이 반전된 새 Vector3Int.</returns>
        public static Vector3Int WithNegateY(this Vector3Int vector) => WithNegate(vector, 1);

        /// <summary>
        /// z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z 축의 값이 반전된 새 Vector3Int.</returns>
        public static Vector3Int WithNegateZ(this Vector3Int vector) => WithNegate(vector, 2);

        /// <summary>
        /// 지정된 두 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <returns>지정된 두 축의 값이 반전된 새 Vector3Int.</returns>
        public static Vector3Int WithNegate(this Vector3Int vector, int axis1, int axis2)
        {
            vector[axis1] = -vector[axis1];
            vector[axis2] = -vector[axis2];
            return vector;
        }

        /// <summary>
        /// x, y 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y 축의 값이 반전된 새 Vector3Int.</returns>
        public static Vector3Int WithNegateXY(this Vector3Int vector) => WithNegate(vector, 0, 1);

        /// <summary>
        /// x, z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z 축의 값이 반전된 새 Vector3Int.</returns>
        public static Vector3Int WithNegateXZ(this Vector3Int vector) => WithNegate(vector, 0, 2);

        /// <summary>
        /// y, z 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z 축의 값이 반전된 새 Vector3Int.</returns>
        public static Vector3Int WithNegateYZ(this Vector3Int vector) => WithNegate(vector, 1, 2);

        /// <summary>
        /// 벡터의 모든 성분을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 반전된 새 Vector3Int.</returns>
        public static Vector3Int Negate(this Vector3Int vector) =>
            new(-vector.x, -vector.y, -vector.z);

        /// <summary>
        /// 지정된 두 축의 값으로 이루어진 Vector2Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <returns>지정된 두 축의 값으로 이루어진 Vector2Int.</returns>
        public static Vector2Int Get(this Vector3Int vector, int axis1, int axis2) =>
            new(vector[axis1], vector[axis2]);

        /// <summary>
        /// x, y 축의 값으로 이루어진 Vector2Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, y 축의 값으로 이루어진 Vector2Int.</returns>
        public static Vector2Int GetXY(this Vector3Int vector) => Get(vector, 0, 1);

        /// <summary>
        /// x, z 축의 값으로 이루어진 Vector2Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z 축의 값으로 이루어진 Vector2Int.</returns>
        public static Vector2Int GetXZ(this Vector3Int vector) => Get(vector, 0, 2);

        /// <summary>
        /// y, x 축의 값으로 이루어진 Vector2Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x 축의 값으로 이루어진 Vector2Int.</returns>
        public static Vector2Int GetYX(this Vector3Int vector) => Get(vector, 1, 0);

        /// <summary>
        /// y, z 축의 값으로 이루어진 Vector2Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z 축의 값으로 이루어진 Vector2Int.</returns>
        public static Vector2Int GetYZ(this Vector3Int vector) => Get(vector, 1, 2);

        /// <summary>
        /// z, x 축의 값으로 이루어진 Vector2Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x 축의 값으로 이루어진 Vector2Int.</returns>
        public static Vector2Int GetZX(this Vector3Int vector) => Get(vector, 2, 0);

        /// <summary>
        /// z, y 축의 값으로 이루어진 Vector2Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y 축의 값으로 이루어진 Vector2Int.</returns>
        public static Vector2Int GetZY(this Vector3Int vector) => Get(vector, 2, 1);

        /// <summary>
        /// 지정된 세 축의 순서를 바꾼 새 Vector3Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis1">첫 번째 축의 인덱스.</param>
        /// <param name="axis2">두 번째 축의 인덱스.</param>
        /// <param name="axis3">세 번째 축의 인덱스.</param>
        /// <returns>지정된 세 축의 순서를 바꾼 새 Vector3Int.</returns>
        public static Vector3Int Get(this Vector3Int vector, int axis1, int axis2, int axis3) =>
            new(vector[axis1], vector[axis2], vector[axis3]);

        /// <summary>
        /// x, z, y 순서로 바꾼 새 Vector3Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x, z, y 순서로 바꾼 새 Vector3Int.</returns>
        public static Vector3Int GetXZY(this Vector3Int vector) => Get(vector, 0, 2, 1);

        /// <summary>
        /// y, x, z 순서로 바꾼 새 Vector3Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, x, z 순서로 바꾼 새 Vector3Int.</returns>
        public static Vector3Int GetYXZ(this Vector3Int vector) => Get(vector, 1, 0, 2);

        /// <summary>
        /// y, z, x 순서로 바꾼 새 Vector3Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y, z, x 순서로 바꾼 새 Vector3Int.</returns>
        public static Vector3Int GetYZX(this Vector3Int vector) => Get(vector, 1, 2, 0);

        /// <summary>
        /// z, x, y 순서로 바꾼 새 Vector3Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, x, y 순서로 바꾼 새 Vector3Int.</returns>
        public static Vector3Int GetZXY(this Vector3Int vector) => Get(vector, 2, 0, 1);

        /// <summary>
        /// z, y, x 순서로 바꾼 새 Vector3Int를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>z, y, x 순서로 바꾼 새 Vector3Int.</returns>
        public static Vector3Int GetZYX(this Vector3Int vector) => Get(vector, 2, 1, 0);

        /// <summary>
        /// 벡터에서 가장 큰 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 큰 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, int value) MaxComponent(this Vector3Int vector)
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
        public static (int index, int value) MinComponent(this Vector3Int vector)
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

        /// <summary>
        /// 벡터의 모든 성분을 절대값으로 변환합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 절대값으로 변환된 새 Vector3Int.</returns>
        public static Vector3Int Abs(this Vector3Int vector) =>
            new(Mathf.Abs(vector.x), Mathf.Abs(vector.y), Mathf.Abs(vector.z));

        /// <summary>
        /// 벡터의 모든 성분을 [min, max] 범위로 제한합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="min">최소값.</param>
        /// <param name="max">최대값.</param>
        /// <returns>모든 성분이 [min, max] 범위로 제한된 새 Vector3Int.</returns>
        public static Vector3Int Clamp(this Vector3Int vector, int min, int max)
        {
            return new Vector3Int(
                Mathf.Clamp(vector.x, min, max),
                Mathf.Clamp(vector.y, min, max),
                Mathf.Clamp(vector.z, min, max)
            );
        }

        /// <summary>
        /// 벡터의 모든 성분을 다른 벡터로 나눕니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="other">나눌 벡터.</param>
        /// <returns>모든 성분이 다른 벡터로 나누어진 새 Vector3Int.</returns>
        public static Vector3Int Divide(this Vector3Int vector, Vector3Int other) =>
            new(vector.x / other.x, vector.y / other.y, vector.z / other.z);

        /// <summary>
        /// 벡터의 모든 성분이 같은지 확인합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 같으면 true, 그렇지 않으면 false.</returns>
        public static bool IsUniform(this Vector3Int vector) =>
            vector.x == vector.y && vector.y == vector.z;

        /// <summary>
        /// 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="points">비교할 점들.</param>
        /// <returns>가장 가까운 점의 정보(점, 인덱스)를 포함하는 튜플.</returns>
        public static (Vector3Int point, int index) GetClosestPoint(
            this Vector3Int point,
            params Vector3Int[] points
        )
        {
            return GetClosestPoint(point, (IEnumerable<Vector3Int>)points);
        }

        /// <summary>
        /// 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="points">비교할 점들.</param>
        /// <returns>가장 가까운 점의 정보(점, 인덱스)를 포함하는 튜플.</returns>
        public static (Vector3Int point, int index) GetClosestPoint(
            this Vector3Int point,
            IEnumerable<Vector3Int> points
        )
        {
            var enumerator = points.GetEnumerator();

            var index = -1;
            var closestIndex = -1;
            Vector3Int closestPoint = Vector3Int.zero;
            var closestDistance = float.MaxValue;

            while (enumerator.MoveNext())
            {
                ++index;
                var distance = Vector3.Distance((Vector3)point, (Vector3)enumerator.Current);

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
            this Vector3Int point,
            Vector3 origin,
            Vector3 direction
        )
        {
            // Vector3Int를 Vector3로 암묵적 변환하여 처리
            return Vector3Extensions.GetClosestPointOnRay((Vector3)point, origin, direction);
        }

        /// <summary>
        /// 선분(Line Segment) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="start">선분의 시작점.</param>
        /// <param name="end">선분의 끝점.</param>
        /// <returns>선분 상의 가장 가까운 점의 정보(점, 거리)를 포함하는 튜플.</returns>
        public static (Vector3 point, float distance) GetClosestPointOnSegment(
            this Vector3Int point,
            Vector3 start,
            Vector3 end
        )
        {
            // Vector3Int를 Vector3로 암묵적 변환하여 처리
            return Vector3Extensions.GetClosestPointOnSegment((Vector3)point, start, end);
        }

        /// <summary>
        /// Vector3Int를 Vector3로 변환합니다.
        /// </summary>
        /// <param name="vector">변환할 Vector3Int.</param>
        /// <returns>변환된 Vector3.</returns>
        public static Vector3 ToVector3(this Vector3Int vector) => vector;
    }
}
