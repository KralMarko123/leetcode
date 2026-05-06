
namespace LeetcodeExercises.Easy
{
    //Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
    //Each letter in magazine can only be used once in ransomNote.
    public static class RansomNote
    {
        private static Dictionary<char, int> GenerateDictionaryForLetters(string word)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var character in word)
            {
                if (!dictionary.ContainsKey(character)) dictionary.Add(character, 1);
                else dictionary[character]++;
            }

            return dictionary;
        }

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            var possibleLetters = GenerateDictionaryForLetters(magazine);
            var lettersUsed = GenerateDictionaryForLetters(ransomNote);
            var canBeConstructed = true;

            foreach (var letter in lettersUsed.Keys)
            {
                if (!possibleLetters.ContainsKey(letter)) return false;
                if (lettersUsed[letter] > possibleLetters[letter]) return false;
            }

            return canBeConstructed;
        }
    }
}
