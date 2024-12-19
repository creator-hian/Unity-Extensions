using System;
using System.Collections.Generic;

namespace Hian.Extensions
{
    /// <summary>
    /// IEnumerator<T> 에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class IEnumeratorExtensions
    {
        /// <summary>
        /// IEnumerator<T> 를 IEnumerable<T> 로 변환합니다.
        /// </summary>
        /// <typeparam name="T">요소의 타입.</typeparam>
        /// <param name="e">IEnumerator<T> 인스턴스. null 일 수 없습니다.</param>
        /// <returns>입력 인스턴스와 동일한 요소를 가진 IEnumerable<T>.</returns>
        /// <exception cref="ArgumentNullException">e 가 null 인 경우</exception>
        public static IEnumerable<T> ToEnumerable<T>(this IEnumerator<T> e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(
                    nameof(e),
                    "IEnumerator<T> 인스턴스는 null 일 수 없습니다."
                );
            }

            while (e.MoveNext())
            {
                yield return e.Current;
            }
        }
    }
}
