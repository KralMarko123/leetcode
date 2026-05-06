
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given a pattern and a string s, find if s follows the same pattern.
    // Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
    public static class WordPattern
    {
        public static bool IsWordPattern(string pattern, string s)
        {
            var words = s.Split(' ');
            var dictionary = new Dictionary<char, string>();
            var set = new HashSet<string>();

            if (words.Length != pattern.Length) return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dictionary.ContainsKey(pattern[i]))
                {
                    if (set.Contains(words[i])) return false;

                    dictionary.Add(pattern[i], words[i]);
                    set.Add(words[i]);
                }
                else if (dictionary[pattern[i]] != words[i]) return false;
            }

            return true;
        }
    }
}
