using System.Text.RegularExpressions;

namespace Leetcode.Exercises.CSharp.Easy
{
    // A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.Alphanumeric characters include letters and numbers.
    // Given a string s, return true if it is a palindrome, or false otherwise.
    public static class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            s = Regex.Replace(s.ToLower(), @"[^A-Za-z0-9]+", "");

            for (var i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i]) return false;
            }

            return true;
        }

    }
}
