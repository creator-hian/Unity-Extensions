using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hian.Extensions
{
    public static class DateTimeExtensions
    {
        private const string DefaultCulture = "en-us";

        /// <summary>
        /// 특정 문화권에서 오늘의 요일에 대한 축약된 이름을 반환합니다.
        /// 기본 문화권은 "en-us"이며, "sun", "mon", ... "sat"을 반환합니다.
        /// </summary>
        /// <param name="culture">요일 이름을 가져올 문화권. null 이나 빈 문자열일 경우, 기본 문화권이 사용됩니다.</param>
        /// <returns>오늘의 요일에 대한 축약된 이름.</returns>
        public static string GetTodayAbbreviatedDayName(string culture = DefaultCulture)
        {
            var cultureInfo = GetCultureInfo(culture);
            return DateTime.Today.ToString("ddd", cultureInfo);
        }

        /// <summary>
        /// 특정 문화권에서 오늘의 요일에 대한 전체 이름을 반환합니다.
        /// 기본 문화권은 "en-us"이며, "sunday", "monday", ... "saturday"를 반환합니다.
        /// </summary>
        /// <param name="culture">요일 이름을 가져올 문화권. null 이나 빈 문자열일 경우, 기본 문화권이 사용됩니다.</param>
        /// <returns>오늘의 요일에 대한 전체 이름.</returns>
        public static string GetTodayDayName(string culture = DefaultCulture)
        {
            var cultureInfo = GetCultureInfo(culture);
            return DateTime.Today.ToString("dddd", cultureInfo);
        }

        /// <summary>
        /// 주어진 비교 문자열이 특정 문화권의 축약된 요일 이름과 일치하는지 확인합니다.
        /// </summary>
        /// <param name="comparison">비교할 문자열.</param>
        /// <param name="culture">비교에 사용할 문화권. null 이나 빈 문자열일 경우, 기본 문화권이 사용됩니다.</param>
        /// <returns>비교 문자열이 축약된 요일 이름과 일치하면 true, 그렇지 않으면 false.</returns>
        public static bool IsAbbreviatedDayName(string comparison, string culture = DefaultCulture)
        {
            if (string.IsNullOrEmpty(comparison))
                return false;

            var cultureInfo = GetCultureInfo(culture);
            var dayNames = new List<string>(cultureInfo.DateTimeFormat.AbbreviatedDayNames);

            return dayNames.Exists(name =>
                name.Equals(comparison, StringComparison.OrdinalIgnoreCase)
            );
        }

        /// < summary>
        /// 주어진 비교 문자열이 특정 문화권의 전체 요일 이름과 일치하는지 확인합니다.
        /// </summary>
        /// <param name="comparison">비교할 문자열.</param>
        /// <param name="culture">비교에 사용할 문화권. null 이나 빈 문자열일 경우, 기본 문화권이 사용됩니다.</param>
        /// <returns>비교 문자열이 전체 요일 이름과 일치하면 true, 그렇지 않으면 false.</returns>
        public static bool IsDayName(string comparison, string culture = DefaultCulture)
        {
            if (string.IsNullOrEmpty(comparison))
                return false;

            var cultureInfo = GetCultureInfo(culture);
            var dayNames = new List<string>(cultureInfo.DateTimeFormat.DayNames);

            return dayNames.Exists(name =>
                name.Equals(comparison, StringComparison.OrdinalIgnoreCase)
            );
        }

        private static CultureInfo GetCultureInfo(string culture)
        {
            return string.IsNullOrEmpty(culture)
                ? new CultureInfo(DefaultCulture)
                : new CultureInfo(culture);
        }
    }
}
