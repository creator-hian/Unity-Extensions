using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hian.Extensions
{
    public static class Vector2IntExtensions
    {
        /// <summary>
        /// 벡터의 지정된 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 설정할 축의 인덱스 (0: x, 1: y).</param>
        /// <param name="value">설정할 값.</param>
        /// <returns>지정된 축의 값이 변경된 새 Vector2Int.</returns>
        /// <exception cref="ArgumentOutOfRangeException">축 인덱스가 0 또는 1이 아닌 경우 발생합니다.</exception>
        public static Vector2Int With(this Vector2Int vector, int axis, int value)
        {
            switch (axis)
            {
                case 0:
                    return vector.WithX(value);
                case 1:
                    return vector.WithY(value);
                default:
                    throw new ArgumentOutOfRangeException(
                        "axis",
                        "축 인덱스는 0 또는 1이어야 합니다."
                    );
            }
        }

        /// <summary>
        /// 벡터의 x 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <returns>x 값이 변경된 새 Vector2Int.</returns>
        public static Vector2Int WithX(this Vector2Int vector, int x)
        {
            return new Vector2Int(x, vector.y);
        }

        /// <summary>
        /// 벡터의 y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>y 값이 변경된 새 Vector2Int.</returns>
        public static Vector2Int WithY(this Vector2Int vector, int y)
        {
            return new Vector2Int(vector.x, y);
        }

        /// <summary>
        /// 벡터의 x와 y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>x와 y 값이 변경된 새 Vector2Int.</returns>
        public static Vector2Int WithXY(this Vector2Int vector, int x, int y)
        {
            return new Vector2Int(x, y);
        }

        /// <summary>
        /// 지정된 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 반전할 축의 인덱스 (0: x, 1: y).</param>
        /// <returns>지정된 축의 값이 반전된 새 Vector2Int.</returns>
        public static Vector2Int WithNegate(this Vector2Int vector, int axis) =>
            vector.With(axis, -vector[axis]);

        /// <summary>
        /// x 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x 축의 값이 반전된 새 Vector2Int.</returns>
        public static Vector2Int WithNegateX(this Vector2Int vector) => WithNegate(vector, 0);

        /// <summary>
        /// y 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y 축의 값이 반전된 새 Vector2Int.</returns>
        public static Vector2Int WithNegateY(this Vector2Int vector) => WithNegate(vector, 1);

        /// <summary>
        /// 벡터의 모든 성분을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 반전된 새 Vector2Int.</returns>
        public static Vector2Int Negate(this Vector2Int vector) => new(-vector.x, -vector.y);

        /// <summary>
        /// 벡터에서 가장 큰 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 큰 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, int value) MaxComponent(this Vector2Int vector) =>
            vector.x >= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// 벡터에서 가장 작은 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 작은 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, int value) MinComponent(this Vector2Int vector) =>
            vector.x <= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// 벡터의 모든 성분을 다른 벡터로 나눕니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="other">나눌 벡터.</param>
        /// <returns>모든 성분이 다른 벡터로 나누어진 새 Vector2Int.</returns>
        public static Vector2Int Divide(this Vector2Int vector, Vector2Int other) =>
            new(vector.x / other.x, vector.y / other.y);

        /// <summary>
        /// 벡터의 모든 성분이 같은지 확인합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 같으면 true, 그렇지 않으면 false.</returns>
        public static bool IsUniform(this Vector2Int vector) => vector.x == vector.y;

        /// <summary>
        /// 대상 Vector2Int가 지정된 범위 내에 있는지 확인합니다.
        /// </summary>
        /// <param name="current">대상 Vector2Int.</param>
        /// <param name="target">범위의 중심이 되는 Vector2Int.</param>
        /// <param name="range">범위.</param>
        /// <returns>Vector2Int가 범위 내에 있으면 true, 그렇지 않으면 false.</returns>
        public static bool InRangeOf(this Vector2Int current, Vector2Int target, float range)
        {
            return Vector2Int.Distance(current, target) <= range;
        }

        /// <summary>
        /// Vector2Int의 각 컴포넌트를 절대값으로 변환합니다.
        /// </summary>
        /// <param name="vector">대상 Vector2Int.</param>
        /// <returns>각 컴포넌트가 절대값으로 변환된 새 Vector2Int.</returns>
        public static Vector2Int Abs(this Vector2Int vector) =>
            new(Mathf.Abs(vector.x), Mathf.Abs(vector.y));

        /// <summary>
        /// Vector2Int의 각 컴포넌트를 지정된 최소/최대 범위로 제한합니다.
        /// </summary>
        /// <param name="vector">대상 Vector2Int.</param>
        /// <param name="min">최소값.</param>
        /// <param name="max">최대값.</param>
        /// <returns>각 컴포넌트가 범위 내로 제한된 새 Vector2Int.</returns>
        /// <exception cref="ArgumentException">min이 max보다 큰 경우 발생합니다.</exception>
        public static Vector2Int Clamp(this Vector2Int vector, int min, int max)
        {
            if (min > max)
                throw new ArgumentException("min은 max보다 클 수 없습니다.");

            return new Vector2Int(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }

        /// <summary>
        /// Vector2Int를 시계 방향으로 90도 회전시킵니다.
        /// </summary>
        /// <param name="vector">회전시킬 Vector2Int.</param>
        /// <returns>회전된 Vector2Int.</returns>
        public static Vector2Int Rotate90Clockwise(this Vector2Int vector)
        {
            return new Vector2Int(vector.y, -vector.x);
        }

        /// <summary>
        /// Vector2Int를 반시계 방향으로 90도 회전시킵니다.
        /// </summary>
        /// <param name="vector">회전시킬 Vector2Int.</param>
        /// <returns>회전된 Vector2Int.</returns>
        public static Vector2Int Rotate90CounterClockwise(this Vector2Int vector)
        {
            return new Vector2Int(-vector.y, vector.x);
        }

        /// <summary>
        /// 두 Vector2Int 간의 내적을 계산합니다.
        /// </summary>
        /// <param name="vector">첫 번째 Vector2Int.</param>
        /// <param name="other">두 번째 Vector2Int.</param>
        /// <returns>두 Vector2Int의 내적.</returns>
        public static int Dot(this Vector2Int vector, Vector2Int other)
        {
            return vector.x * other.x + vector.y * other.y;
        }

        /// <summary>
        /// 두 Vector2Int 간의 외적을 계산합니다.
        /// </summary>
        /// <param name="vector">첫 번째 Vector2Int.</param>
        /// <param name="other">두 번째 Vector2Int.</param>
        /// <returns>두 Vector2Int의 외적.</returns>
        public static int Cross(this Vector2Int vector, Vector2Int other)
        {
            return vector.x * other.y - vector.y * other.x;
        }

        /// <summary>
        /// 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="points">비교할 점들.</param>
        /// <returns>가장 가까운 점의 정보(점, 인덱스)를 포함하는 튜플.</returns>
        public static (Vector2Int point, int index) GetClosestPoint(
            this Vector2Int point,
            params Vector2Int[] points
        )
        {
            return GetClosestPoint(point, (IEnumerable<Vector2Int>)points);
        }

        /// <summary>
        /// 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="points">비교할 점들.</param>
        /// <returns>가장 가까운 점의 정보(점, 인덱스)를 포함하는 튜플.</returns>
        public static (Vector2Int point, int index) GetClosestPoint(
            this Vector2Int point,
            IEnumerable<Vector2Int> points
        )
        {
            var enumerator = points.GetEnumerator();

            var index = -1;
            var closestIndex = -1;
            var closestPoint = Vector2Int.zero;
            var closestDistance = float.MaxValue;

            while (enumerator.MoveNext())
            {
                ++index;
                var distance = Vector2Int.Distance(point, enumerator.Current);

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
        public static (Vector2 point, float distance) GetClosestPointOnRay(
            this Vector2Int point,
            Vector2 origin,
            Vector2 direction
        )
        {
            return Vector2Extensions.GetClosestPointOnRay(point, origin, direction);
        }

        /// <summary>
        /// 선분(Line Segment) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="start">선분의 시작점.</param>
        /// <param name="end">선의 끝점.</param>
        /// <returns>선분 상의 가장 가까운 점의 정보(점, 거리)를 포함하는 튜플.</returns>
        public static (Vector2 point, float distance) GetClosestPointOnSegment(
            this Vector2Int point,
            Vector2 start,
            Vector2 end
        )
        {
            return Vector2Extensions.GetClosestPointOnSegment(point, start, end);
        }

        /// <summary>
        /// x 축에 값을 삽입하고 벡터를 3차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">x 축에 삽입할 값.</param>
        /// <returns>3차원 벡터.</returns>
        public static Vector3Int InsertX(this Vector2Int vector, int x = 0) =>
            new(x, vector.x, vector.y);

        /// <summary>
        /// y 축에 값을 삽입하고 벡터를 3차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">y 축에 삽입할 값.</param>
        /// <returns>3차원 벡터.</returns>
        public static Vector3Int InsertY(this Vector2Int vector, int y = 0) =>
            new(vector.x, y, vector.y);

        /// <summary>
        /// z 축에 값을 삽입하고 벡터를 3차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="z">z 축에 삽입할 값.</param>
        /// <returns>3차원 벡터.</returns>
        public static Vector3Int InsertZ(this Vector2Int vector, int z = 0) =>
            new(vector.x, vector.y, z);

        /// <summary>
        /// Vector2Int를 Vector2로 변환합니다.
        /// </summary>
        /// <param name="vector">변환할 Vector2Int.</param>
        /// <returns>변환된 Vector2.</returns>
        public static Vector2 ToVector2(this Vector2Int vector) => vector;

        /// <summary>
        /// Vector2Int를 Vector3Int로 변환합니다.
        /// </summary>
        /// <param name="vector">변환할 Vector2Int.</param>
        /// <returns>변환된 Vector3Int.</returns>
        public static Vector3Int ToVector3Int(this Vector2Int vector) =>
            new Vector3Int(vector.x, vector.y, 0);

        /// <summary>
        /// Vector2Int를 Vector3로 변환합니다.
        /// </summary>
        /// <param name="vector">변환할 Vector2Int.</param>
        /// <returns>변환된 Vector3.</returns>
        public static Vector3 ToVector3(this Vector2Int vector) =>
            new Vector3(vector.x, vector.y, 0);
    }
}
