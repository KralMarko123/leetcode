
namespace Leetcode.Exercises.CSharp.Medium
{
    // Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
    // You must write an algorithm that runs in O(n) time.
    public static class LongestConsecutiveSequence
    {
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length <= 1) return nums.Length;

            // hashset lookup is O(1)
            var set = nums.ToHashSet();
            var maxSequence = 1;

            foreach (var num in nums)
            {
                if (set.Contains(num - 1)) continue;

                var sequence = 1;

                // since lookup is O(1) worst case scenario is an interrupted sequence which would result in O(N)
                while (set.Contains(num + sequence)) sequence++;

                maxSequence = maxSequence < sequence ? sequence : maxSequence;
            }

            return maxSequence;
        }
    }
}
