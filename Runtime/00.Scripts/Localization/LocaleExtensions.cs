#if UNITY_LOCALIZATION_AVAILABLE
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

namespace Unity.Extensions
{
    public static class LocaleExtensions
    {
        public static List<Locale> Locales => LocalizationSettings.AvailableLocales.Locales;

        public static string LocaleString => LocalizationSettings.SelectedLocale.LocaleToString();

        public static int GetLocaleIndex()
        {
            return Locales.IndexOf(LocalizationSettings.SelectedLocale);
        }

        public static void SetLocale(int index)
        {
            int targetLocaleIndex = index;

            if (Locales.Count <= index)
            {
                Debug.LogWarning($"Index {index} is out of range. Set to the last index.");
                targetLocaleIndex = Locales.Count - 1;
            }

            LocalizationSettings.SelectedLocale = Locales[targetLocaleIndex];
        }

        public static void SetLocale(Locale locale)
        {
            LocalizationSettings.SelectedLocale = locale;
        }

        public static string GetLocalizedString(string table, string key)
        {
            var locale = LocalizationSettings.SelectedLocale;
            return LocalizationSettings.StringDatabase.GetLocalizedString(table, key, locale);
        }

        public static string LocaleToString(this Locale locale)
        {
            // Identifier.Code를 사용해서 "xx-XX" 형식으로 가져옴
            return locale.Identifier.Code;
        }
    }
}
#endif
