using System;

namespace NorthWindPracticeWeb.Common.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// 擷取字串(依length長度)由後開始擷取
        /// </summary>
        /// <param name="text">字串</param>
        /// <param name="length">擷取字數</param>
        public static string BehindSubstring(this string text, int length)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentNullException(nameof(text));
            }

            if (text.Length < length)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }

            return text.Substring(text.Length - length, length);
        }

        /// <summary>
        ///驗證字串是否有值
        /// </summary>
        /// <param name="value"></param>
        public static bool HasValue(this string value)
        {
            return string.IsNullOrWhiteSpace(value).Equals(false);
        }
        /// <summary>
        /// 驗證字串是否為空或值為空白.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [is null or white space] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
        /// <summary>
        /// 驗證字串是否為空值.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [is null or empty] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}