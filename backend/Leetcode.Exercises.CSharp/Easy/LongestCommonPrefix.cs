
using System.Text;

namespace Leetcode.Exercises.CSharp.Easy
{
    // Write a function to find the longest common prefix string amongst an array of strings.
    // If there is no common prefix, return an empty string "".
    public static class LongestCommonPrefix
    {
        public static string LongestCommon(string[] strs)
        {
            // sort the array to have the first/last word have the shortest/longest lengths respectively
            Array.Sort(strs);
            var sb = new StringBuilder();

            // loop over the number of characters the shortest word has and check if the last word has the same character at that position
            for (var i = 0; i < strs[0].Length; i++)
            {
                if (strs[0][i] != strs[strs.Length - 1][i]) return sb.ToString();
                sb.Append(strs[0][i]);
            }

            return sb.ToString();
        }
    }
}
