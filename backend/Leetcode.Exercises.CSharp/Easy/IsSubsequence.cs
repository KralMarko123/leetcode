
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    // A subsequence of a string is a new string that is formed from the original string by deleting some(can be none) of the characters without disturbing the relative positions of the remaining characters.
    // (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    public static class IsSubsequence
    {
        public static bool IsSubSequence(string s, string t)
        {
            var filteredSequence = string.Empty;
            var i = 0;
            var j = 0;

            while(i < s.Length && j < t.Length)
            {
                if (t[j] == s[i]) 
                {
                    filteredSequence += t[j];
                    i++;
                }

                j++;
            }

            return filteredSequence == s;
        }
    }
}
