using System;
using System.Collections.Generic;
using System.Linq;
#if UNITY_5_3_OR_NEWER
using UnityEngine;
#endif

namespace Hian.Extensions
{
    /// <summary>
    /// IList에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class IListExtensions
    {
#if !UNITY_5_3_OR_NEWER
        private static readonly Random _random = new Random();
#endif

        /// <summary>
        /// <paramref name="index"/>에 있는 요소를 꺼냅니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">요소를 포함하는 리스트.</param>
        /// <param name="index">꺼낼 요소의 인덱스.</param>
        /// <returns>꺼낸 요소.</returns>
        public static T Pop<T>(this IList<T> list, int index)
        {
            T element = list[index];
            list.RemoveAt(index);

            return element;
        }

        /// <summary>
        /// <paramref name="indexes"/>에 있는 요소들을 꺼냅니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">요소를 포함하는 리스트.</param>
        /// <param name="indexes">꺼낼 요소들의 인덱스.</param>
        /// <returns>꺼낸 요소들.</returns>
        public static List<T> Pop<T>(this IList<T> list, params int[] indexes)
        {
            List<T> popped = new List<T>();

            foreach (int index in indexes)
            {
                popped.Add(list[index]);
            }

            foreach (int index in indexes.OrderByDescending(static i => i))
            {
                list.RemoveAt(index);
            }

            return popped;
        }

        /// <summary>
        /// 리스트의 마지막 요소를 반환하고 제거합니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="list">대상 리스트.</param>
        /// <returns>마지막 요소.</returns>
        /// <exception cref="InvalidOperationException">리스트가 비어있을 경우 발생.</exception>
        public static T PopLast<T>(this IList<T> list)
        {
            if (list.IsNullOrEmpty())
            {
                throw new InvalidOperationException("리스트가 비어있습니다.");
            }

            int lastIndex = list.Count - 1;
            T lastItem = list[lastIndex];
            list.RemoveAt(lastIndex);
            return lastItem;
        }

        /// <summary>
        /// 리스트의 첫 번째 요소를 반환하고 제거합니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="list">대상 리스트.</param>
        /// <returns>첫 번째 요소.</returns>
        /// <exception cref="InvalidOperationException">리스트가 비어있을 경우 발생.</exception>
        public static T PopFirst<T>(this IList<T> list)
        {
            if (list.IsNullOrEmpty())
            {
                throw new InvalidOperationException("리스트가 비어있습니다.");
            }

            T firstItem = list[0];
            list.RemoveAt(0);
            return firstItem;
        }

        /// <summary>
        /// <paramref name="list"/>에서 임의의 요소를 꺼냅니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">요소를 포함하는 리스트.</param>
        /// <returns>꺼낸 요소와 해당 인덱스를 포함하는 튜플.</returns>
        public static (T element, int index) PopRandom<T>(this IList<T> list)
        {
#if UNITY_5_3_OR_NEWER
            int index = UnityEngine.Random.Range(0, list.Count);
#else
            int index = _random.Next(0, list.Count);
#endif
            return (list.Pop(index), index);
        }

        /// <summary>
        /// 리스트에서 임의의 요소들을 꺼냅니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">요소를 포함하는 리스트.</param>
        /// <param name="count">꺼낼 요소의 개수.</param>
        /// <param name="clampCount"><paramref name="count"/>를 <paramref name="list"/>의 요소 개수로 제한할지 여부.</param>
        /// <returns>꺼낸 요소와 해당 인덱스를 포함하는 튜플의 리스트.</returns>
        public static List<(T element, int index)> PopRandoms<T>(
            this IList<T> list,
            int count,
            bool clampCount = false
        )
        {
            if (clampCount)
            {
#if UNITY_5_3_OR_NEWER
                count = Mathf.Clamp(count, 0, list.Count);
#else
                count = Math.Max(0, Math.Min(count, list.Count));
#endif
            }

            List<(T element, int index)> popped = new List<(T element, int index)>();

            for (int i = 0; i < count; i++)
            {
                popped.Add(list.PopRandom());
            }

            return popped;
        }

        /// <summary>
        /// 지정된 확률로 리스트에서 임의의 요소를 꺼냅니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">요소를 포함하는 리스트.</param>
        /// <param name="probabilities">확률, <paramref name="list"/>와 개수가 일치해야 합니다.</param>
        /// <returns>꺼낸 요소.</returns>
        public static (T element, int index) PopRandomWithProbability<T>(
            this IList<T> list,
            params float[] probabilities
        )
        {
            return PopRandomWithProbability(list, (IEnumerable<float>)probabilities);
        }

        /// <summary>
        /// 지정된 확률로 리스트에서 임의의 요소를 꺼냅니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">요소를 포함하는 리스트.</param>
        /// <param name="probabilities">확률, <paramref name="list"/>와 개수가 일치해야 합니다.</param>
        /// <returns>꺼낸 요소.</returns>
        public static (T element, int index) PopRandomWithProbability<T>(
            this IList<T> list,
            IEnumerable<float> probabilities
        )
        {
            (T element, int index) random = list.GetRandomWithProbability(probabilities);
            _ = Pop(list, random.index);

            return random;
        }

        /// <summary>
        /// 지정된 확률 선택기를 사용하여 리스트에서 임의의 요소를 꺼냅니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">요소를 포함하는 리스트.</param>
        /// <param name="probabilitiesSelector">확률 선택기.</param>
        /// <returns>꺼낸 요소.</returns>
        public static (T element, int index) PopRandomWithProbability<T>(
            this IList<T> list,
            Func<T, float> probabilitiesSelector
        )
        {
            (T element, int index) random = list.GetRandomWithProbability(probabilitiesSelector);
            _ = Pop(list, random.index);

            return random;
        }

        /// <summary>
        /// <paramref name="index"/>부터 모든 요소를 제거합니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="list">대상 리스트.</param>
        /// <param name="index">제거를 시작할 인덱스.</param>
        public static void RemoveRange<T>(this IList<T> list, int index)
        {
            for (int i = list.Count - 1; i >= index; i--)
            {
                list.RemoveAt(i);
            }
        }

        /// <summary>
        /// <paramref name="list"/>를 섞습니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">원본 리스트.</param>
        /// <returns>섞인 원본 리스트.</returns>
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;

            while (n > 1)
            {
#if UNITY_5_3_OR_NEWER
                int index = UnityEngine.Random.Range(0, --n + 1);
#else
                int index = _random.Next(0, --n + 1);
#endif
                (list[index], list[n]) = (list[n], list[index]);
            }

            return list;
        }

