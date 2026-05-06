
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Leetcode.Exercises.CSharp.Medium
{
    public static class TopKFrequentElements
    {
        // Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
        public static int[] TopKFrequent(int[] nums, int k)
        {
            var result = new List<int>();
            var dictionary = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!dictionary.ContainsKey(num)) dictionary.Add(num, 1);
                else dictionary[num]++;
            }

            var groupedValues = new List<int>[dictionary.Values.Max() + 1];

            foreach (var (key, value) in dictionary)
            {
                if (groupedValues[value] == null) groupedValues[value] = new List<int>();
                groupedValues[value].Add(key);
            }

            for (var i = groupedValues.Length - 1; i >= 0; i--)
            {
                if (k == 0) break;
                if (groupedValues[i] == null) continue;

                result.AddRange(groupedValues[i]);
                k -= groupedValues[i].Count;
            }

            return result.ToArray();
        }
    }
}
