﻿namespace NewTranslator
{
    internal static class StringExtensions
    {
        /// <summary>
        /// Restores the beginning and end of string eliminated by trim
        /// using the start and the end of the reference string.
        /// </summary>
        /// <param name="trimmedText">Trimmed string.</param>
        /// <param name="originalText">Reference string.</param>
        /// <returns></returns>
        internal static string TrimRestore(this string trimmedText, string originalText)
        {
            if (string.IsNullOrWhiteSpace(trimmedText) || string.IsNullOrEmpty(originalText))
                return trimmedText;

            var length = originalText.Length;
            var firstChar = length - originalText.TrimStart().Length;
            if (firstChar > -1)
            {
                trimmedText = originalText.Substring(0, firstChar) + trimmedText;
            }

            var startIndex = originalText.TrimEnd().Length;
            var lastChar = length - startIndex;
            if (lastChar > -1)
            {
                trimmedText += originalText.Substring(startIndex, lastChar);
            }

            return trimmedText;
        }
    }
}