using System;
using System.Linq;

namespace Hian.Extensions
{
    /// <summary>
    /// IEquatable 인터페이스에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class IEquatableExtensions
    {
        /// <summary>
        /// <paramref name="value"/>가 <paramref name="values"/> 배열의 모든 요소와 같은지 확인합니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="value">비교할 객체.</param>
        /// <param name="values">비교할 객체 배열.</param>
        /// <returns><paramref name="values"/>의 모든 요소가 <paramref name="value"/>와 같으면 <see langword="true"/>를 반환합니다.</returns>
        public static bool EqualsToAll<T>(this T value, params T[] values)
            where T : IEquatable<T> => values.All(o => o.Equals(value));

        /// <summary>
        /// <paramref name="value"/>가 <paramref name="values"/> 배열의 요소 중 하나 이상과 같은지 확인합니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="value">비교할 객체.</param>
        /// <param name="values">비교할 객체 배열.</param>
        /// <returns><paramref name="values"/>의 요소 중 하나 이상이 <paramref name="value"/>와 같으면 <see langword="true"/>를 반환합니다.</returns>
        public static bool EqualsToAny<T>(this T value, params T[] values)
            where T : IEquatable<T> => values.Any(o => o.Equals(value));
    }
}
