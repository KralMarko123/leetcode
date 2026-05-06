

namespace Leetcode.Exercises.CSharp.Easy
{
    //Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    public static class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var sAsArray = s.ToArray();
            var tAsArray = t.ToArray();

            Array.Sort(sAsArray);
            Array.Sort(tAsArray);

            return sAsArray.SequenceEqual(tAsArray);
        }
    }
}
