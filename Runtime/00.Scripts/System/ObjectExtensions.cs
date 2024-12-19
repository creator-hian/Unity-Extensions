using System.Linq;

namespace Hian.Extensions
{
    /// <summary>
    /// Object 클래스에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// <paramref name="obj"/>가 <paramref name="objects"/> 배열의 모든 요소와 같은지 확인합니다.
        /// </summary>
        /// <param name="obj">비교할 객체.</param>
        /// <param name="objects">비교할 객체 배열.</param>
        /// <returns><paramref name="objects"/>의 모든 요소가 <paramref name="obj"/>와 같으면 <see langword="true"/>를 반환합니다.</returns>
        public static bool EqualsToAll(this object obj, params object[] objects) =>
            objects.All(o => o.Equals(obj));

        /// <summary>
        /// <paramref name="obj"/>가 <paramref name="objects"/> 배열의 요소 중 하나 이상과 같은지 확인합니다.
        /// </summary>
        /// <param name="obj">비교할 객체.</param>
        /// <param name="objects">비교할 객체 배열.</param>
        /// <returns><paramref name="objects"/>의 요소 중 하��� 이상이 <paramref name="obj"/>와 같으면 <see langword="true"/>를 반환합니다.</returns>
        public static bool EqualsToAny(this object obj, params object[] objects) =>
            objects.Any(o => o.Equals(obj));
    }
}
