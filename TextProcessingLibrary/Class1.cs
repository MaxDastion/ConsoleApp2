using System;
using System.Linq;

namespace TextProcessingLibrary
{
    public static class TextProcessor
    {
        public static bool IsPalindrome(string text)
        {
            string cleaned = new string(text.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            return cleaned.SequenceEqual(cleaned.Reverse());
        }

        public static int SentenceCount(string text) => text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

        public static string ReverseString(string text) => new string(text.Reverse().ToArray());
    }
}