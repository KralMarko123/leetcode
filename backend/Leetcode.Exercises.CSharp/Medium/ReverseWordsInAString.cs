
using System.Text;
using System.Text.RegularExpressions;

namespace Leetcode.Exercises.CSharp.Medium
{
    public static class ReverseWordsInAString
    {
        // Given an input string s, reverse the order of the words.
        // A word is defined as a sequence of non-space characters.The words in s will be separated by at least one space.
        // Return a string of the words in reverse order concatenated by a single space.
        // Note that s may contain leading or trailing spaces or multiple spaces between two words.
        // The returned string should only have a single space separating the words. Do not include any extra spaces.
        public static string ReverseWordsUsingRegex(string s)
        {
            var words = Regex.Split(s, @"\s+");
            var sb = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                sb.Append(words[i]);
                sb.Append(' ');
            }

            return sb.ToString().Trim();
        }

        public static string ReverseWords(string s)
        {
            var sb = new StringBuilder();
            var words = new List<string>();
            var wordHasStarted = false;
            var wordStart = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(s[i].ToString()))
                {
                    if (!wordHasStarted)
                    {
                        wordHasStarted = true;
                        wordStart = i;
                    }

                    if (i == s.Length - 1)
                    {
                        words.Add(s[wordStart..s.Length]);
                        break;
                    }
                }
                else if (wordHasStarted)
                {
                    words.Add(s[wordStart..i]);
                    wordHasStarted = false;
                }
            }

            for (int i = words.Count - 1; i >= 0; i--)
            {
                sb.Append(words.ElementAt(i));
                sb.Append(' ');
            }

            return sb.ToString().Trim();
        }
    }
}