using System;

namespace Hian.Extensions
{
    /// <summary>
    /// IComparable 인터페이스에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class IComparableExtensions
    {
        /// <summary>
        /// 값이 지정된 간격 내에 있는지 확인합니다.
        /// </summary>
        /// <typeparam name="T">값의 타입.</typeparam>
        /// <param name="value">대상 값.</param>
        /// <param name="a">간격의 시작 값.</param>
        /// <param name="b">간격의 끝 값.</param>
        /// <param name="aInclusive">간격의 시작 값을 포함할지 여부.</param>
        /// <param name="bInclusive">간격의 끝 값을 포함할지 여부.</param>
        /// <returns><paramref name="value"/>가 <paramref name="a"/>와 <paramref name="b"/> 사이에 있으면 <see langword="true"/>를 반환하고, 그렇지 않으면 <see langword="false"/>를 반환합니다.</returns>
        public static bool IsBetween<T>(
            this T value,
            T a,
            T b,
            bool aInclusive = true,
            bool bInclusive = true
        )
            where T : IComparable
        {
            if (a.CompareTo(b) == 1)
            {
                (a, b) = (b, a);
                (aInclusive, bInclusive) = (bInclusive, aInclusive);
            }

            return (aInclusive ? value.CompareTo(a).EqualsToAny(0, 1) : value.CompareTo(a) == 1)
                && (bInclusive ? value.CompareTo(b).EqualsToAny(-1, 0) : value.CompareTo(b) == -1);
        }
    }
}
