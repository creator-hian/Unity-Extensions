using System;
using Random = UnityEngine.Random;

namespace Hian.Extensions
{
    public static class DoubleExtensions
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
        public static double Remap(
            this double value,
            double min1,
            double max1,
            double min2,
            double max2
        )
        {
            return min2 + ((value - min1) * (max2 - min2) / (max1 - min1));
        }

        /// <summary>
        /// 두 double 값이 허용 오차 범위 내에서 근사적으로 같은지 확인합니다.
        /// </summary>
        /// <param name="value">첫 번째 값.</param>
        /// <param name="other">두 번째 값.</param>
        /// <param name="epsilon">허용 오차 (기본값: 1E-17).</param>
        /// <returns>두 값이 허용 오차 범위 내에서 근사적으로 같으면 true, 그렇지 않으면 false.</returns>
        public static bool Approx(this double value, double other, double epsilon = 1E-17)
        {
            return Math.Abs(value - other)
                <= Math.Max(
                    epsilon * Math.Max(Math.Abs(value), Math.Abs(other)),
                    double.Epsilon * 8
                );
        }
    }
}
