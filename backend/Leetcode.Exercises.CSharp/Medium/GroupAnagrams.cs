
using Leetcode.Exercises.CSharp.Easy;
using System.Collections.ObjectModel;

namespace Leetcode.Exercises.CSharp.Medium
{
    //Given an array of strings strs, group the anagrams together. You can return the answer in any order.
    //An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    public static class Group_Anagrams
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();

            for (int i = 0; i < strs.Length; i++)
            {
                var wordAsArray = strs[i].ToCharArray();
                Array.Sort(wordAsArray);
                var sortedWord = new string(wordAsArray);

                if (!dict.ContainsKey(sortedWord))
                {
                    dict.Add(sortedWord, new List<String>() { strs[i] });
                }
                else
                {
                    dict[sortedWord].Add(strs[i]);
                }
            }

            return dict.Values.ToList();
        }
    }
}
