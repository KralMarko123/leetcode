
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given a string s, find the first non-repeating character in it and return its index.
    // If it does not exist, return -1.
    public static class FirstUniqueCharacterInAString
    {
        public static int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();

            foreach (var character in s)
            {
                if (!dict.ContainsKey(character)) dict[character] = 1;
                else dict[character]++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1) return i;
            }

            return -1;
        }
    }
}
