using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Hian.Extensions
{
    public static class Vector2Extensions
    {
        #region With

        /// <summary>
        /// 벡터의 지정된 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 설정할 축의 인덱스 (0: x, 1: y).</param>
        /// <param name="value">설정할 값.</param>
        /// <returns>지정된 축의 값이 변경된 새 Vector2.</returns>
        /// <exception cref="ArgumentOutOfRangeException">축 인덱스가 0 또는 1이 아닌 경우 발생합니다.</exception>
        public static Vector2 With(this Vector2 vector, int axis, float value)
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
        /// <returns>x 값이 변경된 새 Vector2.</returns>
        public static Vector2 WithX(this Vector2 vector, float x)
        {
            return new Vector2(x, vector.y);
        }

        /// <summary>
        /// 벡터의 y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>y 값이 변경된 새 Vector2.</returns>
        public static Vector2 WithY(this Vector2 vector, float y)
        {
            return new Vector2(vector.x, y);
        }

        /// <summary>
        /// 벡터의 x와 y 축에 값을 설정합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">설정할 x 값.</param>
        /// <param name="y">설정할 y 값.</param>
        /// <returns>x와 y 값이 변경된 새 Vector2.</returns>
        public static Vector2 WithXY(this Vector2 vector, float x, float y)
        {
            return new Vector2(x, y);
        }

        #endregion

        #region Negate

        /// <summary>
        /// 지정된 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="axis">값을 반전할 축의 인덱스 (0: x, 1: y).</param>
        /// <returns>지정된 축의 값이 반전된 새 Vector2.</returns>
        public static Vector2 WithNegate(this Vector2 vector, int axis) =>
            vector.With(axis, -vector[axis]);

        /// <summary>
        /// x 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x 축의 값이 반전된 새 Vector2.</returns>
        public static Vector2 WithNegateX(this Vector2 vector) => WithNegate(vector, 0);

        /// <summary>
        /// y 축의 값을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>y 축의 값이 반전된 새 Vector2.</returns>
        public static Vector2 WithNegateY(this Vector2 vector) => WithNegate(vector, 1);

        /// <summary>
        /// 벡터의 모든 성분을 반전합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 반전된 새 Vector2.</returns>
        public static Vector2 Negate(this Vector2 vector) => new(-vector.x, -vector.y);

        #endregion

        #region Min, Max

        /// <summary>
        /// 벡터에서 가장 큰 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 큰 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, float value) MaxComponent(this Vector2 vector) =>
            vector.x >= vector.y ? (0, vector.x) : (1, vector.y);

        /// <summary>
        /// 벡터에서 가장 작은 성분의 인덱스와 값을 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>가장 작은 성분의 인덱스와 값을 포함하는 튜플.</returns>
        public static (int index, float value) MinComponent(this Vector2 vector) =>
            vector.x <= vector.y ? (0, vector.x) : (1, vector.y);

        #endregion

        #region Clamp, Remap

        /// <summary>
        /// 벡터의 모든 성분을 한 범위에서 다른 범위로 다시 매핑합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="min1">원래 범위의 최소값.</param>
        /// <param name="max1">원래 범위의 최대값.</param>
        /// <param name="min2">새로운 범위의 최소값.</param>
        /// <param name="max2">새로운 범위의 최대값.</param>
        /// <returns>모든 성분이 새로운 범위로 다시 매핑된 새 Vector2.</returns>
        public static Vector2 Remap(
            this Vector2 vector,
            float min1,
            float max1,
            float min2,
            float max2
        )
        {
            return new Vector2(
                Remap(vector.x, min1, max1, min2, max2),
                Remap(vector.y, min1, max1, min2, max2)
            );
        }

        /// <summary>
        /// Vector2의 각 컴포넌트를 지정된 최소/최대 범위로 제한합니다.
        /// </summary>
        /// <param name="vector">대상 Vector2.</param>
        /// <param name="min">최소값.</param>
        /// <param name="max">최대값.</param>
        /// <returns>각 컴포넌트가 범위 내로 제한된 새 Vector2.</returns>
        /// <exception cref="ArgumentException">min이 max보다 큰 경우 발생합니다.</exception>
        public static Vector2 Clamp(this Vector2 vector, float min, float max)
        {
            if (min > max)
                throw new ArgumentException("min은 max보다 클 수 없습니다.");

            return new Vector2(Mathf.Clamp(vector.x, min, max), Mathf.Clamp(vector.y, min, max));
        }

        /// <summary>
        /// 벡터의 모든 성분을 0과 1 사이로 제한합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 0과 1 사이로 제한된 새 Vector2.</returns>
        public static Vector2 Clamp01(this Vector2 vector)
        {
            return new Vector2(Mathf.Clamp01(vector.x), Mathf.Clamp01(vector.y));
        }

        #endregion

        #region Divide, IsUniform

        /// <summary>
        /// 벡터의 모든 성분을 다른 벡터로 나눕니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="other">나눌 벡터.</param>
        /// <returns>모든 성분이 다른 벡터로 나누어진 새 Vector2.</returns>
        public static Vector2 Divide(this Vector2 vector, Vector2 other) => vector / other;

        /// <summary>
        /// 벡터의 모든 성분이 같은지 확인합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>모든 성분이 같으면 true, 그렇지 않으면 false.</returns>
        public static bool IsUniform(this Vector2 vector) => Approx(vector.x, vector.y);

        #endregion

        #region InRangeOf


        /// <summary>
        /// 현재 Vector2가 대상 Vector2로부터 지정된 범위 내에 있는지 확인합니다.
        /// </summary>
        /// <param name="current">현재 Vector2 위치.</param>
        /// <param name="target">비교할 대상 Vector2 위치.</param>
        /// <param name="range">비교할 범위 값.</param>
        /// <returns>현재 Vector2가 대상으로부터 지정된 범위 내에 있으면 true, 그렇지 않으면 false.</returns>
        public static bool InRangeOf(this Vector2 current, Vector2 target, float range)
        {
            return (current - target).sqrMagnitude <= range * range;
        }

        #endregion

        #region Round

        /// <summary>
        /// Vector2의 각 컴포넌트를 지정된 소수점 자리까지 반올림합니다 (뱅커스 라운딩).
        /// </summary>
        /// <param name="vector">반올림할 Vector2.</param>
        /// <param name="to">반올림할 소수점 자리수 (기본값: 0).</param>
        /// <returns>각 컴포넌트가 뱅커스 라운딩으로 반올림된 새 Vector2.</returns>
        /// <remarks>
        /// 뱅커스 라운딩은 IEEE 754 표준에 정의된 반올림 방법 중 하나로,
        /// 중간값(예: 2.5)을 가장 가까운 짝수로 반올림합니다.
        /// </remarks>
        public static Vector2 Round(this Vector2 vector, int to = 0)
        {
            return new Vector2(
                (float)Math.Round(vector.x, to, MidpointRounding.ToEven),
                (float)Math.Round(vector.y, to, MidpointRounding.ToEven)
            );
        }

        /// <summary>
        /// Vector2의 각 컴포넌트를 지정된 소수점 자리까지 산술적으로 반올림합니다.
        /// </summary>
        /// <param name="vector">반올림할 Vector2.</param>
        /// <param name="to">반올림할 소수점 자리수 (기본값: 0).</param>
        /// <returns>각 컴포넌트가 산술적으로 반올림된 새 Vector2.</returns>
        /// <remarks>
        /// 산술적 반올림은 일반적으로 사용되는 반올림 방법으로,
        /// 중간값(예: 2.5)을 가장 가까운 큰 수로 반올림합니다.
        /// </remarks>
        public static Vector2 RoundArithmetic(this Vector2 vector, int to = 0)
        {
            return new Vector2(
                (float)Math.Round(vector.x, to, MidpointRounding.AwayFromZero),
                (float)Math.Round(vector.y, to, MidpointRounding.AwayFromZero)
            );
        }

        #endregion

        #region Rotate

        /// <summary>
        /// Vector2를 지정된 각도(라디안)만큼 회전시킵니다.
        /// </summary>
        /// <param name="vector">회전시킬 Vector2.</param>
        /// <param name="angle">회전 각도 (라디안).</param>
        /// <param name="pivot">회전 중심점 (기본값: (0, 0)).</param>
        /// <returns>회전된 Vector2.</returns>
        public static Vector2 RotateRadians(this Vector2 vector, float angle, Vector2? pivot = null)
        {
            Vector2 p = pivot ?? Vector2.zero;
            float cos = Mathf.Cos(angle);
            float sin = Mathf.Sin(angle);
            float x = vector.x - p.x;
            float y = vector.y - p.y;
            return new Vector2(x * cos - y * sin + p.x, x * sin + y * cos + p.y);
        }

        /// <summary>
        /// Vector2를 지정된 각도(도)만큼 회전시킵니다.
        /// </summary>
        /// <param name="vector">회전시킬 Vector2.</param>
        /// <param name="angle">회전 각도 (도).</param>
        /// <param name="pivot">회전 중심점 (기본값: (0, 0)).</param>
        /// <returns>회전된 Vector2.</returns>
        public static Vector2 Rotate(this Vector2 vector, float angle, Vector2? pivot = null)
        {
            return vector.RotateRadians(angle * Mathf.Deg2Rad, pivot);
        }

        /// <summary>
        /// Vector2를 시계 방향으로 90도 회전시킵니다.
        /// </summary>
        /// <param name="vector">회전시킬 Vector2.</param>
        /// <returns>회전된 Vector2.</returns>
        public static Vector2 Rotate90Clockwise(this Vector2 vector)
        {
            return new Vector2(vector.y, -vector.x);
        }

        /// <summary>
        /// Vector2를 반시계 방향으로 90도 회전시킵니다.
        /// </summary>
        /// <param name="vector">회전시킬 Vector2.</param>
        /// <returns>회전된 Vector2.</returns>
        public static Vector2 Rotate90CounterClockwise(this Vector2 vector)
        {
            return new Vector2(-vector.y, vector.x);
        }

        #endregion

        #region Abs

        /// <summary>
        /// Vector2의 각 컴포넌트를 절대값으로 변환합니다.
        /// </summary>
        /// <param name="vector">대상 Vector2.</param>
        /// <returns>각 컴포넌트가 절대값으로 변환된 새 Vector2.</returns>
        public static Vector2 Abs(this Vector2 vector)
        {
            return new Vector2(Mathf.Abs(vector.x), Mathf.Abs(vector.y));
        }

        #endregion


        #region ToVector3

        /// <summary>
        /// Vector2를 Vector3로 변환하며, 지정된 축에 값을 추가합니다.
        /// </summary>
        /// <param name="vector">변환할 Vector2.</param>
        /// <param name="z">z축 값 (기본값: 0).</param>
        /// <returns>변환된 Vector3.</returns>
        public static Vector3 ToVector3(this Vector2 vector, float z = 0f)
        {
            return new Vector3(vector.x, vector.y, z);
        }

        /// <summary>
        /// Vector2를 XZ 평면의 Vector3로 변환합니다.
        /// </summary>
        /// <param name="vector">변환할 Vector2.</param>
        /// <param name="y">y축 값 (기본값: 0).</param>
        /// <returns>XZ 평면상의 Vector3.</returns>
        public static Vector3 ToVector3XZ(this Vector2 vector, float y = 0f)
        {
            return new Vector3(vector.x, y, vector.y);
        }

        #endregion

        #region GetYX

        /// <summary>
        /// x와 y를 바꾼 벡터를 가져옵니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <returns>x와 y가 바뀐 새 Vector2.</returns>
        public static Vector2 GetYX(this Vector2 vector) => new(vector.y, vector.x);

        #endregion

        #region Dot, Cross, Project, Reflect

        /// <summary>
        /// 두 Vector2의 내적을 계산합니다.
        /// </summary>
        /// <param name="vector">첫 번째 Vector2.</param>
        /// <param name="other">두 번째 Vector2.</param>
        /// <returns>두 Vector2의 내적.</returns>
        public static float Dot(this Vector2 vector, Vector2 other)
        {
            return Vector2.Dot(vector, other);
        }

        /// <summary>
        /// 두 Vector2의 외적을 계산합니다.
        /// </summary>
        /// <param name="vector">첫 번째 Vector2.</param>
        /// <param name="other">두 번째 Vector2.</param>
        /// <returns>두 Vector2의 외적.</returns>
        public static float Cross(this Vector2 vector, Vector2 other)
        {
            return vector.x * other.y - vector.y * other.x;
        }

        /// <summary>
        /// Vector2를 다른 Vector2에 투영합니다.
        /// </summary>
        /// <param name="vector">투영할 Vector2.</param>
        /// <param name="onto">투영될 대상 Vector2.</param>
        /// <returns>투영된 Vector2.</returns>
        public static Vector2 Project(this Vector2 vector, Vector2 onto)
        {
            return Vector2.Dot(vector, onto) / onto.sqrMagnitude * onto;
        }

        /// <summary>
        /// Vector2를 법선 벡터를 기준으로 반사합니다.
        /// </summary>
        /// <param name="vector">반사할 Vector2.</param>
        /// <param name="normal">법선 벡터.</param>
        /// <returns>반사된 Vector2.</returns>
        public static Vector2 Reflect(this Vector2 vector, Vector2 normal)
        {
            return vector - 2 * Vector2.Dot(vector, normal) * normal;
        }

        #endregion

        #region Normalize

        /// <summary>
        /// Vector2를 정규화합니다.
        /// </summary>
        /// <param name="vector">정규화할 Vector2.</param>
        /// <returns>정규화된 Vector2.</returns>
        public static Vector2 Normalize(this Vector2 vector)
        {
            return vector.normalized;
        }

        #endregion

        #region Helpers

        // 한 범위에서 다른 범위로 단일 값을 다시 매핑하는 도우미 함수
        private static float Remap(float value, float min1, float max1, float min2, float max2)
        {
            return min2 + (value - min1) * (max2 - min2) / (max1 - min1);
        }

        // 근사 일치 검사를 위한 도우미 함수
        private static bool Approx(float a, float b, float tolerance = 1e-5f)
        {
            return Mathf.Abs(a - b) < tolerance;
        }

        #endregion

        #region Etc

        // TODO: 해당 메소드가 요구하는 바에 대하여 정확한 구현 및 검증이 되지 아니하였음.
        // /// <summary>
        // /// 원 내에 균등하게 분포된 점의 위치를 계산합니다.
        // /// </summary>
        // /// <param name="index">점의 인덱스.</param>
        // /// <param name="radius">원의 반지름.</param>
        // /// <param name="count">원 내의 전체 점 개수.</param>
        // /// <returns>계산된 균등 분포 점의 위치.</returns>
        // public static Vector2 EventlyDistributedPointOnCircle(int index, float radius, int count)
        // {
        //     var k = index + 0.5f;
        //     var r = Mathf.Sqrt((k) / count);
        //     var theta = Mathf.PI * (1f + Mathf.Sqrt(5f)) * k;

        //     var x = r * Mathf.Cos(theta) * radius;
        //     var y = r * Mathf.Sin(theta) * radius;

        //     return new Vector2(x, y);
        // }

        /// <summary>
        /// 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="points">비교할 점들.</param>
        /// <returns>가장 가까운 점의 정보(점, 인덱스)를 포함하는 튜플.</returns>
        public static (Vector2 point, int index) GetClosestPoint(
            this Vector2 point,
            params Vector2[] points
        )
        {
            return GetClosestPoint(point, (IEnumerable<Vector2>)points);
        }

        /// <summary>
        /// 주어진 점들 중에서 기준 점에 가장 가까운 점의 정보(점, 인덱스)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="points">비교할 점들.</param>
        /// <returns>가장 가까운 점의 정보(점, 인덱스)를 포함하는 튜플.</returns>
        public static (Vector2 point, int index) GetClosestPoint(
            this Vector2 point,
            IEnumerable<Vector2> points
        )
        {
            var enumerator = points.GetEnumerator();

            var index = -1;
            var closestIndex = -1;
            var closestPoint = Vector2.zero;
            var closestDistance = float.MaxValue;

            while (enumerator.MoveNext())
            {
                ++index;
                var distance = Vector2.Distance(point, enumerator.Current);

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
            this Vector2 point,
            Vector2 origin,
            Vector2 direction
        )
        {
            var distance = Vector2.Dot(point - origin, direction);
            return (origin + direction * distance, distance);
        }

        /// <summary>
        /// 선분(Line Segment) 상에서 기준 점에 가장 가까운 점의 정보(점, 거리)를 가져옵니다.
        /// </summary>
        /// <param name="point">기준 점.</param>
        /// <param name="start">선분의 시작점.</param>
        /// <param name="end">선분의 끝점.</param>
        /// <returns>선분 상의 가장 가까운 점의 정보(점, 거리)를 포함하는 튜플.</returns>
        public static (Vector2 point, float distance) GetClosestPointOnSegment(
            this Vector2 point,
            Vector2 start,
            Vector2 end
        )
        {
            var direction = end - start;
            var lineMagnitude = direction.magnitude;
            direction.Normalize();

            var distance = Mathf.Clamp(Vector2.Dot(point - start, direction), 0f, lineMagnitude);
            return (start + direction * distance, distance);
        }

        /// <summary>
        /// 주어진 각도만큼 방향 벡터를 임의로 편향시킵니다.
        /// </summary>
        /// <param name="direction">대상 방향 벡터.</param>
        /// <param name="angle">편향시킬 각도.</param>
        /// <returns>편향된 방향 벡터.</returns>
        public static Vector2 RandomDeflected(this Vector2 direction, float angle) =>
            Quaternion.AngleAxis(Random.value * angle.WithRandomSign(), Vector3.forward)
            * direction;

        /// <summary>
        /// x 축에 값을 삽입하고 벡터를 3차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="x">x 축에 삽입할 값.</param>
        /// <returns>3차원 벡터.</returns>
        public static Vector3 InsertX(this Vector2 vector, float x = 0) =>
            new(x, vector.x, vector.y);

        /// <summary>
        /// y 축에 값을 삽입하고 벡터를 3차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="y">y 축에 삽입할 값.</param>
        /// <returns>3차원 벡터.</returns>
        public static Vector3 InsertY(this Vector2 vector, float y = 0) =>
            new(vector.x, y, vector.y);

        /// <summary>
        /// z 축에 값을 삽입하고 벡터를 3차원으로 확장합니다.
        /// </summary>
        /// <param name="vector">대상 벡터.</param>
        /// <param name="z">z 축에 삽입할 값.</param>
        /// <returns>3차원 벡터.</returns>
        public static Vector3 InsertZ(this Vector2 vector, float z = 0) =>
            new(vector.x, vector.y, z);

        #endregion
    }
}
