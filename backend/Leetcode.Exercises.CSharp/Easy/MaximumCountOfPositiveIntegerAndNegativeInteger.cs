
namespace Leetcode.Exercises.CSharp.Easy
{
    // Given an array nums sorted in non-decreasing order, return the maximum between the number of positive integers and the number of negative integers.
    // In other words, if the number of positive integers in nums is pos and the number of negative integers is neg, then return the maximum of pos and neg.
    // Note that 0 is neither positive nor negative.
    public static class MaximumCountOfPositiveIntegerAndNegativeInteger
    {
        public static int MaximumCount(int[] nums)
        {
            if (nums == null || nums[0] == 0 && nums[nums.Length - 1] == 0) return 0;

            var i = 0;
            var j = nums.Length - 1;

            // binary search to find position of the first positive number
            while (i < j)
            {
                if (nums[i + (j - i) / 2] <= 0) i = i + (j - i) / 2 + 1;
                else j = i + (j - i) / 2;
            }

            j = i;

            // get rid of zeros and decrement the pointer until we get to the position of the last negative number
            while (nums[i] >= 0 && i > 0) --i;

            return Math.Max(nums.Length - j, i + 1);
        }
    }
}
