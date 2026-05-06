using System.Text;

namespace Leetcode.Exercises.CSharp.Easy
{
    // Given a string s, reverse only all the vowels in the string and return it.
    // The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
    public static class ReverseVowelsOfAString
    {
        public static string ReverseVowels(string s)
        {
            var i = 0;
            var j = s.Length - 1;
            var letters = s.ToCharArray();

            while (i < j)
            {
                if (!IsVowel(letters[i]))
                {
                    i++;
                    continue;
                }

                if (!IsVowel(letters[j]))
                {
                    j--;
                    continue;
                }

                (letters[j], letters[i]) = (letters[i], letters[j]);
                i++;
                j--;
            }

            return new string(letters);
        }

        public static bool IsVowel(char c)
        {

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') return true;
            else return false;
        }
    }
}
