namespace Leetcode.Exercises.CSharp.Easy
{
    public static class Solution
    {
        // Given an array nums of n integers where nums[i] is in the range[1, n], return an array of all the integers in the range[1, n] that do not appear in nums.
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var range = nums.Length;
            var result = new HashSet<int>();
            var numsSet = new HashSet<int>(nums);

            for (var i = 1; i <= range; i++)
            {
                if (!numsSet.Contains(i)) result.Add(i);
            }

            return [.. result];
        }
    }
}