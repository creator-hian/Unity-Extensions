using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityRandom = UnityEngine.Random;

namespace Hian.Extensions
{
    /// <summary>
    /// IEnumerable에 대한 확장 메서드를 제공합니다.
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// <paramref name="enumerable"/>에서 임의의 요소를 가져옵니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <returns>열거형에서 임의의 요소.</returns>
        public static T GetRandom<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.ElementAt(UnityRandom.Range(0, enumerable.Count()));
        }

        /// <summary>
        /// <paramref name="enumerable"/>에서 임의의 요소들을 가져옵니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <param name="count">가져올 임의의 요소 개수.</param>
        /// <param name="clampCount"><paramref name="count"/>가 <paramref name="enumerable"/>의 요소 개수보다 클 경우, <paramref name="count"/>를 <paramref name="enumerable"/>의 요소 개수로 제한할지 여부.</param>
        /// <returns>열거형에서 임의의 요소들.</returns>
        public static List<T> GetRandoms<T>(
            this IEnumerable<T> enumerable,
            int count,
            bool clampCount = false
        )
        {
            if (clampCount)
            {
                count = Mathf.Min(count, enumerable.Count());
            }

            IEnumerable<int> poppedIndexes = Enumerable
                .Range(0, enumerable.Count())
                .ToList()
                .PopRandoms(count)
                .Select(p => p.element);
            return enumerable.Where((el, i) => poppedIndexes.Contains(i)).ToList();
        }

        /// <summary>
        /// <paramref name="enumerable"/>에서 지정된 요소들을 제외합니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <param name="elements">제외할 요소들.</param>
        /// <returns>지정된 요소들이 제외된 리스트.</returns>
        public static List<T> Except<T>(this IEnumerable<T> enumerable, params T[] elements)
        {
            return enumerable.Except((IEnumerable<T>)elements).ToList();
        }

        /// <summary>
        /// <paramref name="enumerable"/>을 섞습니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <returns>섞인 결과.</returns>
        public static List<T> Shuffled<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(static v => UnityRandom.value).ToList();
        }

        /// <summary>
        /// 열거형을 <see langword="[a, b, c, ...]"/> 형식의 문자열로 표현합니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <returns><paramref name="enumerable"/>의 문자열 표현.</returns>
        public static string AsString<T>(this IEnumerable<T> enumerable)
        {
            return $"[{string.Join(", ", enumerable)}]";
        }

        /// <summary>
        /// 확률 선택기를 사용하여 임의의 요소 인덱스를 가져옵니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <param name="probabilities">확률, <paramref name="enumerable"/>과 개수가 일치해야 합니다.</param>
        /// <returns>임의의 요소와 해당 인덱스를 포함하는 튜플.</returns>
        /// <exception cref="ArgumentException"><paramref name="enumerable"/>과 <paramref name="probabilities"/>의 개수가 일치하지 않을 때 발생합니다.</exception>
        public static (T element, int index) GetRandomWithProbability<T>(
            this IEnumerable<T> enumerable,
            params float[] probabilities
        )
        {
            return GetRandomWithProbability(enumerable, (IEnumerable<float>)probabilities);
        }

        /// <summary>
        /// 확률 선택기를 사용하여 임의의 요소 인덱스를 가져옵니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <param name="probabilities">확률, <paramref name="enumerable"/>과 개수가 일치해야 합니다.</param>
        /// <param name="probabilitiesSum">확률의 합.</param>
        /// <returns>임의의 요소와 해당 인덱스를 포함하는 튜플.</returns>
        /// <exception cref="ArgumentException"><paramref name="enumerable"/>과 <paramref name="probabilities"/>의 개수가 일치하지 않을 때 발생합니다.</exception>
        public static (T element, int index) GetRandomWithProbability<T>(
            this IEnumerable<T> enumerable,
            double? probabilitiesSum,
            params float[] probabilities
        )
        {
            return GetRandomWithProbability(enumerable, probabilities, (float)probabilitiesSum);
        }

        /// <summary>
        /// <inheritdoc cref="GetRandomWithProbability{T}"/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc cref="GetRandomWithProbability{T}"/></typeparam>
        /// <param name="enumerable"><inheritdoc cref="GetRandomWithProbability{T}" path="/param[@name='enumerable']"/></param>
        /// <param name="probabilities"><inheritdoc cref="GetRandomWithProbability{T}" path="/param[@name='probabilities']"/></param>
        /// <param name="probabilitiesSum">확률의 합.</param>
        /// <returns>임의의 요소와 해당 인덱스를 포함하는 튜플.</returns>
        /// <exception cref="ArgumentException"><paramref name="enumerable"/>과 <paramref name="probabilities"/>의 개수가 일치하지 않을 때 발생합니다.</exception>
        public static (T element, int index) GetRandomWithProbability<T>(
            this IEnumerable<T> enumerable,
            IEnumerable<float> probabilities,
            float? probabilitiesSum = null
        )
        {
            int count = enumerable.Count();

            if (probabilities.Count() != count)
            {
                throw new ArgumentException($"확률과 열거형 요소의 개수가 일치해야 합니다.");
            }

            if (count == 0)
            {
                throw new ArgumentException($"열거형의 개수는 0보다 커야 합니다.");
            }

            if (probabilitiesSum == null)
            {
                probabilitiesSum = 0f;

                foreach (float element in probabilities)
                {
                    probabilitiesSum += element;
                }
            }

            float randomValue = UnityRandom.value * probabilitiesSum.Value;

            float sum = 0f;
            int index = -1;

            IEnumerator<float> enumerator = probabilities.GetEnumerator();

            while (enumerator.MoveNext())
            {
                index += 1;
                float probability = enumerator.Current;

                sum += probability;

                if (randomValue < sum || randomValue.Approx(sum))
                {
                    return (enumerable.ElementAt(index), index);
                }
            }

            index = count - 1;
            return (enumerable.ElementAt(index), index);
        }

        /// <summary>
        /// <inheritdoc cref="GetRandomWithProbability{T}"/>
        /// </summary>
        /// <typeparam name="T"><inheritdoc cref="GetRandomWithProbability{T}"/></typeparam>
        /// <param name="enumerable"><inheritdoc cref="GetRandomWithProbability{T}" path="/param[@name='enumerable']"/></param>
        /// <param name="probabilitySelector">확률 선택자.</param>
        /// <param name="probabilitiesSum">확률의 합.</param>
        /// <returns>임의의 요소와 해당 인덱스를 포함하는 튜플.</returns>
        /// <exception cref="ArgumentException"><paramref name="enumerable"/>의 개수가 0일 때 발생합니다.</exception>
        public static (T element, int index) GetRandomWithProbability<T>(
            this IEnumerable<T> enumerable,
            Func<T, float> probabilitySelector,
            float? probabilitiesSum = null
        )
        {
            int count = enumerable.Count();

            if (count == 0)
            {
                throw new ArgumentException($"열거형의 개수는 0보다 커야 합니다.");
            }

            if (probabilitiesSum == null)
            {
                probabilitiesSum = 0f;

                foreach (T element in enumerable)
                {
                    probabilitiesSum += probabilitySelector(element);
                }
            }

            float randomValue = UnityRandom.value * probabilitiesSum.Value;

            float sum = 0f;
            int index = -1;

            IEnumerator<T> enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                index += 1;
                float probability = probabilitySelector(enumerator.Current);

                sum += probability;

                if (randomValue < sum || randomValue.Approx(sum))
                {
                    return (enumerator.Current, index);
                }
            }

            return (enumerator.Current, count - 1);
        }

        /// <summary>
        /// 모든 요소를 순회합니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <param name="action">각 요소에 대해 수행할 작업.</param>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T element in enumerable)
            {
                action(element);
            }
        }

        /// <summary>
        /// 표현식에 의해 최소값을 갖는 객체를 찾습니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <typeparam name="U"><paramref name="expression"/> 결과 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <param name="expression">최소값을 계산하는 데 사용되는 표현식.</param>
        /// <returns>표현식에 의해 최소값을 갖는 <see langword="(인덱스, 요소)"/> 튜플. 요소가 없으면 <see langword="(-1, default)"/>가 반환됩니다.</returns>
        public static (int index, T element) MinBy<T, U>(
            this IEnumerable<T> enumerable,
            Func<T, U> expression
        )
            where U : IComparable<U>
        {
            IEnumerator<T> enumerator = enumerable.GetEnumerator();

            if (!enumerator.MoveNext())
            {
                return (-1, default);
            }

            int minIndex = 0;
            T minObj = enumerator.Current;
            U minValue = expression(minObj);

            int index = 0;

            while (enumerator.MoveNext())
            {
                index += 1;
                U otherMinValue = expression(enumerator.Current);

                if (otherMinValue.CompareTo(minValue) > -1)
                {
                    continue;
                }

                minIndex = index;
                minObj = enumerator.Current;
                minValue = otherMinValue;
            }

            return (minIndex, minObj);
        }

        /// <summary>
        /// 표현식에 의해 최대값을 갖는 객체를 찾습니다.
        /// </summary>
        /// <typeparam name="T">요소 타입.</typeparam>
        /// <typeparam name="U"><paramref name="expression"/> 결과 타입.</typeparam>
        /// <param name="enumerable">대상 열거형.</param>
        /// <param name="expression">최대값을 계산하는 데 사용되는 표현식.</param>
        /// <returns>표현식에 의해 최대값을 갖는 <see langword="(인덱스, 요소)"/> 튜플. 요소가 없으면 <see langword="(-1, default)"/>가 반환됩니다.</returns>
        public static (int index, T element) MaxBy<T, U>(
            this IEnumerable<T> enumerable,
            Func<T, U> expression
        )
            where U : IComparable<U>
        {
            IEnumerator<T> enumerator = enumerable.GetEnumerator();

            if (!enumerator.MoveNext())
            {
                return (-1, default);
            }

            int maxIndex = 0;
            T maxObj = enumerator.Current;
            U maxValue = expression(maxObj);

            int index = 0;

            while (enumerator.MoveNext())
            {
                index += 1;
                U otherMinValue = expression(enumerator.Current);

                if (otherMinValue.CompareTo(maxValue) < 1)
                {
                    continue;
                }

                maxIndex = index;
                maxObj = enumerator.Current;
                maxValue = otherMinValue;
            }

            return (maxIndex, maxObj);
        }
    }
}
