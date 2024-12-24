using UnityEngine;

namespace Hian.Extensions
{
    public static class FloatExtensions
    {
        /// <summary>
        /// 한 범위의 값을 다른 범위로 다시 매핑합니다.
        /// </summary>
        /// <param name="value">원본 값.</param>
        /// <param name="min1">원본 범위의 최소값.</param>
        /// <param name="max1">원본 범위의 최대값.</param>
        /// <param name="min2">새로운 범위의 최소값.</param>
        /// <param name="max2">새로운 범위의 최대값.</param>
        /// <returns>새로운 범위로 다시 매핑된 값.</returns>
        public static float Remap(this float value, float min1, float max1, float min2, float max2)
        {
            return min2 + ((value - min1) * (max2 - min2) / (max1 - min1));
        }

        /// <summary>
        /// 두 부동 소수점 숫자가 근사치 수준으로 같은지 여부를 확인합니다.
        /// </summary>
        /// <param name="a">첫 번째 부동 소수점 숫자.</param>
        /// <param name="b">두 번째 부동 소수점 숫자.</param>
        /// <returns>두 숫자가 거의 같으면 true를 반환하고, 그렇지 않으면 false를 반환합니다.</returns>
        public static bool Approx(this float a, float b)
        {
            return Mathf.Abs(b - a)
                < Mathf.Max(0.0000001f * Mathf.Max(Mathf.Abs(a), Mathf.Abs(b)), Mathf.Epsilon * 8);
        }

        /// <summary>
        /// 값의 부호(+ 또는 -)를 임의로 변경합니다.
        /// </summary>
        /// <param name="value">대상 값.</param>
        /// <returns>부호가 임의로 변경된 값.</returns>
        public static float WithRandomSign(this float value)
        {
            return value * ((Random.Range(0, 2) * 2) - 1);
        }
    }
}