        /// <summary>
        /// 두 요소를 바꿉니다.
        /// </summary>
        /// <typeparam name="T">소스 타입.</typeparam>
        /// <param name="list">원본 리스트.</param>
        /// <param name="index1">바꿀 첫 번째 인덱스.</param>
        /// <param name="index2">바꿀 두 번째 인덱스.</param>
        /// <returns>원본 리스트.</returns>
        public static IList<T> Swap<T>(this IList<T> list, int index1, int index2)
        {
            (list[index1], list[index2]) = (list[index2], list[index1]);
            return list;
        }

        /// <summary>
        /// 리스트가 null이거나 비어있는지 확인합니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="list">검사할 리스트.</param>
        /// <returns>리스트가 null이거나 비어있으면 true, 그렇지 않으면 false.</returns>
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null || list.Count == 0;
        }

        /// <summary>
        /// 리스트의 요소들을 역순으로 배치합니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="list">대상 리스트.</param>
        /// <returns>역순으로 배치된 원본 리스트.</returns>
        public static IList<T> Reverse<T>(this IList<T> list)
        {
            int left = 0;
            int right = list.Count - 1;

            while (left < right)
            {
                (list[left], list[right]) = (list[right], list[left]);
                left++;
                right--;
            }

            return list;
        }
    }
}
